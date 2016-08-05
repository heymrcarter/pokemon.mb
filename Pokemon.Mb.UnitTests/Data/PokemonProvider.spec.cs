using Moq;
using Pokemon.Mb.Data;
using Pokemon.Mb.Models;
using System.Linq;
using Xunit;

namespace Pokemon.Mb.UnitTests.Data
{
    public class PokemonProviderSpec
    {
        private readonly Mb.Data.PokemonProvider _provider;

        public PokemonProviderSpec()
        {
            var mock = new Mock<IRarityRepository>();
            mock.Setup(r => r.GetRarityLevelByName(It.IsAny<string>())).Returns(new RarityLevel
            {
                Id = 1,
                Name = "Special",
                Abbrivation = "SP"
            });

            _provider = new PokemonProvider(mock.Object);
        }

        [Fact]
        public void Does_return_151_pokemon()
        {
            var pokemon = _provider.SeedPokemon();

            Assert.Equal(151, pokemon.Count());
        }

        [Fact]
        public void Returns_rarity_level()
        {
            var pokemon = _provider.SeedPokemon();
            var subject = pokemon.FirstOrDefault();
            
            Assert.NotNull(subject);
            Assert.NotNull(subject.Rarity);
            Assert.Equal("Special", subject.Rarity.Name);
            Assert.Equal("SP", subject.Rarity.Abbrivation);
        }
    }
}
