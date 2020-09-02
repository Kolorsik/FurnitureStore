using System;
using System.Collections.Generic;
using System.Data.OracleClient;
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
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace Furniture_Store
{
    public partial class UserControlProduct : UserControl
    { 
        public string title;
        public int id;
        public int price;
        public UserControlProduct()
        {
            InitializeComponent();
        }

        public UserControlProduct(Product pr)
        {
            InitializeComponent();
            Title.Text = pr.Title;
            var imageS = new BitmapImage();
            imageS.BeginInit();
            imageS.StreamSource = pr.Image;
            imageS.EndInit();
            img.Source = imageS;
            id = pr.Id_product;
            title = pr.Title;
            price = pr.Price;
            
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            Catalog._ItemGrid.Children.Clear();
            MainPage._MainFrame.Content = new AboutProduct(id);
        }
    }
}
