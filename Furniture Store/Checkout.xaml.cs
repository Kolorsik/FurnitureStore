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
    /// Логика взаимодействия для Checkout.xaml
    /// </summary>
    public partial class Checkout : Page
    {
        DbClass b = new DbClass();
        int ordercost_;
        public Checkout(int _ordercost)
        {
            InitializeComponent();
            List<string> vs = new List<string>();
            b.GetAllDeliveryPoints(MainPage.UserIsAdmin);
            foreach(DeliveryPoint i in DbClass.DeliveryPoints)
            {
                vs.Add(i.Name);
            }
            deliveryPoint.ItemsSource = vs;
            orderCost.Text = _ordercost.ToString();
            orderDate.Text = DateTime.Now.ToShortDateString();
            ordercost_ = _ordercost;
        }

        private void ConfirmOrder_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            b.GetAllEmployees(MainPage.UserIsAdmin);
            int emp = rnd.Next(1, DbClass.Employees.Count);

            OracleConnection con = new OracleConnection(DbClass.connectionAdmin);
            con.Open();
            OracleCommand cmd = new OracleCommand("InsertOrder", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP1 = new OracleParameter("orddate", OracleDbType.Varchar2, DateTime.Now.ToShortDateString(), System.Data.ParameterDirection.Input);
            OracleParameter oraP2 = new OracleParameter("ordercost", OracleDbType.Int32, ordercost_, System.Data.ParameterDirection.Input);
            OracleParameter oraP3 = new OracleParameter("userlogin", OracleDbType.Varchar2, MainPage.Username, System.Data.ParameterDirection.Input);
            OracleParameter oraP4 = new OracleParameter("id_emp", OracleDbType.Int32, emp, System.Data.ParameterDirection.Input);
            OracleParameter oraP5 = new OracleParameter("delivery", OracleDbType.Varchar2, deliveryPoint.Text, System.Data.ParameterDirection.Input);

            cmd.Parameters.Add(oraP1);
            cmd.Parameters.Add(oraP2);
            cmd.Parameters.Add(oraP3);
            cmd.Parameters.Add(oraP4);
            cmd.Parameters.Add(oraP5);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Заказ успешно обработан!", "Успех!");
            b.GetAllOrders(MainPage.UserIsAdmin);
            int id_ordD = DbClass.UsersOrders.Last().Id_order;




            cmd = new OracleCommand("InsertDelivery", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            oraP1 = new OracleParameter("id_emp", OracleDbType.Int32, emp, System.Data.ParameterDirection.Input);
            oraP2 = new OracleParameter("status", OracleDbType.Varchar2, "В процессе выполнения", System.Data.ParameterDirection.Input);
            oraP3 = new OracleParameter("id_ord", OracleDbType.Int32, id_ordD, System.Data.ParameterDirection.Input);

            cmd.Parameters.Add(oraP1);
            cmd.Parameters.Add(oraP2);
            cmd.Parameters.Add(oraP3);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Доставка успешно оформлена!");

            cmd = new OracleCommand("InsertOrdersProducts", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            foreach(BuyItem i in Cart.ItemsCart)
            {
                cmd = new OracleCommand("InsertOrdersProducts", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                oraP1 = new OracleParameter("id_emp", OracleDbType.Int32, id_ordD, System.Data.ParameterDirection.Input);
                oraP2 = new OracleParameter("id_prod", OracleDbType.Int32, i.Id_Prod, System.Data.ParameterDirection.Input);
                cmd.Parameters.Add(oraP1);
                cmd.Parameters.Add(oraP2);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Всё готово!");

            con.Clone();
        }
    }
}
