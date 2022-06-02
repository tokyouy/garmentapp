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

namespace garmentapp
{
    /// <summary>
    /// Логика взаимодействия для catalogMMan.xaml
    /// </summary>
    public partial class catalogMMan : Page
    {
        public catalogMMan()
        {
            InitializeComponent();
            dgMenProducts.ItemsSource = garmentEntities.GetContext().productmen.ToList();
            Manger.dbMenProducts = dgMenProducts;
        }

        private void typeAll_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().productmen.ToList();
            dgMenProducts.ItemsSource = currentItem;
        }

        private void typeCorp_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().productmen.Where(p => p.type == "Корпоративная одежда").ToList();
            dgMenProducts.ItemsSource = currentItem;
        }

        private void typeDayZ_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().productmen.Where(p => p.type == "Повседневная одежда").ToList();
            dgMenProducts.ItemsSource = currentItem;
        }

        private void typeUni_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().productmen.Where(p => p.type == "Униформа").ToList();
            dgMenProducts.ItemsSource = currentItem;
        }

        private void searchbrend_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().productmen.Where(p => p.brend.Contains(searchbrend.Text)).ToList();
            dgMenProducts.ItemsSource = garment;
        }

        private void searchseason_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().productmen.Where(p => p.season.Contains(searchseason.Text)).ToList();
            dgMenProducts.ItemsSource = garment;
        }

        private void searchcolor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().productmen.Where(p => p.color.Contains(searchcolor.Text)).ToList();
            dgMenProducts.ItemsSource = garment;
        }
    }
}
