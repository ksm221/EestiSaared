using System.Collections.Generic;

namespace xff.Services
{
    public class IslandLocationService
    {
        public List<islandLocation> GetIslandLocations()
        {
            return new List<islandLocation>
            {
                new islandLocation { Latitude = 59.3358, Longitude = 23.9824, Title = "Väike-Pakri" },
                new islandLocation { Latitude = 59.3228, Longitude = 23.9240, Title = "Suur-Pakri" },
                new islandLocation { Latitude = 59.6254, Longitude = 25.0106, Title = "Prangli" },
                new islandLocation { Latitude = 59.5840, Longitude = 24.7585, Title = "Aegna" },
                new islandLocation { Latitude = 58.5386, Longitude = 23.4381, Title = "Viirelaid" },
                new islandLocation { Latitude = 58.2019, Longitude = 26.0578, Title = "Tondisaar" },
                new islandLocation { Latitude = 58.2160, Longitude = 24.1247, Title = "Manilaid" }
            };
        }
    }
}
