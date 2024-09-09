using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Logika interakcji dla klasy MapConfigurator.xaml
    /// </summary>
    public partial class MapConfigurator : Window
    {

        private Menu menu;

        public MapConfigurator()
        {
            InitializeComponent();
        }

        public MapConfigurator(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            akt.Text = "Aktualnie: " + MapSize.cols + "x" + MapSize.rows;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(RowsTextBox.Text, out int rows) && int.TryParse(ColumnsTextBox.Text, out int columns))
            {
                MessageBox.Show($"Wybrano {rows} wierszy i {columns} kolumn.");
                MapSize.rows = rows;
                MapSize.cols = columns;
                this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Podane wartości nie są liczbami całkowitymi.");
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            menu.Show();
            e.Cancel = false;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            menu.Show();
        }

    }

}
