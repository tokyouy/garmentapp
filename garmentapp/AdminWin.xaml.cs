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
    /// Логика взаимодействия для AdminWin.xaml
    /// </summary>
    public partial class AdminWin : Window
    {
        public AdminWin()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            AdminUser usersWindow = new AdminUser();
            usersWindow.Show();
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow authWindow = new MainWindow();
            authWindow.Show();
            this.Hide();
        }

        private void btnWCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AdminProductW();
        }

        private void btnMCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AdminProduct();
        }
    }
}
