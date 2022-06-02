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
            CatalogFrame.Content = new SetingsProfile(Manger.validateUser);
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
    }
}
