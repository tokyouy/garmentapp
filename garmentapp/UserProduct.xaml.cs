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
    }
}
