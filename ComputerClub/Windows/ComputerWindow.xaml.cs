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
    /// Логика взаимодействия для ComputerWindow.xaml
    /// </summary>
    public partial class ComputerWindow : Window
    {
        public ComputerWindow()
        {
            InitializeComponent();
            LoadComps();
        }

        private void LoadComps()
        {
            using (var context = new Context())
            {
                var items = context.Computers.ToList();
                CompGrid.ItemsSource = items;
            }
        }
    }
}
