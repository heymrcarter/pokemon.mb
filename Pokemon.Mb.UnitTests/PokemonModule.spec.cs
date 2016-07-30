using Nancy;
using Nancy.Testing;
using Xunit;

namespace Pokemon.Mb.UnitTests
{
    public class PokemonModuleSpec
    {
        [Fact]
        public void Should_return_ok_status_code()
        {
            var bootstrapper = new DefaultNancyBootstrapper();
            var browser = new Browser(bootstrapper);

            var result = browser.Get("/pokemon", with =>
            {
                with.HttpRequest();
            });

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }
    }
}
