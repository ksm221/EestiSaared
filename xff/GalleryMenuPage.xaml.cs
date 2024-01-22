using Microsoft.Maui.Controls;
using xff.Services;
using System;

namespace xff
{
    public partial class GalleryMenuPage : ContentPage
    {
        private readonly IslandImageService _islandImageService;

        public GalleryMenuPage()
        {
            InitializeComponent();
            _islandImageService = new IslandImageService();
        }

        private async void OnGalleryButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Get the selected islandImage based on the button's text
                string buttonText = button.Text;
                var selectedImage = _islandImageService.GetIslandImages().Find(img => img.Title == buttonText);

                if (selectedImage != null)
                {
                    // Navigate to ImageGalleryPage and pass the selected image
                    await Navigation.PushAsync(new ImageGalleryPage(selectedImage));
                }
            }
        }
    }
}
