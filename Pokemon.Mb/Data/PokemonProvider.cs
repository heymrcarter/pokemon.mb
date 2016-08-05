using System.Collections.Generic;

namespace Pokemon.Mb.Data
{
    public class PokemonProvider : IPokemonProvider
    {
        private readonly IEnumerable<Models.Pokemon> _pokemon;

        public PokemonProvider(IRarityRepository repo)
        {
            _pokemon = new List<Models.Pokemon>
            {
                new Models.Pokemon
                {
                    Id = 1,
                    Name = "Bulbasaur",
                    Number = 1,
                    Rarity = repo.GetRarityLevelByName("Special")
                },
                new Models.Pokemon
                {
                    Id = 2,
                    Name = "Ivysaur",
                    Number = 2,
                    Rarity = repo.GetRarityLevelByName("Special")
                },
                new Models.Pokemon
                {
                    Id = 3,
                    Name = "Venusaur",
                    Number = 3,
                    Rarity = repo.GetRarityLevelByName("Special")
                },
                new Models.Pokemon
                {
                    Id = 4,
                    Name = "Charmander",
                    Number = 4,
                    Rarity = repo.GetRarityLevelByName("Special")
                },
                new Models.Pokemon
                {
                    Id = 5,
                    Name = "Charmeleon",
                    Number = 5,
                    Rarity = repo.GetRarityLevelByName("Special")
                },
                new Models.Pokemon
                {
                    Id = 6,
                    Name = "Charizard",
                    Number = 6,
                    Rarity = repo.GetRarityLevelByName("Special")
                },
                new Models.Pokemon
                {
                    Id = 7,
                    Name = "Squirtle",
                    Number = 7,
                    Rarity = repo.GetRarityLevelByName("Special")
                },
                new Models.Pokemon
                {
                    Id = 8,
                    Name = "Wartortle",
                    Number = 8,
                    Rarity = repo.GetRarityLevelByName("Special")
                },
                new Models.Pokemon
                {
                    Id = 9,
                    Name = "Blastoise",
                    Number = 9,
                    Rarity = repo.GetRarityLevelByName("Special")
                },
                new Models.Pokemon
                {
                    Id = 10,
                    Name = "Caterpie",
                    Number = 10,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 11,
                    Name = "Metapod",
                    Number = 11,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 12,
                    Name = "Butterfree",
                    Number = 12,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 13,
                    Name = "Weedle",
                    Number = 13,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 14,
                    Name = "Kakuna",
                    Number = 14,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 15,
                    Name = "Beedrill",
                    Number = 15,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 16,
                    Name = "Pidgey",
                    Number = 16,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 17,
                    Name = "Pidgeotto",
                    Number = 17,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 18,
                    Name = "Pidgeot",
                    Number = 18,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 19,
                    Name = "Rattata",
                    Number = 19,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 20,
                    Name = "Raticate",
                    Number = 20,
                    Rarity = repo.GetRarityLevelByName("Everywhere")
                },
                new Models.Pokemon
                {
                    Id = 21,
                    Name = "Spearow",
                    Number = 21,
                    Rarity = repo.GetRarityLevelByName("Very Common")
                },
                new Models.Pokemon
                {
                    Id = 22,
                    Name = "Fearow",
                    Number = 22,
                    Rarity = repo.GetRarityLevelByName("Very Common")
                },
                new Models.Pokemon
                {
                    Id = 23,
                    Name = "Ekans",
                    Number = 23,
                    Rarity = repo.GetRarityLevelByName("Common")
                },
                 new Models.Pokemon
                 {
                     Id = 24,
                     Name = "Arbok",
                     Number = 24,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 25,
                     Name = "Pikachu",
                     Number = 25,
                     Rarity = repo.GetRarityLevelByName("Special")
                 },
                 new Models.Pokemon
                 {
                     Id = 26,
                     Name = "Raichu",
                     Number = 26,
                     Rarity = repo.GetRarityLevelByName("Special")
                 },
                 new Models.Pokemon
                 {
                     Id = 27,
                     Name = "Sandshrew",
                     Number = 27,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 28,
                     Name = "Sandslash",
                     Number = 28,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 29,
                     Name = "Nidoran (female)",
                     Number = 29,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 30,
                     Name = "Nidorina",
                     Number = 30,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 31,
                     Name = "Nidoqueen",
                     Number = 31,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 32,
                     Name = "Nidoran (male)",
                     Number = 32,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 33,
                     Name = "Nidorino",
                     Number = 33,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 34,
                     Name = "Nidoking",
                     Number = 34,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 35,
                     Name = "Clefairy",
                     Number = 35,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 36,
                     Name = "Clefable",
                     Number = 36,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 37,
                     Name = "Vulpix",
                     Number = 37,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 38,
                     Name = "Ninetails",
                     Number = 38,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 39,
                     Name = "Jigglypuff",
                     Number = 39,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 40,
                     Name = "Wigglytuff",
                     Number = 40,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 41,
                     Name = "Zubat",
                     Number = 41,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 42,
                     Name = "Golbat",
                     Number = 42,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 43,
                     Name = "Oddish",
                     Number = 43,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 44,
                     Name = "Gloom",
                     Number = 44,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 45,
                     Name = "Vileplume",
                     Number = 45,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 46,
                     Name = "Paras",
                     Number = 46,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 47,
                     Name = "Parasect",
                     Number = 47,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 48,
                     Name = "Venonat",
                     Number = 48,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 49,
                     Name = "Venomoth",
                     Number = 49,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 50,
                     Name = "Diglett",
                     Number = 50,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 51,
                     Name = "Dugtrio",
                     Number = 51,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 52,
                     Name = "Meowth",
                     Number = 52,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 53,
                     Name = "Persian",
                     Number = 53,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 54,
                     Name = "Psyduck",
                     Number = 54,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 55,
                     Name = "Golduck",
                     Number = 55,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 56,
                     Name = "Mankey",
                     Number = 56,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 57,
                     Name = "Primeape",
                     Number = 57,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 58,
                     Name = "Growlithe",
                     Number = 58,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 59,
                     Name = "Arcanine",
                     Number = 59,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 60,
                     Name = "Poliwag",
                     Number = 60,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 61,
                     Name = "Poliwhirl",
                     Number = 61,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 62,
                     Name = "Poliwrath",
                     Number = 62,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 63,
                     Name = "Abra",
                     Number = 63,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 64,
                     Name = "Kadabra",
                     Number = 64,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 65,
                     Name = "Alakazam",
                     Number = 65,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 66,
                     Name = "Machop",
                     Number = 66,
                     Rarity = repo.GetRarityLevelByName("VeryRare")
                 },
                 new Models.Pokemon
                 {
                     Id = 67,
                     Name = "Machoke",
                     Number = 67,
                     Rarity = repo.GetRarityLevelByName("VeryRare")
                 },
                 new Models.Pokemon
                 {
                     Id = 68,
                     Name = "Machamp",
                     Number = 68,
                     Rarity = repo.GetRarityLevelByName("VeryRare")
                 },
                 new Models.Pokemon
                 {
                     Id = 69,
                     Name = "Bellsprout",
                     Number = 69,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 70,
                     Name = "Weepingbell",
                     Number = 70,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 71,
                     Name = "Victreebel",
                     Number = 71,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 72,
                     Name = "Tentacool",
                     Number = 72,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 73,
                     Name = "Tentacruel",
                     Number = 73,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 74,
                     Name = "Geodude",
                     Number = 74,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 75,
                     Name = "Graveller",
                     Number = 75,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 76,
                     Name = "Golem",
                     Number = 76,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 77,
                     Name = "Ponyta",
                     Number = 77,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 78,
                     Name = "Rapidash",
                     Number = 78,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 79,
                     Name = "Slowpoke",
                     Number = 79,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 80,
                     Name = "Slowbro",
                     Number = 80,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 81,
                     Name = "Magnemite",
                     Number = 81,
                     Rarity = repo.GetRarityLevelByName("Epic")
                 },
                 new Models.Pokemon
                 {
                     Id = 82,
                     Name = "Magneton",
                     Number = 82,
                     Rarity = repo.GetRarityLevelByName("Epic")
                 },
                 new Models.Pokemon
                 {
                     Id = 83,
                     Name = "Farfetch'd",
                     Number = 83,
                     Rarity = repo.GetRarityLevelByName("Region Exclusive")
                 },
                 new Models.Pokemon
                 {
                     Id = 84,
                     Name = "Doduo",
                     Number = 84,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 85,
                     Name = "Dodrio",
                     Number = 85,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 86,
                     Name = "Seel",
                     Number = 86,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 87,
                     Name = "Dewgong",
                     Number = 87,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 88,
                     Name = "Grimer",
                     Number = 88,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 89,
                     Name = "Muk",
                     Number = 89,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 90,
                     Name = "Shellder",
                     Number = 90,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 91,
                     Name = "Cloyster",
                     Number = 91,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 92,
                     Name = "Gastly",
                     Number = 92,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 93,
                     Name = "Haunter",
                     Number = 93,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 94,
                     Name = "Gengar",
                     Number = 94,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 95,
                     Name = "Onix",
                     Number = 95,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 96,
                     Name = "Drowzee",
                     Number = 96,
                     Rarity = repo.GetRarityLevelByName("Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 97,
                     Name = "Hypno",
                     Number = 97,
                     Rarity = repo.GetRarityLevelByName("Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 98,
                     Name = "Krabby",
                     Number = 98,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 99,
                     Name = "Kingler",
                     Number = 99,
                     Rarity = repo.GetRarityLevelByName("Very Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 100,
                     Name = "Voltorb",
                     Number = 100,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 101,
                     Name = "Electrode",
                     Number = 101,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 102,
                     Name = "Exeggcute",
                     Number = 102,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 103,
                     Name = "Exeggutor",
                     Number = 103,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 104,
                     Name = "Cubone",
                     Number = 104,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 105,
                     Name = "Marowak",
                     Number = 105,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 106,
                     Name = "Hitmonlee",
                     Number = 106,
                     Rarity = repo.GetRarityLevelByName("Epic")
                 },
                 new Models.Pokemon
                 {
                     Id = 107,
                     Name = "Hitmonchan",
                     Number = 107,
                     Rarity = repo.GetRarityLevelByName("Epic")
                 },
                 new Models.Pokemon
                 {
                     Id = 108,
                     Name = "Lickitung",
                     Number = 108,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 109,
                     Name = "Koffing",
                     Number = 109,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 110,
                     Name = "Weezing",
                     Number = 110,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 111,
                     Name = "Rhyhorn",
                     Number = 111,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 112,
                     Name = "Rhyhorn",
                     Number = 112,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 113,
                     Name = "Chansey",
                     Number = 113,
                     Rarity = repo.GetRarityLevelByName("Epic")
                 },
                 new Models.Pokemon
                 {
                     Id = 114,
                     Name = "Tangela",
                     Number = 114,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 115,
                     Name = "Kangaskhan",
                     Number = 115,
                     Rarity = repo.GetRarityLevelByName("Region Exclusive")
                 },
                 new Models.Pokemon
                 {
                     Id = 116,
                     Name = "Horsea",
                     Number = 116,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 117,
                     Name = "Seadra",
                     Number = 117,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 118,
                     Name = "Goldeen",
                     Number = 118,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 119,
                     Name = "Seaking",
                     Number = 119,
                     Rarity = repo.GetRarityLevelByName("Common")
                 },
                 new Models.Pokemon
                 {
                     Id = 120,
                     Name = "Staryu",
                     Number = 120,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 121,
                     Name = "Starmie",
                     Number = 121,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 122,
                     Name = "Mr Mime",
                     Number = 122,
                     Rarity = repo.GetRarityLevelByName("Region Exclusive")
                 },
                 new Models.Pokemon
                 {
                     Id = 123,
                     Name = "Scyther",
                     Number = 123,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 124,
                     Name = "Jynx",
                     Number = 124,
                     Rarity = repo.GetRarityLevelByName("Uncommon")
                 },
                 new Models.Pokemon
                 {
                     Id = 125,
                     Name = "Electabuzz",
                     Number = 125,
                     Rarity = repo.GetRarityLevelByName("Epic")
                 },
                 new Models.Pokemon
                 {
                     Id = 126,
                     Name = "Magmar",
                     Number = 126,
                     Rarity = repo.GetRarityLevelByName("Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 127,
                     Name = "Pinsir",
                     Number = 127,
                     Rarity = repo.GetRarityLevelByName("Very Rare")
                 },
                 new Models.Pokemon
                 {
                     Id = 128,
                     Name = "Tauros",
                     Number = 128,
                     Rarity = repo.GetRarityLevelByName("Region Exclusive")
                 },
                 new Models.Pokemon
                 {
                     Id = 129,
                     Name = "Magikarp",
                     Number = 129,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 130,
                     Name = "Gyrodos",
                     Number = 130,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 131,
                     Name = "Lapras",
                     Number = 133,
                     Rarity = repo.GetRarityLevelByName("Mythical")
                 },
                 new Models.Pokemon
                 {
                     Id = 132,
                     Name = "Ditto",
                     Number = 132,
                     Rarity = repo.GetRarityLevelByName("Unobtainable")
                 },
                 new Models.Pokemon
                 {
                     Id = 133,
                     Name = "Eevee",
                     Number = 133,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 134,
                     Name = "Vaporeon",
                     Number = 134,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 135,
                     Name = "Jolteon",
                     Number = 135,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 136,
                     Name = "Flareon",
                     Number = 136,
                     Rarity = repo.GetRarityLevelByName("Virtually Everywhere")
                 },
                 new Models.Pokemon
                 {
                     Id = 137,
                     Name = "Porygon",
                     Number = 137,
                     Rarity = repo.GetRarityLevelByName("Mythical")
                 },
                 new Models.Pokemon
                 {
                     Id = 138,
                     Name = "Omanyte",
                     Number = 138,
                     Rarity = repo.GetRarityLevelByName("Special")
                 },
                 new Models.Pokemon
                 {
                     Id = 139,
                     Name = "Omastar",
                     Number = 139,
                     Rarity = repo.GetRarityLevelByName("Special")
                 },
                 new Models.Pokemon
                 {
                     Id = 140,
                     Name = "Kabuto",
                     Number = 140,
                     Rarity = repo.GetRarityLevelByName("Special")
                 },
                 new Models.Pokemon
                 {
                     Id = 141,
                     Name = "Kabutops",
                     Number = 141,
                     Rarity = repo.GetRarityLevelByName("Special")
                 },
                 new Models.Pokemon
                 {
                     Id = 142,
                     Name = "Aerodactyl",
                     Number = 142,
                     Rarity = repo.GetRarityLevelByName("Special")
                 },
                 new Models.Pokemon
                 {
                     Id = 143,
                     Name = "Snorlax",
                     Number = 143,
                     Rarity = repo.GetRarityLevelByName("Mythical")
                 },
                 new Models.Pokemon
                 {
                     Id = 144,
                     Name = "Articuno",
                     Number = 144,
                     Rarity = repo.GetRarityLevelByName("Unobtainable")
                 },
                 new Models.Pokemon
                 {
                     Id = 145,
                     Name = "Zapdos",
                     Number = 145,
                     Rarity = repo.GetRarityLevelByName("Unobtainable")
                 },
                 new Models.Pokemon
                 {
                     Id = 146,
                     Name = "Moltres",
                     Number = 146,
                     Rarity = repo.GetRarityLevelByName("Unobtainable")
                 },
                 new Models.Pokemon
                 {
                     Id = 147,
                     Name = "Dratini",
                     Number = 147,
                     Rarity = repo.GetRarityLevelByName("Epic")
                 },
                 new Models.Pokemon
                 {
                     Id = 148,
                     Name = "Dragonair",
                     Number = 148,
                     Rarity = repo.GetRarityLevelByName("Epic")
                 },
                 new Models.Pokemon
                 {
                     Id = 149,
                     Name = "Dragonite",
                     Number = 149,
                     Rarity = repo.GetRarityLevelByName("Epic")
                 },
                 new Models.Pokemon
                 {
                     Id = 150,
                     Name = "Mewtwo",
                     Number = 150,
                     Rarity = repo.GetRarityLevelByName("Unobtainable")
                 },
                 new Models.Pokemon
                 {
                     Id = 151,
                     Name = "Mew",
                     Number = 151,
                     Rarity = repo.GetRarityLevelByName("Unobtainable")
                 }
            };
        }

        public IEnumerable<Models.Pokemon> SeedPokemon()
        {
            return _pokemon;
        }
    }
}