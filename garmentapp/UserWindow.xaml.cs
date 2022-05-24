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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            dgUsers.ItemsSource = garmentEntities.GetContext().users.ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditUser addEditUser = new AddEditUser(dgUsers.SelectedItem as users);
            addEditUser.Show();
        }

        private void btnDelate_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить запись?", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var selectedItem = dgUsers.SelectedItem;
                garmentEntities.GetContext().users.Remove(selectedItem as users);
                try
                {
                    garmentEntities.GetContext().SaveChanges();
                    MessageBox.Show("Запись успешно удалена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка! Ошибка:{ex.Message}");
                }
            }
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditUser addEditUser = new AddEditUser(null);
            addEditUser.Show();
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void searchbrend_TextChanged(object sender, TextChangedEventArgs e)
        {
            var garment = garmentEntities.GetContext().users.Where(p => p.login.Contains(searchlogin.Text)).ToList();
            dgUsers.ItemsSource = garment;
        }
    }
}
