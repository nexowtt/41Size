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

namespace Iskhakova41
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            var currenntProduct = Iskhakova41Entities.GetContext().Product.ToList();
            ProductListView.ItemsSource = currenntProduct;
            UpdateProducts();

        }
        private void UpdateProducts()
        {
            var currentProducts = Iskhakova41Entities.GetContext().Product.ToList();
            if (FiltrSkidka.SelectedIndex == 0)
            {
                currentProducts = currentProducts.Where(p => (Convert.ToDouble(p.ProductDiscountAmount) >= 0 && Convert.ToDouble(p.ProductDiscountAmount) <= 100)).ToList();
            }
            if (FiltrSkidka.SelectedIndex == 1)
            {
                currentProducts = currentProducts.Where(p => (Convert.ToDouble(p.ProductDiscountAmount) >= 0 && Convert.ToDouble(p.ProductDiscountAmount) < 10)).ToList();
            }
            if (FiltrSkidka.SelectedIndex == 2)
            {
                currentProducts = currentProducts.Where(p => (Convert.ToDouble(p.ProductDiscountAmount) >= 10 && Convert.ToDouble(p.ProductDiscountAmount) < 15)).ToList();
            }
            if (FiltrSkidka.SelectedIndex == 3)
            {
                currentProducts  = currentProducts.Where(p => (Convert.ToDouble(p.ProductDiscountAmount) >= 15)).ToList();
            }

            currentProducts = currentProducts.Where(p => p.ProductName.ToLower().Contains(PoiskPoNaim.Text.ToLower())).ToList();
            ProductListView.ItemsSource = currentProducts.ToList();
            if (Ubiv.IsChecked.Value)
            {
                ProductListView.ItemsSource = currentProducts.OrderByDescending(p => p.ProductCost).ToList();
            }
            if (Vozrast.IsChecked.Value)
            {
                ProductListView.ItemsSource = currentProducts.OrderBy(p => p.ProductCost).ToList();
            }
            Count.Text = "количество " + currentProducts.Count.ToString() + " из " + Iskhakova41Entities.GetContext().Product.ToList().Count.ToString();
        }
        private void FiltrSkidka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProducts();
        }

        private void Ubiv_Checked(object sender, RoutedEventArgs e)
        {
            UpdateProducts();

        }

        private void Vozrast_Checked(object sender, RoutedEventArgs e)
        {
            UpdateProducts();

        }

        private void PoiskPoNaim_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateProducts();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }
    }
}
