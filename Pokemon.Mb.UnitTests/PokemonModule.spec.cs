using System.Collections.Generic;
using System.Linq;
using CsQuery.ExtensionMethods;
using Nancy;
using Nancy.Testing;
using Pokemon.Mb.Models;
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

        [Fact]
        public void Can_add_a_pokemon()
        {
            var pokemon = new Models.Pokemon
            {
                Number = 2,
                Name = "Ivysaur",
                Rarity = new RarityLevel
                {
                    Id = 1,
                    Name = "Special",
                    Abbrivation = "SP"
                }
            };

            var json = pokemon.ToJSON();

            var result = _browser.Post("/pokemon", with =>
            {
                with.HttpRequest();
                with.Body(json);
                with.Header("Accept", "application/json");
                with.Header("Content-type", "application/json");
            });

            var body = result.Body.DeserializeJson<Models.Pokemon>();

            Assert.Equal(HttpStatusCode.Created, result.StatusCode);
            Assert.NotNull(body);
            Assert.Equal(pokemon.Number, body.Number);
            Assert.Equal(pokemon.Name, body.Name);
            Assert.NotNull(body.Rarity);
            Assert.Equal(pokemon.Rarity.Name, body.Rarity.Name);
            Assert.Equal(pokemon.Rarity.Abbrivation, body.Rarity.Abbrivation);
            Assert.Equal(pokemon.Rarity.Id, body.Rarity.Id);
        }
    }
}
