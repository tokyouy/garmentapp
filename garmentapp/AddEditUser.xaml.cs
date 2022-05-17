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
    /// Логика взаимодействия для AddEditUser.xaml
    /// </summary>
    public partial class AddEditUser : Window
    {
        users _currentUser = new users();
        public AddEditUser(users selectedUsers)
        {
            InitializeComponent();
            cbRoles.ItemsSource = garmentEntities.GetContext().role.ToList();
            if (selectedUsers != null)
            {
                _currentUser = selectedUsers;
            }
            DataContext = _currentUser;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_currentUser.id == 0)
            {
                garmentEntities.GetContext().users.Add(_currentUser);
                try
                {
                    garmentEntities.GetContext().SaveChanges();
                    MessageBox.Show("Запись успешно сохранена!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка! Ошибка:{ex.Message}");
                }
            }
            else if (_currentUser.id != 0)
            {
                try
                {
                    garmentEntities.GetContext().SaveChanges();
                    MessageBox.Show("Запись успешно сохранена!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка! Ошибка:{ex.Message}");
                }
            }
        }
    }
}
