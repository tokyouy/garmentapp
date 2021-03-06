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

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow authWindow = new MainWindow();
            authWindow.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SetingsProfile setwin = new SetingsProfile(Manger.validateUser);
            setwin.Show();
        }

        private void btnMCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AdminProduct();
        }

        private void btnWCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AdminProductW();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            orderList orderwin = new orderList();
            orderwin.Show();
        }
    }
}
