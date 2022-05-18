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
    /// Логика взаимодействия для AddEditOrder.xaml
    /// </summary>
    public partial class AddEditOrder : Window
    {
        order _currentOrder = new order();
        public AddEditOrder(order selecteOrder)
        {
            InitializeComponent();
            if (selecteOrder != null)
            {
                _currentOrder = selecteOrder;
            }
            DataContext = _currentOrder;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _currentOrder.idUser = Manger.validateUser.id;
            if (_currentOrder.id == 0)
            {
                garmentEntities.GetContext().order.Add(_currentOrder);
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
