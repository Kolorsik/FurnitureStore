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

namespace Furniture_Store
{
    /// <summary>
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        DbClass b = new DbClass();
        public Account(string nameUser)
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

        private void EditAccountInfo_Click(object sender, RoutedEventArgs e)
        {
            MainPage._MainFrame.Content = new EditAccount(MainPage.Username);
        }
    }
}
