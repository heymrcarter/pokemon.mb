using Nancy;

namespace Pokemon.Mb.Modules
{
    public class PokemonModule : NancyModule
    {
        public PokemonModule() : base("/pokemon")
        {
            Get["/"] = parameters => {
                return HttpStatusCode.OK;
            };
        }
    }
}