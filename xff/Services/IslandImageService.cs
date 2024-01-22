using System.Collections.Generic;

namespace xff.Services
{
    public class IslandImageService
    {
        public List<IslandImage> GetIslandImages()
        {
            return new List<IslandImage>
            {
                new IslandImage { Title = "Suur-Pakri", Images = new List<string> { "test.jpg", "background.jpg", "test.jpg" } },
                new IslandImage { Title = "Väike-Pakri", Images = new List<string> { "test.jpg", "background.jpg", "test.jpg" } },
                new IslandImage { Title = "Manilaid", Images = new List<string> { "test.jpg", "background.jpg", "test.jpg" } },
                new IslandImage { Title = "Aegna", Images = new List<string> { "test.jpg", "background.jpg", "test.jpg" } },
            };
        }
    }

    public class IslandImage
    {
        public string Title { get; set; }
        public List<string> Images { get; set; }
    }
}
