using Pokemon.Mb.Models;
using System.Collections.Generic;

namespace Pokemon.Mb.Data
{
    public class RarityProvider : IRarityProvider
    {
        private readonly IEnumerable<RarityLevel> _rarityLevels;

        public RarityProvider()
        {
            _rarityLevels = new List<RarityLevel>
            {
                new RarityLevel
                {
                    Id = 1,
                    Name = "Everywhere",
                    Abbrivation = "EW"
                },
                new RarityLevel
                {
                    Id = 2,
                    Name = "Virtually Everywhere",
                    Abbrivation = "VE"
                },
                new RarityLevel
                {
                    Id = 3,
                    Name = "Very Common",
                    Abbrivation = "VC"
                },
                new RarityLevel
                {
                    Id = 4,
                    Name = "Common",
                    Abbrivation = "C"
                },
                new RarityLevel
                {
                    Id = 5,
                    Name = "Uncommon",
                    Abbrivation = "UC"
                },
                new RarityLevel
                {
                    Id = 6,
                    Name = "Rare",
                    Abbrivation = "RA"
                },
                new RarityLevel
                {
                    Id = 7,
                    Name = "Very Rare",
                    Abbrivation = "VR"
                },
                new RarityLevel
                {
                    Id = 8,
                    Name = "Epic",
                    Abbrivation = "EP"
                },
                new RarityLevel
                {
                    Id = 9,
                    Name = "Mythical",
                    Abbrivation = "MY"
                },
                new RarityLevel
                {
                    Id = 10,
                    Name = "Special",
                    Abbrivation = "SP"
                },
                new RarityLevel
                {
                    Id = 11,
                    Name = "Region Exclusive",
                    Abbrivation = "RE"
                },
                new RarityLevel
                {
                    Id = 12,
                    Name = "Unobtainable",
                    Abbrivation = "UO"
                }
            };
        }

        public IEnumerable<RarityLevel> SeedRarity()
        {
            return _rarityLevels;
        }
    }
}