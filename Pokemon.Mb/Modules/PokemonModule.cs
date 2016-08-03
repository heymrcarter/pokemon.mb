using System.Collections.Generic;
using System.Linq;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Responses;
using Pokemon.Mb.Models;
using Pokemon = Pokemon.Mb.Models.Pokemon;

namespace Pokemon.Mb.Modules
{
    public class PokemonModule : NancyModule
    {
        public PokemonModule() : base("/pokemon")
        {
            var pokemon = new List<Models.Pokemon>
            {
                new Models.Pokemon
                {
                    Id = 1,
                    Number = 1,
                    Name = "Bulbasaur",
                    Rarity = new RarityLevel
                    {
                        Id = 1,
                        Name = "Special",
                        Abbrivation = "SP"
                    }
                }
            };

            Get["/"] = _ => pokemon;

            Get["/{id}"] = parameters =>
            {
                var requestedPokemon = pokemon.FirstOrDefault(p => p.Id == parameters.id);

                if (requestedPokemon == null)
                {
                    return HttpStatusCode.NotFound;
                }

                return requestedPokemon;
            };

            Post["/"] = _ =>
            {
                var body = this.Bind<Models.Pokemon>(new BindingConfig
                {
                    BodyOnly = true
                });

                pokemon.Add(body);

                var response = new JsonResponse(body, new DefaultJsonSerializer())
                {
                    StatusCode = HttpStatusCode.Created,
                    ReasonPhrase = "Created"
                };
                return response;
            };
        }
    }
}