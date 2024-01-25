using Microsoft.Maui.Controls;
using xff.Services;

namespace xff
{
    public partial class MenuPage : ContentPage
    {
        private readonly IslandLocationService _islandLocationService;

        public MenuPage()
        {
            InitializeComponent();
            _islandLocationService = new IslandLocationService();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string buttonText = button.Text;
                var selectedLocation = _islandLocationService.GetIslandLocations().Find(loc => loc.Title == buttonText);

                if (selectedLocation != null)
                {
                    await Navigation.PushAsync(new MapsPage(selectedLocation));
                }
            }
        }
    }
}
