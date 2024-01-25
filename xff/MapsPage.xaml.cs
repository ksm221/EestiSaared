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


            var stackLayout = new StackLayout
            {
                Spacing = 10
            };

            var mapHtml = _mapService.GenerateMapHtmls(new List<islandLocation> { _selectedIsland }, "AIzaSyCCt2s_LK-28_oriLpyJrKnMfzX99amuYI")[0];

            var titleLabel = new Label
            {
                Text = _selectedIsland.Title,
                TextColor = Colors.Black,
                FontSize = 40,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            var webView = new WebView
            {
                Source = new HtmlWebViewSource { Html = mapHtml },
                HeightRequest = 500,
                WidthRequest = 700,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            stackLayout.Children.Add(titleLabel);
            stackLayout.Children.Add(webView);

            Content = stackLayout;


        }
    }
}
