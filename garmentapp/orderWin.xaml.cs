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
    /// Логика взаимодействия для orderWin.xaml
    /// </summary>
    public partial class orderWin : Page
    {
        public orderWin()
        {
            InitializeComponent();
            dgOrders.ItemsSource = garmentEntities.GetContext().order.ToList();
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddEditOrder addEditOrder = new AddEditOrder(dgOrders.SelectedItem as order);
            addEditOrder.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditProduct addEditProduct = new AddEditProduct(null);
            addEditProduct.Show();
        }

        private void btnDelate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить запись?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var selectedItem = dgOrders.SelectedItem;
                garmentEntities.GetContext().order.Remove(selectedItem as order);
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
    }
}
