using Nancy;
using Nancy.Testing;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pokemon.Mb.UnitTests.Modules.Pokemon
{
    public class PokemonModuleGetSpec
    {
        private readonly Browser _browser;

        public PokemonModuleGetSpec()
        {
            _browser = new Browser(new DefaultNancyBootstrapper());
        }

        [Fact]
        public void Should_return_array_of_pokemon()
        {
            var result = _browser.Get("/pokemon", with =>
            {
                with.HttpRequest();
                with.Header("Accept", "application/json");
            });

            var response = result.Body.DeserializeJson<List<Models.Pokemon>>();
            var pokemon = response.FirstOrDefault();

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.NotEmpty(response);
            Assert.NotNull(pokemon);
            Assert.NotNull(pokemon.Name);
            Assert.NotNull(pokemon.Id);
            Assert.NotNull(pokemon.Number);
            Assert.NotNull(pokemon.Rarity);
        }

        [Fact]
        public void Can_get_pokemon_by_id()
        {
            var result = _browser.Get("/pokemon/1", with =>
            {
                with.HttpRequest();
                with.Header("Accept", "application/json");
                with.Header("Content-type", "application/json");
            });

            var pokemon = result.Body.DeserializeJson<Models.Pokemon>();

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.NotNull(pokemon);
            Assert.Equal("Bulbasaur", pokemon.Name);
            Assert.Equal(1, pokemon.Number);
            Assert.Equal(1, pokemon.Id);
            Assert.NotNull(pokemon.Rarity);
            Assert.Equal(1, pokemon.Rarity.Id);
            Assert.Equal("SP", pokemon.Rarity.Abbrivation);
            Assert.Equal("Special", pokemon.Rarity.Name);
        }
    }
}
