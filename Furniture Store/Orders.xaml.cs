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
using System.Collections.ObjectModel;

namespace Furniture_Store
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {
        DbClass b = new DbClass();
        public static ObservableCollection<Order> UsersOrderstmp = new ObservableCollection<Order>();
        public Orders()
        {
            InitializeComponent();
            UsersOrderstmp.Clear();
            b.GetAllOrders(MainPage.UserIsAdmin);
            foreach (Order i in DbClass.UsersOrders)
            {
                if (i.UserLogin == MainPage.Username)
                {
                    UsersOrderstmp.Add(i);
                }
            }
            orderList.ItemsSource = UsersOrderstmp;
        }

        private void OrderDetailsBut_Click(object sender, RoutedEventArgs e)
        {
            if (orderList.SelectedItem != null)
            {
                Order temp = (Order)orderList.SelectedItem;
                MainPage._MainFrame.Content = new OrdersDetails(temp.Id_order);
            }
            else
            {
                MessageBox.Show("Выберите заказ!");
            }
        }
    }
}