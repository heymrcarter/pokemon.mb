using Nancy;
using Pokemon.Mb.Models;

namespace Pokemon.Mb.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule() : base("/")
        {
            Get["/"] = _ =>
            {
                var response = new MetadataResponse
                {
                    Name = "Pokemon.Mb",
                    Description = "An API from the Moonbow family to manage Pokemon available in Pokemon GO",
                    Version = typeof(Models.Pokemon).Assembly.GetName().Version.ToString().Substring(0, 5)
                };

                return response;
            };
        }
    }
}