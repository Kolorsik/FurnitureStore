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
    /// Логика взаимодействия для UserControlHome.xaml
    /// </summary>
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();
        }

        public UserControlHome(string title, string price, string type, string des)
        {
            InitializeComponent();
            Title.Text = title;
            Price.Text = price;
            Type.Text = type;
            Des.Text = des;
        }
    }
}
