using System;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace TechEdDemo.Models
{
    public class Icecream
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public ImageSource Image { get; set; }

        public void SetImage(Uri baseUri, String path)
        {
            Image = new BitmapImage(new Uri(baseUri, path));
        }
    }
}
