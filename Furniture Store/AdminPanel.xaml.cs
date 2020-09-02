using Microsoft.Win32;
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
using System.IO;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Furniture_Store
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Page
    {
        byte[] imageBt = null;
        DbClass b = new DbClass();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void UploadImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Выбрать фаил";
            openFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            filePath.Text = openFileDialog1.FileName;
            if (filePath.Text.Length > 0)
            {
                FileStream fstream = new FileStream(filePath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);
            }
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            b.GetAllProviders(true);
            bool tmp = true;
            foreach(Provider i in DbClass.Providers)
            {
                if (i.NameProvider == prodProvider.Text)
                {
                    OracleConnection con = new OracleConnection(DbClass.connectionAdmin);
                    con.Open();
                    OracleCommand cmd = new OracleCommand("InsertProduct", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter oraP = new OracleParameter("title", OracleDbType.Varchar2, prodTitle.Text, System.Data.ParameterDirection.Input);
                    OracleParameter oraP1 = new OracleParameter("price", OracleDbType.Int32, Convert.ToInt32(prodPrice.Text), System.Data.ParameterDirection.Input);
                    OracleParameter oraP2 = new OracleParameter("provider", OracleDbType.Varchar2, prodProvider.Text, System.Data.ParameterDirection.Input);
                    OracleParameter oraP3 = new OracleParameter("type", OracleDbType.Varchar2, prodType.Text, System.Data.ParameterDirection.Input);
                    OracleParameter oraP4 = new OracleParameter("rating", OracleDbType.Int32, Convert.ToInt32(prodRating.Text), System.Data.ParameterDirection.Input);
                    OracleParameter oraP5 = new OracleParameter("img", OracleDbType.Blob, imageBt, System.Data.ParameterDirection.Input);

                    cmd.Parameters.Add(oraP);
                    cmd.Parameters.Add(oraP1);
                    cmd.Parameters.Add(oraP2);
                    cmd.Parameters.Add(oraP3);
                    cmd.Parameters.Add(oraP4);
                    cmd.Parameters.Add(oraP5);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Товар успешно добавлен!", "Успех!");
                    con.Clone();
                    tmp = false;
                }
            }

            if (tmp)
                MessageBox.Show("Введите корректного поставщика!", "Ошибка");
        }

        private void ToXml_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection con = new OracleConnection(DbClass.connectionAdmin);
            con.Open();
            OracleCommand cmd = new OracleCommand("ITEMS_TO_XML", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("filename", OracleDbType.Varchar2, "xmlfile.xml", System.Data.ParameterDirection.Input);
            cmd.Parameters.Add(oraP);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ItemsToXml!", "Успех!");

        }

        private void FromXml_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection con = new OracleConnection(DbClass.connectionAdmin);
            con.Open();
            OracleCommand cmd = new OracleCommand("XML_TO_ITEMS", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("filename", OracleDbType.Varchar2, "xmlfile.xml",
                                                        System.Data.ParameterDirection.Input);
            cmd.Parameters.Add(oraP);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("XmlToItems!", "Успех!");
        }
    }
}
