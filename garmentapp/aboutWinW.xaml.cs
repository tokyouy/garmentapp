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
    /// Логика взаимодействия для aboutWinW.xaml
    /// </summary>
    public partial class aboutWinW : Window
    {
        productwmen _currentnProduct = new productwmen();
        public aboutWinW(productwmen selecteProduct)
        {
            InitializeComponent();
            if (selecteProduct != null)
            {
                _currentnProduct = selecteProduct;
            }
            DataContext = _currentnProduct;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
