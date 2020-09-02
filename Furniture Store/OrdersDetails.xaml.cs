using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Oracle.DataAccess.Client;

namespace Furniture_Store
{
    /// <summary>
    /// Логика взаимодействия для OrdersDetails.xaml
    /// </summary>
    public partial class OrdersDetails : Page
    {
        DbClass b = new DbClass();
        int idDel;
        public OrdersDetails(int _idOrder)
        {
            int id_empp = 1;
            InitializeComponent();
            b.GetAllOrders(MainPage.UserIsAdmin);
            b.GetAllEmployees(MainPage.UserIsAdmin);
            b.GetAllDeliverys(MainPage.UserIsAdmin);
            foreach(Order i in DbClass.UsersOrders)
            {
                if (i.Id_order == _idOrder)
                {
                    idOrder.Text = i.Id_order.ToString();
                    orderCost.Text = i.OrderCost.ToString();
                    date.Text = i.OrderDate;
                    id_empp = i.Id_employee;
                    deliveryPointName.Text = i.DeliveryPointName;
                }
            }

            foreach (Employee j in DbClass.Employees)
            {
                if (j.Id_employee == id_empp)
                {
                    fullnameEmployee.Text = j.FullName;
                }
            }

            foreach(Delivery i in DbClass.Deliverys)
            {
                if (i.Id_order == _idOrder)
                {
                    orderStatus.Text = i.Status;
                    idDel = i.Id_delivery;
                }
            }
        }

        private void BackBut_Click(object sender, RoutedEventArgs e)
        {
            MainPage._MainFrame.Content = new Orders();
        }

        private void ConfirmOrderBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(idDel.ToString());
            OracleConnection con = new OracleConnection(b.CheckUser(MainPage.UserIsAdmin));
            con.Open();
            OracleCommand cmd = new OracleCommand("UpdateStatusDelivery", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("status", OracleDbType.Varchar2, "Успешно выполнен", System.Data.ParameterDirection.Input);
            OracleParameter oraP1 = new OracleParameter("id", OracleDbType.Int32, idDel, System.Data.ParameterDirection.Input);
            cmd.Parameters.Add(oraP);
            cmd.Parameters.Add(oraP1);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Заказ выполнен успешно!", "Успех!");
            con.Clone();
        }
    }
}
