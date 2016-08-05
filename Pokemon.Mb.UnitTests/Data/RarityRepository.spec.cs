using Moq;
using Pokemon.Mb.Data;
using Pokemon.Mb.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pokemon.Mb.UnitTests.Data
{
    public class RarityRepositorySpec
    {
        private RarityRepostory _repo;

        public RarityRepositorySpec()
        {
            var mock = new Mock<IRarityProvider>();
            mock.Setup(p => p.SeedRarity()).Returns(new List<RarityLevel>
            {
                new RarityLevel
                {
                    Id = 1,
                    Name = "Special",
                    Abbrivation = "SP"
                }
            });

            _repo = new RarityRepostory(mock.Object);
        }

        [Fact]
        public void Can_get_all_rarity_levels()
        {
            var levels = _repo.GetRarityLevels();
            var level = levels.FirstOrDefault();

            Assert.NotEmpty(levels);
            Assert.NotNull(level);
            Assert.Equal("Special", level.Name);
            Assert.Equal("SP", level.Abbrivation);
        }

        [Fact]
        public void Can_get_level_by_id()
        {
            var level = _repo.GetRarityLevelById(1);

            Assert.NotNull(level);
            Assert.Equal("Special", level.Name);
            Assert.Equal(1, level.Id);
            Assert.Equal("SP", level.Abbrivation);
        }

        [Fact]
        public void Can_get_level_by_name()
        {
            var level = _repo.GetRarityLevelByName("Special");

            Assert.NotNull(level);
            Assert.Equal("Special", level.Name);
            Assert.Equal("SP", level.Abbrivation);
        }
    }
}
