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
    /// Логика взаимодействия для regWin.xaml
    /// </summary>
    public partial class regWin : Window
    {
        private users _currentUser = new users();
        public regWin()
        {
            InitializeComponent();
            DataContext = _currentUser;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (String.IsNullOrEmpty(tbfName.Text))
                errors.AppendLine("Введите имя");
            if (String.IsNullOrEmpty(tbsName.Text))
                errors.AppendLine("Введите фамилию");
            if (String.IsNullOrEmpty(tbLogin.Text))
                errors.AppendLine("Введите логин");
            if (String.IsNullOrEmpty(tbPassword.Text))
                errors.AppendLine("Введите пароль");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (garmentEntities.GetContext().users.Where(p => p.login == tbLogin.Text).Count() == 0)
            {
                if (_currentUser.id == 0)
                    _currentUser.roleid = 2;
                garmentEntities.GetContext().users.Add(_currentUser);

                try
                {
                    garmentEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
            }

        }
    }
}
