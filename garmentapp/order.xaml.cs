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
    /// Логика взаимодействия для order.xaml
    /// </summary>
    public partial class order : Window
    {
        productmen _currentnProduct = new productmen();
        public order()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            if (_currentnProduct.id == 0)
            {
                garmentEntities.GetContext().productmen.Add(_currentnProduct);
            }
            garmentEntities.GetContext().SaveChanges();
            MessageBox.Show($"Данные обнавлены успешно!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
