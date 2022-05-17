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
    /// Логика взаимодействия для facWin.xaml
    /// </summary>
    public partial class facWin : Window
    {
        public facWin()
        {
            InitializeComponent();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            // var product = garmentEntities.GetContext().product.Where(p => p.color == tbSearch.Text).ToList();
            // Manger.dgProducts.ItemsSource = product;
        }

        private void btnAppSettings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SetingsProfile();
        }

        private void btnCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new FactoryProduct();
        }
    }
}
