using System.Collections.Generic;

namespace Pokemon.Mb.Data
{
    public interface IPokemonProvider
    {
        IEnumerable<Models.Pokemon> SeedPokemon();
    }
}
