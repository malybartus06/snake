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

namespace Snake
{
    /// <summary>
    /// Logika interakcji dla klasy Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow(this).Show();
            this.Hide();
        }

        private void Snake_Click(object sender, RoutedEventArgs e)
        {
            new SnakeConfigurator(this).Show();
            this.Hide();
        }

        private void Map_Click(object sender, RoutedEventArgs e)
        {
            new MapConfigurator(this).Show();
            this.Hide();
        }
    }
}
