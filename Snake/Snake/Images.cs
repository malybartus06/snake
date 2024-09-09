using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        public static ImageSource Empty = LoadImage("Empty.png");
        public static ImageSource Body = LoadImage("Body.png");
        public static ImageSource Head = LoadImage("Head.png");
        public static ImageSource Food = LoadImage("Food.png");
        public static ImageSource DeadBody = LoadImage("DeadBody.png");
        public static ImageSource DeadHead = LoadImage("DeadHead.png");

        public static String activeColor = "Green";

        private static ImageSource LoadImage(string filename)
        {
            return new BitmapImage(new Uri($"Assets/{filename}", UriKind.Relative));
        }

    }
}
