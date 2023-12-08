using System;
using System.Collections.ObjectModel;
using EestiSaared.Models;

namespace EestiSaared.Views
{
    public partial class StartPage : ContentPage
    {
        private int currentIndex = 0;

        public StartPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void OnPreviousClicked(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                carouselView.Position = currentIndex;
            }
        }

        private void OnNextClicked(object sender, EventArgs e)
        {
            var imageItems = carouselView.ItemsSource as ObservableCollection<ImageItem>;

            if (imageItems != null && currentIndex < imageItems.Count - 1)
            {
                currentIndex++;
                carouselView.Position = currentIndex;
            }
        }
    }
}
