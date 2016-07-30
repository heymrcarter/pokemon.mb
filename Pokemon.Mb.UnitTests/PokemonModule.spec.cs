using System.Collections.Generic;
using System.Linq;
using Nancy;
using Nancy.Testing;
using Xunit;

namespace Pokemon.Mb.UnitTests
{
    public class PokemonModuleSpec
    {
        private readonly Browser _browser;

        public PokemonModuleSpec()
        {
            _browser = new Browser(new DefaultNancyBootstrapper());
        }

        [Fact]
        public void Should_return_ok_status_code()
        {
            var result = _browser.Get("/pokemon", with =>
            {
                with.HttpRequest();
            });

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
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

            Assert.NotEmpty(response);
            Assert.NotNull(pokemon);
            Assert.NotNull(pokemon.Name);
            Assert.NotNull(pokemon.Id);
            Assert.NotNull(pokemon.Number);
            Assert.NotNull(pokemon.Rarity);
        }
    }
}
