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
    /// Логика взаимодействия для AboutProduct.xaml
    /// </summary>
    public partial class AboutProduct : Page
    {
        int tId;
        int rat;
        DbClass b = new DbClass();
        Product tmpProd;
        public AboutProduct()
        {
            InitializeComponent();
        }

        public AboutProduct(int _id)
        {
            InitializeComponent();
            //itemTitle.Text = MainPage.productss[_id].title.ToString();
            b.GetAllProducts(true);
            foreach(Product i in DbClass.Products)
            {
                if (i.Id_product == _id)
                {
                    itemTitle.Text = i.Title;
                    itemPrice.Text = i.Price.ToString();
                    itemProvider.Text = i.Provider;
                    itemType.Text = i.Type;
                    itemRating.Text = i.Rating.ToString();
                    var imageS = new BitmapImage();
                    imageS.BeginInit();
                    imageS.StreamSource = i.Image;
                    imageS.EndInit();
                    img.Source = imageS;
                    rat = i.Rating;
                    tmpProd = i;
                }
            }
            tId = _id;
        }

        private void ButReturn_Click(object sender, RoutedEventArgs e)
        {
            MainPage._MainFrame.Content = new Catalog();
        }

        private void ButBuy_Click(object sender, RoutedEventArgs e)
        {
            Cart.ItemsCart.Add(new BuyItem(tmpProd.Title, tmpProd.Price, tmpProd.Id_product));
            MessageBox.Show("Товар добавлен в корзину!", "Успех");
        }

        private void MinusRate_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection con = new OracleConnection(DbClass.connectionAdmin);
            con.Open();
            OracleCommand cmd = new OracleCommand("UpdateRatingProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("id", OracleDbType.Int32, tId, System.Data.ParameterDirection.Input);
            OracleParameter oraP1 = new OracleParameter("rating", OracleDbType.Int32, (rat - 1), System.Data.ParameterDirection.Input);
            cmd.Parameters.Add(oraP);
            cmd.Parameters.Add(oraP1);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Рейтинг успешно изменён!", "Успех!");
            con.Clone();
            rat--;
            itemRating.Text = rat.ToString();
        }

        private void PlusRate_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection con = new OracleConnection(DbClass.connectionAdmin);
            con.Open();
            OracleCommand cmd = new OracleCommand("UpdateRatingProduct", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("id", OracleDbType.Int32, tId, System.Data.ParameterDirection.Input);
            OracleParameter oraP1 = new OracleParameter("rating", OracleDbType.Int32, (rat + 1), System.Data.ParameterDirection.Input);
            cmd.Parameters.Add(oraP);
            cmd.Parameters.Add(oraP1);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Рейтинг успешно изменён!", "Успех!");
            con.Clone();
            rat++;
            itemRating.Text = rat.ToString();
        }
    }
}
