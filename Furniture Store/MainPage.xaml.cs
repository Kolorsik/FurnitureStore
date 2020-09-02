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
using System.Windows.Shapes;

namespace Furniture_Store
{
    public partial class MainPage : Window
    {
        public static List<UserControlProduct> productss;
        public static int tempInd = 0;
        public static int rowsNum;
        public static int columnsNum;
        public static Frame _MainFrame;
        DbClass b = new DbClass();
        public static string Username;
        public static bool UserIsAdmin;

        public MainPage(string userLogin, bool isadm)
        {
            Username = userLogin;
            UserIsAdmin = isadm;
            InitializeComponent();
            _MainFrame = MainFrame;
            if (UserIsAdmin)
                adminPanel.Visibility = Visibility.Visible;
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            b.GetAllProducts(UserIsAdmin);
            int index = ListViewMenu.SelectedIndex;
            productss = new List<UserControlProduct>();

            foreach(Product i in DbClass.Products)
            {
                productss.Add(new UserControlProduct(i));
            }
            MoveCursorMenu(index);


            switch(index)
            {
                case 0:

                    MainFrame.Content = new Catalog();
                    tempInd = 0;
                    Catalog._ItemGrid.Children.Clear();

                    for (int i = 0; i < rowsNum; i++)
                    {
                        for (int j = 0; j < columnsNum; j++)
                        {
                            if (tempInd < productss.Count)
                            {
                                UserControlProduct tmp = productss[tempInd];
                                Grid.SetColumn(tmp, j);
                                Grid.SetRow(tmp, i);
                                Catalog._ItemGrid.Children.Add(tmp);
                                tempInd++;
                            }
                        }
                    }

                    break;
                case 1:
                    MainFrame.Content = new Orders();
                    break;
                case 2:
                    MainFrame.Content = new Account(Username);
                    break;
                case 3: //about
                    MainFrame.Content = new AboutProgram();
                    break;

                case 4: //adminpanel
                    MainFrame.Content = new AdminPanel();
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            TransitioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }

        private void Cart_Click(object sender, RoutedEventArgs e)
        {
            ListViewMenu.UnselectAll();
            MoveCursorMenu(0);
            MainFrame.Content = new Cart();
        }
    }
}