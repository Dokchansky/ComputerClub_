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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();

        }

        private void Comp_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            ComputerWindow computerWindow = new ComputerWindow();
            Close();
            computerWindow.Show();
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            EventsWindow eventsWindow = new EventsWindow();
            Close();
            eventsWindow.Show();
        }

   
        private void Promotion_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PromotionWindow promotionWindow = new PromotionWindow();
            Close();
            promotionWindow.Show();
        }

        private void Games_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            GamesWindow gamesWindow = new GamesWindow();
            Close();
            gamesWindow.Show();
        }

        private void Feedback_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            FeedbackWindow feedbackwindow = new FeedbackWindow();
            Close();
            feedbackwindow.Show();
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
