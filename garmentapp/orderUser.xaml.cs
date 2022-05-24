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
    /// Логика взаимодействия для orderUser.xaml
    /// </summary>
    public partial class orderUser : Page
    {
        public orderUser()
        {
            InitializeComponent();
            var garment = garmentEntities.GetContext().order.Where(p => p.color.Contains(searchseason.Text)).ToList();
            dgOrders.ItemsSource = garment;
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddEditOrder addEditOrder = new AddEditOrder(null);
            addEditOrder.Show();
        }

        private void searchtype_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().order.Where(p => p.color.Contains(searchseason.Text)).ToList();
            dgOrders.ItemsSource = garment;
        }

        private void searchcolor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().order.Where(p => p.color.Contains(searchseason.Text)).ToList();
            dgOrders.ItemsSource = garment;
        }

        private void searchseason_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().order.Where(p => p.season.Contains(searchseason.Text)).ToList();
            dgOrders.ItemsSource = garment;
        }
    }
}
