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
using System.Collections.Specialized;

namespace Furniture_Store
{
    public partial class Cart : Page
    {
        public  static ObservableCollection<BuyItem> ItemsCart = new ObservableCollection<BuyItem>();
        int _result;
        public Cart()
        {
            InitializeComponent();
            

            int result = 0;

            foreach (BuyItem i in ItemsCart)
            {
                result += i.Cost;
            }

            totalPrice.Text = "Итоговая стоимость: " + result.ToString() + "р.";
            userCart.ItemsSource = ItemsCart;
            _result = result;
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            MainPage._MainFrame.Content = new Checkout(_result);
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsCart.Count != 0 && userCart.SelectedIndex != -1)
            {
                ItemsCart.RemoveAt(userCart.SelectedIndex);
            }

            int result = 0;

            foreach (BuyItem i in ItemsCart)
            {
                result += i.Cost;
            }

            totalPrice.Text = "Итоговая стоимость: " + result.ToString() + "р.";
        }
    }
}
