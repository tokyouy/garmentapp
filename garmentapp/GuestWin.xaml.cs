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
            MainFrame.Content = new catalog();
        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
