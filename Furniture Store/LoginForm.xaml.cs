using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Oracle.DataAccess.Client;

namespace Furniture_Store
{
    public partial class LoginForm : Window
    {
        bool tmpL = true;
        bool tmpP = true;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RegisterBut_Click(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text.Length > 0 && passwordBox.Password.Length > 0)
            {
                bool temp = true;
                DbClass b = new DbClass();
                b.GetLoginsAndPasswords(true);
                foreach (User i in DbClass.Users)
                {
                    if (i.Login == loginBox.Text)
                    {
                        MessageBox.Show("Такой логин уже занят. Введите другой", "Ошибка!");
                        temp = false;
                    }
                }

                if (temp)
                {
                    OracleConnection con = new OracleConnection(DbClass.connectionAdmin);
                    con.Open();
                    OracleCommand cmd = new OracleCommand("InsertUser", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter oraP = new OracleParameter("login", OracleDbType.Varchar2, loginBox.Text, System.Data.ParameterDirection.Input);
                    OracleParameter oraP1 = new OracleParameter("password", OracleDbType.Varchar2, HashPassword(passwordBox.Password), System.Data.ParameterDirection.Input);
                    cmd.Parameters.Add(oraP);
                    cmd.Parameters.Add(oraP1);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Успешная регистрация!", "Успех!");
                    con.Clone();

                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка!");
            }
        }

        private void LoginBut_Click(object sender, RoutedEventArgs e)
        {
            bool tt = true;
            DbClass b = new DbClass();
            b.GetLoginsAndPasswords(true);
            if (loginBox.Text.Length > 0 && passwordBox.Password.Length > 0)
            {
                foreach (User i in DbClass.Users)
                {
                    if (i.Login == loginBox.Text && VerifyHashedPassword(i.Password, passwordBox.Password))
                    {
                        if (i.Role == "Admin")
                        {
                            tt = false;
                            MessageBox.Show("Успешная авторизация!");
                            MainPage mainPage = new MainPage(i.Login, true);
                            mainPage.Show();
                            this.Close();
                        }
                        else
                        {
                            tt = false;
                            MessageBox.Show("Успешная авторизация!");
                            MainPage mainPage = new MainPage(i.Login, false);
                            mainPage.Show();
                            this.Close();
                        }
                    }
                }
                if (tt)
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
            else
                MessageBox.Show("Заполните все поля!");
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return ByteArraysEqual(buffer3, buffer4);
        }

        public static bool ByteArraysEqual(byte[] b1, byte[] b2)
        {
            if (b1 == b2) return true;
            if (b1 == null || b2 == null) return false;
            if (b1.Length != b2.Length) return false;
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i]) return false;
            }
            return true;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ExitBut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LoginBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tmpL)
            {
                loginBox.Text = "";
                tmpL = false;
            }
        }

        private void PasswordBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tmpP)
            {
                passwordBox.Password = "";
                tmpP = false;
            }
        }
    }
}
