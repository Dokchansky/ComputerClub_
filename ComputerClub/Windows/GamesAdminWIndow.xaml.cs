using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для GamesAdminWIndow.xaml
    /// </summary>
    public partial class GamesAdminWIndow : Window
    {
        private Context _context;
        private List<Games> _allGames;
        public GamesAdminWIndow()
        {
            InitializeComponent();
            LoadGames();
            _context = new Context();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var item = _context.Games.ToList();
            string searchgame = findBox.Text.ToLower();
            var filteredGames = item.Where(game => game.Title.ToLower().Contains(searchgame)).ToList();
            GamesGrid.ItemsSource = filteredGames;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            AddGamesWindow addGamesWindow = new AddGamesWindow();
            Close();
            addGamesWindow.Show();
        }

        

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedGames = GamesGrid.SelectedItem as Games;

            if(selectedGames != null)
            {
                var gamesToDelete = _context.Games.FirstOrDefault(n => n.Title == selectedGames.Title);

                if(gamesToDelete != null)
                {
                    _context.Games.Remove(gamesToDelete);
                    MessageBox.Show("Игра удалена!");
                    _context.SaveChanges();
                    LoadGames();
                }
                else
                {
                    MessageBox.Show("Выбранная игра не найдена в базе данных!");
                }

            }
            else
            {
                MessageBox.Show("Выберите игру для удаления");
            }
            


        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            AdminWindow adminWindow = new AdminWindow();
            Close();
            adminWindow.Show();
        }

        public void LoadGames()
        {
            using (var context = new Context())
            {
                var item = context.Games.ToList();
                GamesGrid.ItemsSource = item;
            }
        }
    }
}
