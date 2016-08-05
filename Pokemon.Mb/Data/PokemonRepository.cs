using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.Mb.Data
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly List<Models.Pokemon> _pokemon;

        public PokemonRepository(IPokemonProvider provider)
        {
            _pokemon = provider.SeedPokemon().ToList();
        }

        public IEnumerable<Models.Pokemon> GetPokemon()
        {
            return _pokemon;
        }

        public Models.Pokemon GetPokemonById(int id)
        {
            return _pokemon.FirstOrDefault(p => p.Id == id);
        }
    }
}