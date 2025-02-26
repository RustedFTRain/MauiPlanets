using MauiPlanets.Models;


namespace Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the " +
                "smallest in the Solar System. In English, it is named after the " +
                "ancient Roman gods Mercurius (Mercury), god of commerce and " +
                "communication, and the messenger of the gods.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a " +
                "terrestrial planet and is the closest in mass and size to its " +
                "orbital neighbour Earth. Venus has by far the densest atmosphere " +
                "of the terrestrial planets, composed mostly of carbon dioxide " +
                "with a thick, global sulfuric acid cloud cover.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and " +
                "the only astronomical object known to harbor life. This is " +
                "enabled by Earth being an ocean world, the only one in the " +
                "Solar System sustaining liquid surface water. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined and slightly less than one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://th-thumbnailer.cdn-si-edu.com/vKRt2OfGlFia5On4QNaraJ3vXJM=/1000x750/filters:no_upscale():focal(1829x871:1830x872)/https://tf-cmsv2-smithsonianmag-media.s3.amazonaws.com/filer_public/b5/5e/b55e16bf-9338-4433-b52f-a83fb5e2b840/pj_66_27_enhanced.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second " +
                "largest in the Solar System, after Jupiter. It is a gas giant, with " +
                "an average radius of about nine times that of Earth. It has an " +
                "eighth the average density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a " +
                "gaseous cyan-coloured ice giant. Most of the planet is made of " +
                "water, ammonia, and methane in a supercritical phase of matter, " +
                "which astronomy calls ice or volatiles. The planet's atmosphere " +
                "has a complex layered cloud structure and has the lowest " +
                "minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar " +
                "System's planets.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://ichef.bbci.co.uk/images/ic/1376xn/p0257vk5.jpg.webp",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The good of sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest known planet " +
                "from the Sun. It is the fourth-largest planet in the Solar " +
                "System by diameter, the third-most-massive planet, and the " +
                "densest giant planet. It is 17 times the mass of Earth. ",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/PIA01492/PIA01492~large.jpg?w=1920&h=1917&fit=clip&crop=faces%2Cfocalpoint",
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "The once planet",
                HeroImage = "pluto.png",
                Description = "Pluto was long considered our ninth planet, but the " +
                "International Astronomical Union reclassified Pluto as a " +
                "dwarf planet in 2006. NASA's New Horizons was the first" +
                "spacecraft to explore Pluto up close, flying by in 2015. ",
                AccentColorStart = Color.FromArgb("#FFC033"),
                AccentColorEnd = Color.FromArgb("#5B4921"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2016/05/screenshot-2023-11-02-at-4.28.52-pm.png",
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "The goddess of corn and harvest",
                HeroImage = "ceres.png",
                Description = "Ceres was the first member of the asteroid belt to be " +
                "discovered when Giuseppe Piazzi spotted it in 1801. Called " +
                "an asteroid for many years, Ceres is so much bigger and so " +
                "different from its rocky neighbors that scientists classified " +
                "it as a dwarf planet in 2006. ",
                AccentColorStart = Color.FromArgb("#A09D95"),
                AccentColorEnd = Color.FromArgb("#6c6c6c"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "Hawaiian goddess of fertility",
                HeroImage = "haumea.png",
                Description = "Haumea is an oval-shaped dwarf planet that " +
                "is one of the fastest rotating large objects in our solar system. " +
                "The fast spin distorts Haumea's shape, " +
                "making this dwarf planet look like a football. ",
                AccentColorStart = Color.FromArgb("#5E5D5B"),
                AccentColorEnd = Color.FromArgb("#877c71"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/07/haumea-480x320-1-jpg.webp?w=320",
                }
            },
            new()
            {
                Name = "MakeMake",
                Subtitle = "The Rapanui god of fertility",
                HeroImage = "makemake.png",
                Description = "With a radius of approximately 444 miles (715 kilometers),  " +
                "Makemake is 1/9 the radius of Earth. " +
                "If Earth were the size of a nickel, " +
                "Makemake would be about as big as a mustard seed. ",
                AccentColorStart = Color.FromArgb("#c38f57"),
                AccentColorEnd = Color.FromArgb("#7e4d19"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSic9AFGvdm2ZrdlMuhiq0V9PxsvDMxntTE_g&s",
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "Warrior Xena",
                HeroImage = "eris.png",
                Description = "With an equatorial diameter of about 1,500 miles (2,400 kilometers), " +
                "Eris is about 1/5 the width of Earth. Eris, like Pluto, is a little smaller than Earth's Moon. " +
                "If the Earth were the size of a nickel, " +
                "Eris would be about as big as a popcorn kernel. ",
                AccentColorStart = Color.FromArgb("#cbc4be"),
                AccentColorEnd = Color.FromArgb("#6c6c6c"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSt2DO2bSSogXcV-sbm_Ij1IZq7N0M-2loUPg&s"
                }
            },
        };

        public static List<Planet> Planets { get => planets; set => planets = value; }

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
