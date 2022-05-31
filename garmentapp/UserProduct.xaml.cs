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
    /// Логика взаимодействия для UserProduct.xaml
    /// </summary>
    public partial class UserProduct : Page
    {
        public UserProduct()
        {
            InitializeComponent();
            dgProducts.ItemsSource = garmentEntities.GetContext().product.ToList();
            Manger.dgProducts = dgProducts;
        }

        private void dgProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
            // var garment = garmentEntities.GetContext().product.Where(p => p.type.Contains(searchtype.Text)).ToList();
            // dgProducts.ItemsSource = garment;
        }
    }
}
