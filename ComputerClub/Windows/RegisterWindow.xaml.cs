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

namespace ComputerClub.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }

        private void registerbutton_Click(object sender,  RoutedEventArgs e)
        {
            
            string name = user_surname.Text;
            int age = Convert.ToInt32(ageBox.Text);
            DateTime date = DateRegistration.DisplayDate;
            string login = loginbox.Text;
            string password = passwordbox.Password;

            
            if(string.IsNullOrEmpty(name)
               || string.IsNullOrEmpty(login)
               || string.IsNullOrEmpty(password))

            {
                MessageBox.Show("Заполните все поля ввода!");
                return;
            }

            using(var context = new Context())
            {
                var members = new Members();
                {
                    members.Name = name;
                    members.Age = age;
                    members.JoinDate = date;
                    members.login = login;
                    members.password = password;

                }
                if(context.Members.Any(u => u.login == login))
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                    return;
                }

                context.Members.Add(members);
                context.SaveChanges();

                MessageBox.Show("Регистрация прошла успешно!");
                Hide();
                MainWindow mainWindow = new MainWindow();
                Close();
                mainWindow.Show();
            }


        }
    }
}
