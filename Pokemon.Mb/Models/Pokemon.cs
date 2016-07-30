namespace Pokemon.Mb.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public RarityLevel Rarity { get; set; }
    }
}