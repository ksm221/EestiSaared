using Microsoft.Maui.Controls;
using xff.Services;
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

            PopulateImageGallery();
        }

        private void PopulateImageGallery()
        {
            var stackLayout = new StackLayout();

            foreach (var imageUrl in _selectedImage.Images)
            {
                var image = new Image
                {
                    Source = imageUrl,
                    Aspect = Aspect.AspectFit,
                    HeightRequest = 200,
                    WidthRequest = 300,
                };

                stackLayout.Children.Add(image);
            }

            Content = stackLayout;
        }
    }
}
