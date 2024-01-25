using Microsoft.Maui.Controls;

namespace xff
{
    public partial class MainMenuPage : ContentPage
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void OnMainMenuButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Text == "Maps")
                {
                    Navigation.PushAsync(new MenuPage());
                }
                else if (button.Text == "Gallery")
                {
                    Navigation.PushAsync(new GalleryMenuPage());
                }
            }
        }
    }
}