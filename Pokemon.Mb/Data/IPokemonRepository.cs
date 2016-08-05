using System.Collections.Generic;

namespace Pokemon.Mb.Data
{
    public interface IPokemonRepository
    {
        IEnumerable<Models.Pokemon> GetPokemon();

        Models.Pokemon GetPokemonById(int id);
    }
}
