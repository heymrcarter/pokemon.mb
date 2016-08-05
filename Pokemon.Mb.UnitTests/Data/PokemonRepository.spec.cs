using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Pokemon.Mb.Data;
using Pokemon.Mb.Models;
using Xunit;

namespace Pokemon.Mb.UnitTests.Data
{
    public class PokemonRepositorySpec
    {
        private readonly IPokemonRepository _repository;
        private List<Models.Pokemon> _pokemon;

        public PokemonRepositorySpec()
        {
            _pokemon = new List<Models.Pokemon>
            {
                new Models.Pokemon
                {
                    Id = 1,
                    Number = 1,
                    Name = "Bulbasaur",
                    Rarity = new RarityLevel
                    {
                        Id = 1,
                        Name ="Special",
                        Abbrivation = "SP"
                    }
                }
            };

            var mock = new Mock<IPokemonProvider>();
            mock.Setup(p => p.SeedPokemon()).Returns(_pokemon);

            _repository = new PokemonRepository(mock.Object);
        }

        [Fact]
        public void Can_get_pokemon()
        {
            var pokemon = _repository.GetPokemon();

            Assert.NotEmpty(pokemon);
        }

        [Fact]
        public void Can_get_pokemon_by_id()
        {
            var pokemon = _repository.GetPokemonById(1);

            var expected = _pokemon.FirstOrDefault();

            Assert.NotNull(pokemon);
            Assert.NotNull(expected);
            Assert.Equal(expected.Name, pokemon.Name);
            Assert.Equal(expected.Number, pokemon.Number);
            Assert.Equal(expected.Id, pokemon.Id);
            Assert.NotNull(pokemon.Rarity);
            Assert.Equal(expected.Rarity.Name, pokemon.Rarity.Name);
            Assert.Equal(expected.Rarity.Abbrivation, pokemon.Rarity.Abbrivation);
        }
    }
}
