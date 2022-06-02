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
    /// Логика взаимодействия для userWin.xaml
    /// </summary>
    public partial class userWin : Window
    {
        public userWin()
        {
            InitializeComponent();

        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SetingsProfile setwin = new SetingsProfile(Manger.validateUser);
            setwin.Show();
        }

        private void btnCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SetingsProfile(Manger.validateUser);
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
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

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            order orderWin = new order();
            orderWin.Show();
            this.Hide();
        }
    }
}
