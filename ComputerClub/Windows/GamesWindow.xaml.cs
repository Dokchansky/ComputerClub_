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
    /// Логика взаимодействия для GamesWindow.xaml
    /// </summary>
    public partial class GamesWindow : Window
    {
        public GamesWindow()
        {
            InitializeComponent();
            LoadGames();
        }

        private void LoadGames()
        {
            using(var context = new Context())
            {
                var items = context.Games.ToList();
                GamesGrid.ItemsSource = items;
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            UserWindow userWindow = new UserWindow();
            Close();
            userWindow.Show();
        }
    }
}
