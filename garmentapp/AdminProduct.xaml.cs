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
    /// Логика взаимодействия для AdminProduct.xaml
    /// </summary>
    public partial class AdminProduct : Page
    {
        public AdminProduct()
        {
            InitializeComponent();
            dgMenProducts.ItemsSource = garmentEntities.GetContext().productmen.ToList();
        }

        private void btnDelate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить запись?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var selectedItem = dgMenProducts.SelectedItem;
                garmentEntities.GetContext().productmen.Remove(selectedItem as productmen);
                try
                {
                    garmentEntities.GetContext().SaveChanges();
                    MessageBox.Show("Запись успешно удалена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка! Ошибка:{ex.Message}");
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct(dgMenProducts.SelectedItem as productmen);
            addEditProduct.Show();
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

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct(null);
            addEditProduct.Show();
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

        private void btnEdit_Click_1(object sender, RoutedEventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct(dgMenProducts.SelectedItem as productmen);
            addEditProduct.Show();
        }
    }
}
