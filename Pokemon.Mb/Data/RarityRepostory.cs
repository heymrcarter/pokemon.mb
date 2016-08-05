using System;
using Pokemon.Mb.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon.Mb.Data
{
    public class RarityRepostory : IRarityRepository
    {
        private readonly IEnumerable<RarityLevel> _levels;

        public RarityRepostory(IRarityProvider provider)
        {
            _levels = provider.SeedRarity();
        }

        public IEnumerable<RarityLevel> GetRarityLevels()
        {
            return _levels;
        }

        public RarityLevel GetRarityLevelById(int id)
        {
            return _levels.FirstOrDefault(l => l.Id == id);
        }

        public RarityLevel GetRarityLevelByName(string name)
        {
            return _levels.FirstOrDefault(l => l.Name.ToLower() == name.ToLower());
        }
    }
}