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
    /// Логика взаимодействия для AddEditProductW.xaml
    /// </summary>
    public partial class AddEditProductW : Window
    {
        productwmen _currentnProduct = new productwmen();
        public AddEditProductW(productwmen selecteProduct)
        {
            InitializeComponent();
            if (selecteProduct != null)
            {
                _currentnProduct = selecteProduct;
            }
            DataContext = _currentnProduct;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_currentnProduct.id == 0)
            {
                garmentEntities.GetContext().productwmen.Add(_currentnProduct);
            }
            garmentEntities.GetContext().SaveChanges();
            MessageBox.Show($"Данные обнавлены успешно!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
