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
    /// Логика взаимодействия для AdminProductW.xaml
    /// </summary>
    public partial class AdminProductW : Page
    {
        public AdminProductW()
        {
            InitializeComponent();
            dgWMenProducts.ItemsSource = garmentEntities.GetContext().productwmen.ToList();
            Manger.dbWMenProducts = dgWMenProducts;
        }

        private void searchbrend_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().productwmen.Where(p => p.brend.Contains(searchbrend.Text)).ToList();
            dgWMenProducts.ItemsSource = garment;
        }

        private void searchseason_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().productwmen.Where(p => p.brend.Contains(searchbrend.Text)).ToList();
            dgWMenProducts.ItemsSource = garment;
        }

        private void searchcolor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().productwmen.Where(p => p.color.Contains(searchcolor.Text)).ToList();
            dgWMenProducts.ItemsSource = garment;
        }

        private void typeAll_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().productwmen.ToList();
            dgWMenProducts.ItemsSource = currentItem;
        }

        private void typeCorp_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().productwmen.Where(p => p.type == "Корпоративная одежда").ToList();
            dgWMenProducts.ItemsSource = currentItem;
        }

        private void typeDayZ_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().productwmen.Where(p => p.type == "Повседневная одежда").ToList();
            dgWMenProducts.ItemsSource = currentItem;
        }

        private void typeUni_Click(object sender, RoutedEventArgs e)
        {
            var currentItem = garmentEntities.GetContext().productwmen.Where(p => p.type == "Униформа одежда").ToList();
            dgWMenProducts.ItemsSource = currentItem;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditProductW addEditProductw = new AddEditProductW(null);
            addEditProductw.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditProductW addEditProduct = new AddEditProductW(dgWMenProducts.SelectedItem as productwmen);
            addEditProduct.Show();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            aboutWinW AboutWin = new aboutWinW(dgWMenProducts.SelectedItem as productwmen);
            AboutWin.Show();
        }
    }
}
