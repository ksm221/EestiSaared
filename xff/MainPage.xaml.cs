using Microsoft.Maui.Controls;
using System.Globalization;

namespace xff
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Static coordinates for testing (replace with your actual coordinates)

            double latitude = 58.1499;
            double longitude = 22.5055;
            string apiKey = "AIzaSyBz1eES6CyIBLu2KAt92nQtmDzYOa9Dsj8";

            var htmlContent = $"<html><body><iframe width='400' height='450' frameborder='0' style='border:0'" +
                              $"src='https://www.google.com/maps/embed/v1/view?key={apiKey}&center={latitude.ToString(CultureInfo.InvariantCulture)},{longitude.ToString(CultureInfo.InvariantCulture)}&zoom=18&maptype=satellite'" +
                              $"allowfullscreen></iframe></body></html>";

            // Set the HTML content in the WebView
            googleMapView.Source = new HtmlWebViewSource { Html = htmlContent };


            // Set the center parameter in the Google Maps embed URL
            //var googleMapsEmbedUrl = $"https://www.google.com/maps/embed/v1/view?key=AIzaSyBz1eES6CyIBLu2KAt92nQtmDzYOa9Dsj8&center=-33.8569,151.2152&zoom=18&maptype=satellite";
            //googleMapView.Source = new UrlWebViewSource { Url = googleMapsEmbedUrl };
        }
    }
}