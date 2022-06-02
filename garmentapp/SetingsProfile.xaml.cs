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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace garmentapp
{
    /// <summary>
    /// Логика взаимодействия для SetingsProfile.xaml
    /// </summary>
    public partial class SetingsProfile : Page
    {
        users _currentUser = new users();
        public SetingsProfile(users selectedUser)
        {
            InitializeComponent();
            if(selectedUser != null)
            {
                _currentUser = selectedUser;
            }
            DataContext = selectedUser;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (OldPass.Text != _currentUser.password)
            {
                MessageBox.Show($"Вы ввели неверный старый пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (OldPass.Text == _currentUser.password && newPass.Text == newPass1.Text)
            {
                try
                {
                    _currentUser.password = newPass.Text;
                    garmentEntities.GetContext().SaveChanges();
                    MessageBox.Show($"Данные обнавлены успешно!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Произошла ошибка! Обратитесь к администратор!\nОшибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show($"Вы ввели неверный пароль подтверждения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
