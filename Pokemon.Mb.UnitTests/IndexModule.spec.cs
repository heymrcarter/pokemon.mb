using Nancy;
using Nancy.Testing;
using System;
using Pokemon.Mb.Models;
using Xunit;

namespace Pokemon.Mb.UnitTests
{
    public class IndexModuleSpec : IDisposable
    {
        private Browser _browser;

        public IndexModuleSpec()
        {
            _browser	 = new Browser(new DefaultNancyBootstrapper());
        }

        public void Dispose()
        {
            _browser = null;
        }

        [Fact]
        public void Returns_OK_response_with_metadata()
        {
            var result = _browser.Get("/", with =>
            {
                with.HttpRequest();
                with.Header("Accept", "application/json");
            });

            var response = result.Body.DeserializeJson<MetadataResponse>();

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
	        Assert.NotNull(response.Description);
	        Assert.NotNull(response.Name);
	        Assert.Equal("0.1.0", response.Version);
        }
    }
}