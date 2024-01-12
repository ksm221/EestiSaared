using Microsoft.Maui.Controls;
using xff.Services;
using System.Collections.Generic;
using Microsoft.Maui.Devices.Sensors;

namespace xff
{
    public partial class MainPage : ContentPage
    {
        private readonly MapService _mapService;

        public MainPage()
        {
            InitializeComponent();

            _mapService = new MapService();

            // Example: Multiple islandLocations
            var islandLocations = new List<islandLocation>
            {
                new islandLocation { Latitude = 59.3358, Longitude = 23.9824, Title = "Väike Pakri" },
                new islandLocation { Latitude = 59.3228, Longitude = 23.9240, Title = "Suur Pakri" },
                new islandLocation { Latitude = 59.6254, Longitude = 25.0106, Title = "Prangli" },
                new islandLocation { Latitude = 59.5840, Longitude = 24.7585, Title = "Aegna" },
                new islandLocation { Latitude = 58.5386, Longitude = 23.4381, Title = "Viirelaid" },
                new islandLocation { Latitude = 58.2019, Longitude = 26.0578, Title = "Tondisaar" },
                new islandLocation { Latitude = 58.2160, Longitude = 24.1247, Title = "Manilaid" }
                // Add more islandLocations as needed
            };

            var stackLayout = (StackLayout)Content.FindByName("StackLayout");

            // Generate HTML content for each location using the MapService
            foreach (var location in islandLocations)
            {
                var mapHtml = _mapService.GenerateMapHtmls(new List<islandLocation> { location }, "AIzaSyBz1eES6CyIBLu2KAt92nQtmDzYOa9Dsj8")[0];

                var titleLabel = new Label
                {
                    Text = location.Title,
                    FontSize = 20,
                    HorizontalOptions = LayoutOptions.Center
                };

                var webView = new WebView
                {
                    Source = new HtmlWebViewSource { Html = mapHtml },
                    HeightRequest = 450,
                    WidthRequest = 600,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                };

                stackLayout.Children.Add(titleLabel);
                stackLayout.Children.Add(webView);
            }
        }
    }
}