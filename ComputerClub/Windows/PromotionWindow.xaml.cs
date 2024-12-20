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
    /// Логика взаимодействия для PromotionWindow.xaml
    /// </summary>
    public partial class PromotionWindow : Window
    {
        public PromotionWindow()
        {
            InitializeComponent();
            LoadPromotion();
        }

        public void LoadPromotion()
        {
            using(var context = new Context()) 
            {
                var items = context.Promotions.ToList();
                PromotionGrid.ItemsSource = items;

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
