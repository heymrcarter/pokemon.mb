using System.Collections.Generic;
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
            Get["/"] = parameters =>
            {
                var response = new List<Models.Pokemon>
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

                return response;
            };

            Post["/"] = parameters =>
            {
                var pokemon = this.Bind<Models.Pokemon>(new BindingConfig
                {
                    BodyOnly = true
                });

                var response = new JsonResponse(pokemon, new DefaultJsonSerializer())
                {
                    StatusCode = HttpStatusCode.Created,
                    ReasonPhrase = "Created"
                };
                return response;
            };
        }
    }
}