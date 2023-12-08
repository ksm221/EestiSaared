
using System.Collections.ObjectModel;

namespace EestiSaared.Models
{

    public class MainViewModel
    {
        public ObservableCollection<ImageItem> ImageItems { get; set; }

        public MainViewModel()
        {
            ImageItems = new ObservableCollection<ImageItem>
        {
            new ImageItem { ImagePath = "saaremaa.jpg" },
            new ImageItem { ImagePath = "hiiumaa.jpg" },
            new ImageItem { ImagePath = "kihnu.jpg" },
            new ImageItem { ImagePath = "ruhnu.jpg" },
            // Add more images as needed
        };
        }
    }

    public class ImageItem
    {
        public string ImagePath { get; set; }
    }
}