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

        productmen _currentnProduct = new productmen();
        public AddEditProduct(productmen selecteProduct)
        {
            InitializeComponent();
            if(selecteProduct != null)
            {
                _currentnProduct = selecteProduct;
            }
            DataContext = _currentnProduct;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(_currentnProduct.id == 0)
            {
                garmentEntities.GetContext().productmen.Add(_currentnProduct);
            }

                garmentEntities.GetContext().SaveChanges();
            
        }

    }
}
