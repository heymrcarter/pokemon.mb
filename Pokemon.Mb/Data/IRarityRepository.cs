using Pokemon.Mb.Models;
using System.Collections.Generic;

namespace Pokemon.Mb.Data
{
    public interface IRarityRepository
    {
        IEnumerable<RarityLevel> GetRarityLevels();

        RarityLevel GetRarityLevelById(int id);

        RarityLevel GetRarityLevelByName(string name);
    }
}
