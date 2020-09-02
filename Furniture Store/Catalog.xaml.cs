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
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {

        public static Grid _ItemGrid;
        int currentPage = 1;
        int pages;

        public Catalog()
        {
            InitializeComponent();
            _ItemGrid = ItemGrid;
            MainPage.rowsNum = ItemGrid.RowDefinitions.Count;
            MainPage.columnsNum = ItemGrid.ColumnDefinitions.Count;
            int countProd = MainPage.productss.Count;
            if ((countProd % 9) == 0)
            {
                pages = countProd / 9;
            }
            else
            {
                pages = (countProd / 9) +1;
            }
            Pages.Text = currentPage.ToString() + "/" + pages.ToString();
            prevPage.IsEnabled = false;
            ItemGrid.Children.Clear();
            MainPage.tempInd = 0;
            RefreshItems();
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            currentPage++;
            RefreshItems();
        }

        private void PrevPage_Click(object sender, RoutedEventArgs e)
        {
            currentPage--;
            MainPage.tempInd -= 9 + ItemGrid.Children.Count;
            RefreshItems();
        }

        private void RefreshItems()
        {
            Catalog._ItemGrid.Children.Clear();
            for (int i = 0; i < MainPage.rowsNum; i++)
            {
                for (int j = 0; j < MainPage.columnsNum; j++)
                {
                    if (MainPage.tempInd < MainPage.productss.Count)
                    {
                        UserControlProduct tmp = MainPage.productss[MainPage.tempInd];
                        Grid.SetColumn(tmp, j);
                        Grid.SetRow(tmp, i);
                        Catalog._ItemGrid.Children.Add(tmp);
                        MainPage.tempInd++;
                    }
                }
            }
            Pages.Text = currentPage.ToString() + "/" + pages.ToString();

            if (currentPage == 1)
            {
                prevPage.IsEnabled = false;
            }
            else if (currentPage == pages)
            {
                nextPage.IsEnabled = false;
            }
            else
            {
                prevPage.IsEnabled = true;
                nextPage.IsEnabled = true;
            }
        }
    }
}
