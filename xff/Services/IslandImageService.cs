using System.Collections.Generic;

namespace xff.Services
{
    public class IslandImageService
    {
        public List<IslandImage> GetIslandImages()
        {
            return new List<IslandImage>
            {
                new IslandImage { Title = "Suur-Pakri", Images = new List<string> { "suurpakri_a.jpg", "suurpakri_b.jpg", "suurpakri_c.jpg" } },
                new IslandImage { Title = "Väike-Pakri", Images = new List<string> { "vaikepakri_a.jpg", "vaikepakri_b.jpg", "vaikepakri_c.jpg" } },
                new IslandImage { Title = "Aegna", Images = new List<string> { "aegna_a.jpg", "aegna_b.jpg", "aegna_c.jpg" } },
                new IslandImage { Title = "Viirelaid", Images = new List<string> { "viirelaid_a.jpg", "viirelaid_b.jpg", "viirelaid_c.jpg" } },
                new IslandImage { Title = "Tondisaar", Images = new List<string> { "tondisaar_a.jpeg", "tondisaar_b.jpg", "tondisaar_c.jpg" } },
                new IslandImage { Title = "Manilaid", Images = new List<string> { "manilaid_a.jpg", "manilaid_b.jpg", "manilaid_c.jpg" } },
            };
        }
    }

    public class IslandImage
    {
        public string Title { get; set; }
        public List<string> Images { get; set; }
    }
}
