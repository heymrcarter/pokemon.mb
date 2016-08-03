using System.Collections.Generic;
using CsQuery.ExtensionMethods;
using Nancy.Testing;
using Nancy;
using Pokemon.Mb.Models;
using Xunit;

namespace Pokemon.Mb.UnitTests.Modules.Pokemon
{
    public class PokemonModulePostSpec
    {
        private readonly Browser _browser;

        public PokemonModulePostSpec()
        {
            _browser = new Browser(new DefaultNancyBootstrapper());
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

        [Fact]
        public void Number_available_pokemon_increments_when_pokemon_added()
        {
            var newPokemon = new Models.Pokemon
            {
                Id = 2,
                Name = "Ivysaur",
                Number = 2,
                Rarity = new RarityLevel
                {
                    Id = 1,
                    Name = "Special",
                    Abbrivation = "SP"
                }
            };

            _browser.Post("/pokemon", with =>
            {
                with.HttpRequest();
                with.Header("Accept", "application/json");
                with.Header("Content-type", "application/json");
                with.Body(newPokemon.ToJSON());
            });

            var getResult = _browser.Get("/pokemon", with =>
            {
                with.HttpRequest();
                with.Header("Accept", "application/json");
            });

            var result = getResult.Body.DeserializeJson<List<Models.Pokemon>>();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void Should_return_bad_request_for_invalid_body()
        {
            
        }
    }
}
