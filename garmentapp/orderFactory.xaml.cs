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
    /// Логика взаимодействия для orderFactory.xaml
    /// </summary>
    public partial class orderFactory : Page
    {
        public orderFactory()
        {
            InitializeComponent();
            dgOrders.ItemsSource = garmentEntities.GetContext().order.ToList();
            Manger.dgOrders = dgOrders;
        }

        private void searchseason_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().order.Where(p => p.season.Contains(searchseason.Text)).ToList();
            dgOrders.ItemsSource = garment;
        }

        private void searchcolor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().order.Where(p => p.color.Contains(searchseason.Text)).ToList();
            dgOrders.ItemsSource = garment;
        }

        private void searchtype_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().order.Where(p => p.type.Contains(searchseason.Text)).ToList();
            dgOrders.ItemsSource = garment;
        }
    }
}
