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
    /// Logika interakcji dla klasy SnakeConfigurator.xaml
    /// </summary>
    public partial class SnakeConfigurator : Window
    {

        private Menu menu;

        public SnakeConfigurator()
        {
            InitializeComponent();
        }

        public SnakeConfigurator(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            Images.Head = LoadImage("Head.png");
            Images.Body = LoadImage("Body.png");
            Images.DeadHead = LoadImage("DeadHead.png");
            Images.DeadBody = LoadImage("DeadBody.png");
            this.Close();
            menu.Show();
        }                 

        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {
            Images.Head = LoadImage("yellow/Head.png");
            Images.Body = LoadImage("yellow/Body.png");
            Images.DeadHead = LoadImage("yellow/DeadHead.png");
            Images.DeadBody = LoadImage("yellow/DeadBody.png");
            this.Close();
            menu.Show();
        }

        private void PurpleButton_Click(object sender, RoutedEventArgs e)
        {
            Images.Head = LoadImage("purple/Head.png");
            Images.Body = LoadImage("purple/Body.png");
            Images.DeadHead = LoadImage("purple/DeadHead.png");
            Images.DeadBody = LoadImage("purple/DeadBody.png");
            this.Close();
            menu.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            menu.Show();
        }


        private static ImageSource LoadImage(string filename)
        {
            return new BitmapImage(new Uri($"Assets/{filename}", UriKind.Relative));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            menu.Show();
            e.Cancel = false;
        }

    }
}
