using Pokemon.Mb.Models;
using System.Collections.Generic;

namespace Pokemon.Mb.Data
{
    public interface IRarityProvider
    {
        IEnumerable<RarityLevel> SeedRarity();
    }
}
