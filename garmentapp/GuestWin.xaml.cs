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
    /// Логика взаимодействия для GuestWin.xaml
    /// </summary>
    public partial class GuestWin : Window
    {
        public GuestWin()
        {
            InitializeComponent();
        }

        private void btnUserRegistration_Click(object sender, RoutedEventArgs e)
        {
            regWin regiWin = new regWin();
            regiWin.Show();
        }

        private void btnuserLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Hide();
        }

        private void btnMCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new catalogMMan();
        }

        private void btnWCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new catalogWMan();
        }
    }
}
