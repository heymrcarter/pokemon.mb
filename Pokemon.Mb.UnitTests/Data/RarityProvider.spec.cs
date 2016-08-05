using Pokemon.Mb.Data;
using System.Linq;
using Xunit;

namespace Pokemon.Mb.UnitTests.Data
{
    public class RarityProviderSpec
    {
        private readonly RarityProvider _provider;

        public RarityProviderSpec()
        {
            _provider = new RarityProvider();
        }

        [Fact]
        public void Returns_all_12_rarity_levels()
        {
            var rarityLevels = _provider.SeedRarity();

            Assert.Equal(12, rarityLevels.Count());
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Everywhere"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Virtually Everywhere"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Very Common"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Common"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Uncommon"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Rare"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Very Rare"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Epic"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Mythical"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Special"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Region Exclusive"));
            Assert.NotNull(rarityLevels.FirstOrDefault(r => r.Name == "Unobtainable"));
        }
    }
}
