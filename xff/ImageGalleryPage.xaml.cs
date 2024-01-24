using Microsoft.Maui.Controls;
using xff.Services;
using Microsoft.Maui.Graphics;
using System;

namespace xff
{
    public partial class ImageGalleryPage : ContentPage
    {
        private readonly IslandImage _selectedImage;

        public ImageGalleryPage(IslandImage selectedImage)
        {
            InitializeComponent();

            _selectedImage = selectedImage;

            var stackLayout = new StackLayout
            {
                Spacing = 20,
                BackgroundColor = Colors.LightBlue
            };

            var scrollView = new ScrollView
            {
                Content = stackLayout
            };

            Content = scrollView;

            PopulateImageGallery(stackLayout);
        }

        private void PopulateImageGallery(StackLayout stackLayout)
        {
            foreach (var imageUrl in _selectedImage.Images)
            {
                var image = new Image
                {
                    Source = imageUrl,
                    Aspect = Aspect.AspectFill,
                    HeightRequest = 500,
                    WidthRequest = 700,
                    Margin = new Thickness(0, 0, 0, 0)
                };

                stackLayout.Children.Add(image);
            }
        }
    }
}
