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
                string buttonText = button.Text;
                var selectedImage = _islandImageService.GetIslandImages().Find(img => img.Title == buttonText);

                if (selectedImage != null)
                {
                    await Navigation.PushAsync(new ImageGalleryPage(selectedImage));
                }
            }
        }
    }
}
