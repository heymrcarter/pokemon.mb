using System.Collections.Generic;
using Nancy;
using Pokemon.Mb.Models;

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
        }
    }
}