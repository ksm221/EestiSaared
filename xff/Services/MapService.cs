using System;
using System.Collections.Generic;
using System.Globalization;

namespace xff.Services
{
    public class MapService
    {
        public List<string> GenerateMapHtmls(List<islandLocation> locations, string apiKey)
        {
            List<string> mapHtmls = new List<string>();

            foreach (var location in locations)
            {
                string mapHtml = $"<html><body><h2>{location.Title}</h2><iframe width='600' height='450' frameborder='6' style='border:0'" +
                                $"src='https://www.google.com/maps/embed/v1/view?key={apiKey}&center={location.Latitude.ToString(CultureInfo.InvariantCulture)},{location.Longitude.ToString(CultureInfo.InvariantCulture)}&zoom=18&maptype=satellite'" +
                                $"allowfullscreen></iframe></body></html>";

                mapHtmls.Add(mapHtml);
            }

            return mapHtmls;
        }
    }

    public class islandLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Title { get; set; }
    }
}
