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
using System.Data.SqlClient;
using System.Data.Entity;

namespace garmentapp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        users validate = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ValidateUser(string login, string password)
        {

            validate = garmentEntities.GetContext().users.Where(p => p.login == login && p.password == password ).FirstOrDefault();
            if (validate != null)
            {
                Manger.validateUser = validate;
                switch (validate.roleid)
                {   
                    // adminWin
                    case 1:
                        AdminWin adminWin = new AdminWin();
                        adminWin.Show();
                        this.Hide();
                        break;
                    // UserWin
                    case 2:
                        userWin UserWin = new userWin();
                        UserWin.Show();
                        this.Hide();
                        break;
                    // FactoryWin
                    case 3:
                        facWin FactoryWin = new facWin();
                        FactoryWin.Show();
                        this.Hide();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль не верен!");
            }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string Login = tbLogin.Text;
            string Password = pbPass.Password;
            ValidateUser(Login, Password);
        }

        private void RegisterBtn_Click_1(object sender, RoutedEventArgs e)
        {
            regWin registrationWin = new regWin();
            registrationWin.Show();
        }

        
    }
}
