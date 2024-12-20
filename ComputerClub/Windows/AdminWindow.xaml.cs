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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            EventAdminWindow eventsAdminWindow = new EventAdminWindow();
            Close();
            eventsAdminWindow.Show();
        }

        
        private void Games_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            GamesAdminWIndow gamesAdminWIndow = new GamesAdminWIndow();
            Close();
            gamesAdminWIndow.Show();
        }

        
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }

    }
}
