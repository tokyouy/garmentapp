﻿using System;
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
            dgProducts.ItemsSource = garmentEntities.GetContext().product.ToList();

           /* switch (Manger.validateUser.roleid)
            {
                case 1:
                    {
                        btnAdd.Visibility = Visibility.Visible;
                    }
                    break;
                case 3:
                    {
                        btnAdd.Visibility = Visibility.Visible;
                    }
                    break;
            }
           */
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct(dgProducts.SelectedItem as product);
            addEditProduct.Show();
        }

        private void btnDelate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить запись?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var selectedItem = dgProducts.SelectedItem;
                garmentEntities.GetContext().product.Remove(selectedItem as product);
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
            AddEditProduct addEditProduct = new AddEditProduct(dgProducts.SelectedItem as product);
            addEditProduct.Show();
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
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

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct(null);
            addEditProduct.Show();
        }

    }
}
