using Microsoft.Maui.Controls;
using xff.Services;
using System.Collections.Generic;

namespace xff
{
    public partial class MapsPage : ContentPage
    {
        private readonly MapService _mapService;
        private readonly IslandLocationService _islandLocationService;
        private readonly islandLocation _selectedIsland;

        public MapsPage(islandLocation selectedIsland)
        {
            InitializeComponent();

            _mapService = new MapService();
            _islandLocationService = new IslandLocationService();
            _selectedIsland = selectedIsland;

            var stackLayout = (StackLayout)Content.FindByName("StackLayout");

            var mapHtml = _mapService.GenerateMapHtmls(new List<islandLocation> { _selectedIsland }, "AIzaSyCul7gCzLmFH_NjS9_f6gsG4SULb_Y_Gnw")[0];

            var titleLabel = new Label
            {
                Text = _selectedIsland.Title,
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
