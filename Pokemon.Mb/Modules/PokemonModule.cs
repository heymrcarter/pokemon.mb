using Nancy;
using Pokemon.Mb.Data;

namespace Pokemon.Mb.Modules
{
    public class PokemonModule : NancyModule
    {
        private readonly IPokemonRepository _repo;

        public PokemonModule(IPokemonRepository repo) : base("/pokemon")
        {
            _repo = repo;

            Get["/"] = _ => _repo.GetPokemon();

            Get["/{id}"] = parameters =>
            {
                var requestedPokemon = _repo.GetPokemonById(parameters.id);

                return requestedPokemon ?? HttpStatusCode.NotFound;
            };
        }
    }
}