
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
            new ImageItem { ImagePath = "https://static.visitestonia.com/images/3937425/600_400_false_false_a9598470cb044bb493f0e91b0bc423eb.jpg" },
            new ImageItem { ImagePath = "https://www.ruhnuring.ee/wp-content/uploads/2020/12/kirikud-1024x576.jpg" },
            // Add more images as needed
        };
        }
    }

    public class ImageItem
    {
        public string ImagePath { get; set; }
    }
}