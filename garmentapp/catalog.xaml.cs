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

namespace garmentapp
{
    /// <summary>
    /// Логика взаимодействия для catalog.xaml
    /// </summary>
    public partial class catalog : Page
    {
        public catalog()
        {
            InitializeComponent();
            dgProducts.ItemsSource = garmentEntities.GetContext().product.ToList();
            Manger.dgProducts = dgProducts;
            cbGendr.ItemsSource = garmentEntities.GetContext().genretb.ToList();
        }

        private void searchbrend_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().product.Where(p => p.brend.Contains(searchbrend.Text)).ToList();
            dgProducts.ItemsSource = garment;
        }

          private void searchseason_TextChanged(object sender, TextChangedEventArgs e)
      {
            var garment = garmentEntities.GetContext().product.Where(p => p.season.Contains(searchseason.Text)).ToList();
            dgProducts.ItemsSource = garment;
        }

        private void searchcolor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().product.Where(p => p.color.Contains(searchcolor.Text)).ToList();
            dgProducts.ItemsSource = garment;
        }

        private void searchtype_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void searchtype_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // var garment = garmentEntities.GetContext().product.Where(p => p.type.Contains(searchtype.Text)).ToList();
            // dgProducts.ItemsSource = garment;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().product.ToList();
            dgProducts.ItemsSource = currentItem;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().product.Where(p => p.type == 2);
            dgProducts.ItemsSource = currentItem;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().product.Where(p => p.type == 3);
            dgProducts.ItemsSource = currentItem;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().product.Where(p => p.type == 4);
            dgProducts.ItemsSource = currentItem;
        }
    }
}
