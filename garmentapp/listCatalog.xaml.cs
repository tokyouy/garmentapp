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
    /// Логика взаимодействия для listCatalog.xaml
    /// </summary>
    public partial class listCatalog : Page
    {
        public listCatalog()
        {
            InitializeComponent();
        }

        private void btnManCatalog_Click(object sender, RoutedEventArgs e)
        {
            CatalogFrame.Content = new catalogMMan();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CatalogFrame.Content = new catalogWMan();
        }
    }
}
