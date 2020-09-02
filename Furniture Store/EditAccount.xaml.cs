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
    public partial class EditAccount : Page
    {
        DbClass b = new DbClass();
        public EditAccount(string nameUser)
        {
            InitializeComponent();
            b.GetAllUsers(MainPage.UserIsAdmin);
            foreach(User i in DbClass.Users)
            {
                if (i.Login == nameUser)
                {
                    Login.Text = i.Login;
                    Email.Text = i.Email;
                    fullName.Text = i.FullName;
                    Address.Text = i.Address;
                    Telephone.Text = i.Telephone;
                }
            }
        }

        private void SaveAccountInfo_Click(object sender, RoutedEventArgs e)
        {
            OracleConnection con = new OracleConnection(b.CheckUser(MainPage.UserIsAdmin));
            con.Open();
            OracleCommand cmd = new OracleCommand("UpdateUser", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            OracleParameter oraP = new OracleParameter("login", OracleDbType.Varchar2, Login.Text, System.Data.ParameterDirection.Input);
            OracleParameter oraP1 = new OracleParameter("email", OracleDbType.Varchar2, Email.Text, System.Data.ParameterDirection.Input);
            OracleParameter oraP2 = new OracleParameter("name", OracleDbType.Varchar2, fullName.Text, System.Data.ParameterDirection.Input);
            OracleParameter oraP3 = new OracleParameter("address", OracleDbType.Varchar2, Address.Text, System.Data.ParameterDirection.Input);
            OracleParameter oraP4 = new OracleParameter("telephone", OracleDbType.Varchar2, Telephone.Text, System.Data.ParameterDirection.Input);

            cmd.Parameters.Add(oraP);
            cmd.Parameters.Add(oraP1);
            cmd.Parameters.Add(oraP2);
            cmd.Parameters.Add(oraP3);
            cmd.Parameters.Add(oraP4);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Данные успешно обновлены!", "Успех!");
            con.Clone();
            MainPage._MainFrame.Content = new Account(MainPage.Username);
        }
    }
}
