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

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new UserProduct();
        }

        private void btnBasket_Click(object sender, RoutedEventArgs e)
        {
           // MainFrame.Content = new PageBasket();
        }

        private void btnUserSettings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SetingsProfile(Manger.validateUser);
        }

        private void btnOrderGrid_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new orderUser();
        }
    }
}
