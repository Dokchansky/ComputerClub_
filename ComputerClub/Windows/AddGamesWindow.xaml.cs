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
    /// Логика взаимодействия для AddGamesWindow.xaml
    /// </summary>
    public partial class AddGamesWindow : Window
    {
        private readonly Context _context;
        public AddGamesWindow()
        {
            InitializeComponent();
            _context = new Context();
        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(game_name.Text) || 
                string.IsNullOrEmpty(game_genre.Text) ||
                string.IsNullOrEmpty(game_year.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            var games = new Games
            {
                ReleaseYear = Convert.ToInt32(game_year.Text),
                Title = game_name.Text,
                Genre = game_genre.Text,

            };

            _context.Games.Add(games);
            _context.SaveChanges();
            MessageBox.Show("Игра успешно добавлена!");

            game_name.Clear();
            game_genre.Clear();
            game_year.Clear();

            Hide();
            GamesAdminWIndow gamesAdminWIndow = new GamesAdminWIndow();
            Close();
            gamesAdminWIndow.Show();

        }
    }
}
