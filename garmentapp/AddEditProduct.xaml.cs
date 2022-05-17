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
    /// Логика взаимодействия для AddEditProduct.xaml
    /// </summary>
    public partial class AddEditProduct : Window
    {
        product _currentProduct = new product();
        public AddEditProduct(product selecteProduct)
        {
            InitializeComponent();
            if(selecteProduct != null)
            {
                _currentProduct = selecteProduct;
            }
            DataContext = _currentProduct;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(_currentProduct.id == 0)
            {
                garmentEntities.GetContext().product.Add(_currentProduct);
            }
            try
            {
                garmentEntities.GetContext().SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
