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
    }
}
