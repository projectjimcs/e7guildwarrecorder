using System;
using E7GuildWarRecorder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E7GuildWarRecorder.Database.Configuration
{
	public class HeroConfiguration : IEntityTypeConfiguration<Hero>
	{
        public void Configure(EntityTypeBuilder<Hero> builder)
        {
            builder.ToTable("hero");

            builder.HasData(
                new Hero
                {
                    Id = 1,
                    Key = "achates",
                    Name = "Achates",
                    Icon = "achates.png"
                },
                new Hero
                {
                    Id = 2,
                    Key = "assassin-cidd",
                    Name = "Assassin Cidd",
                    Icon = "acidd.png"
                },
                new Hero
                {
                    Id = 3,
                    Key = "assassin-coli",
                    Name = "Assassin Coli",
                    Icon = "acoli.png"
                },
                new Hero
                {
                    Id = 4,
                    Key = "adin",
                    Name = "Adin",
                    Icon = "adin.png"
                },
                new Hero
                {
                    Id = 5,
                    Key = "adlay",
                    Name = "Adlay",
                    Icon = "adlay.png"
                },
                new Hero
                {
                    Id = 6,
                    Key = "ainos",
                    Name = "Ainos",
                    Icon = "ainos.png"
                },
                new Hero
                {
                    Id = 7,
                    Key = "ains",
                    Name = "Ains",
                    Icon = "ains.png"
                },
                new Hero
                {
                    Id = 8,
                    Key = "aither",
                    Name = "Aither",
                    Icon = "aither.png"
                },
                new Hero
                {
                    Id = 9,
                    Key = "alencia",
                    Name = "Alencia",
                    Icon = "alencia.png"
                },
                new Hero
                {
                    Id = 10,
                    Key = "alexa",
                    Name = "Alexa",
                    Icon = "alexa.png"
                },
                new Hero
                {
                    Id = 11,
                    Key = "auxiliary-lots",
                    Name = "Auxiliary Lots",
                    Icon = "alots.png"
                },
                new Hero
                {
                    Id = 12,
                    Key = "archdemon-mercedes",
                    Name = "Archdemon Mercedes",
                    Icon = "ameru.png"
                },
                new Hero
                {
                    Id = 13,
                    Key = "angelic-montmorancy",
                    Name = "Angelic Montmorancy",
                    Icon = "amomo.png"
                },
                new Hero
                {
                    Id = 14,
                    Key = "angelica",
                    Name = "Angelica",
                    Icon = "angelica.png"
                },
                new Hero
                {
                    Id = 15,
                    Key = "angel-of-light-angelica",
                    Name = "Angel of Light Angelica",
                    Icon = "aola.png"
                },
                new Hero
                {
                    Id = 16,
                    Key = "aramintha",
                    Name = "Aramintha",
                    Icon = "aramintha.png"
                },
                new Hero
                {
                    Id = 17,
                    Key = "adventurer-ras",
                    Name = "Adventurer Ras",
                    Icon = "aras.png"
                },
                new Hero
                {
                    Id = 18,
                    Key = "apocalypse-ravi",
                    Name = "Apocalypse Ravi",
                    Icon = "aravi.png"
                },
                new Hero
                {
                    Id = 19,
                    Key = "arbiter-vildred",
                    Name = "Arbiter Vildred",
                    Icon = "arby.png"
                },
                new Hero
                {
                    Id = 20,
                    Key = "aria",
                    Name = "Aria",
                    Icon = "aria.png"
                },
                new Hero
                {
                    Id = 21,
                    Key = "armin",
                    Name = "Armin",
                    Icon = "armin.png"
                },
                new Hero
                {
                    Id = 22,
                    Key = "arowell",
                    Name = "Arowell",
                    Icon = "arowell.png"
                },
                new Hero
                {
                    Id = 23,
                    Key = "all-rounder-wanda",
                    Name = "All-Rounder Wanda",
                    Icon = "arwanda.png"
                },
                new Hero
                {
                    Id = 24,
                    Key = "assassin-cartuja",
                    Name = "Assassin Cartuja",
                    Icon = "asscart.png"
                },
                new Hero
                {
                    Id = 25,
                    Key = "ambitious-tywin",
                    Name = "Ambitious Tywin",
                    Icon = "atywin.png"
                },
                new Hero
                {
                    Id = 26,
                    Key = "chaos-sect-axe",
                    Name = "Chaos Sect Axe",
                    Icon = "axegod.png"
                },
                new Hero
                {
                    Id = 27,
                    Key = "azalea",
                    Name = "Azalea",
                    Icon = "azalea.png"
                },
                new Hero
                {
                    Id = 28,
                    Key = "baal",
                    Name = "Baal",
                    Icon = "baal.png"
                },
                new Hero
                {
                    Id = 29,
                    Key = "bad-cat-armin",
                    Name = "Bad Cat Armin",
                    Icon = "badcat.png"
                },
                new Hero
                {
                    Id = 30,
                    Key = "baiken",
                    Name = "Baiken",
                    Icon = "baiken.png"
                },
                new Hero
                {
                    Id = 31,
                    Key = "basar",
                    Name = "Basar",
                    Icon = "basar.png"
                },
                new Hero
                {
                    Id = 32,
                    Key = "bask",
                    Name = "Bask",
                    Icon = "bask.png"
                },
                new Hero
                {
                    Id = 33,
                    Key = "batisse",
                    Name = "Batisse",
                    Icon = "batisse.png"
                },
                new Hero
                {
                    Id = 34,
                    Key = "blood-blade-karin",
                    Name = "Blood Blade Karin",
                    Icon = "bbk.png"
                },
                new Hero
                {
                    Id = 35,
                    Key = "butcher-corps-inquisitor",
                    Name = "Butcher Corps Inquisitor",
                    Icon = "bcorpsinquisitor.png"
                },
                new Hero
                {
                    Id = 36,
                    Key = "belian",
                    Name = "Belian",
                    Icon = "belian.png"
                },
                new Hero
                {
                    Id = 37,
                    Key = "bellona",
                    Name = "Bellona",
                    Icon = "bellona.png"
                },
                new Hero
                {
                    Id = 38,
                    Key = "briar-witch-iseria",
                    Name = "Briar Witch Iseria",
                    Icon = "biseria.png"
                },
                new Hero
                {
                    Id = 39,
                    Key = "blood-moon-haste",
                    Name = "Blood Moon Haste",
                    Icon = "bmh.png"
                },
                new Hero
                {
                    Id = 40,
                    Key = "benevolent-romann",
                    Name = "Benevolent Romann",
                    Icon = "bromann.png"
                },
                new Hero
                {
                    Id = 41,
                    Key = "camilla",
                    Name = "Camilla",
                    Icon = "camilla.png"
                },
                new Hero
                {
                    Id = 42,
                    Key = "captain-rikoris",
                    Name = "Captain Rikoris",
                    Icon = "captainrikoris.png"
                },
                new Hero
                {
                    Id = 43,
                    Key = "carmainerose",
                    Name = "Carmainerose",
                    Icon = "carmainerose.png"
                },
                new Hero
                {
                    Id = 44,
                    Key = "crimson-armin",
                    Name = "Crimson Armin",
                    Icon = "carmin.png"
                },
                new Hero
                {
                    Id = 45,
                    Key = "carrot",
                    Name = "Carrot",
                    Icon = "carrot.png"
                },
                new Hero
                {
                    Id = 46,
                    Key = "cartuja",
                    Name = "Cartuja",
                    Icon = "cartuja.png"
                },
                new Hero
                {
                    Id = 47,
                    Key = "closer-charles",
                    Name = "Closer Charles",
                    Icon = "ccharles.png"
                },
                new Hero
                {
                    Id = 48,
                    Key = "challenger-dominiel",
                    Name = "Challenger Dominiel",
                    Icon = "cdom.png"
                },
                new Hero
                {
                    Id = 49,
                    Key = "cecilia",
                    Name = "Cecilia",
                    Icon = "cecilia.png"
                },
                new Hero
                {
                    Id = 50,
                    Key = "celeste",
                    Name = "Celeste",
                    Icon = "celeste.png"
                },
                new Hero
                {
                    Id = 51,
                    Key = "celine",
                    Name = "Celine",
                    Icon = "celine.png"
                },
                new Hero
                {
                    Id = 52,
                    Key = "cerise",
                    Name = "Cerise",
                    Icon = "cerise.png"
                },
                new Hero
                {
                    Id = 53,
                    Key = "cermia",
                    Name = "Cermia",
                    Icon = "cermia.png"
                },
                new Hero
                {
                    Id = 54,
                    Key = "chaos-inquisitor",
                    Name = "Chaos Inquisitor",
                    Icon = "chaosinquisitor.png"
                },
                new Hero
                {
                    Id = 55,
                    Key = "charles",
                    Name = "Charles",
                    Icon = "charles.png"
                },
                new Hero
                {
                    Id = 56,
                    Key = "charlotte",
                    Name = "Charlotte",
                    Icon = "charlotte.png"
                },
                new Hero
                {
                    Id = 57,
                    Key = "chloe",
                    Name = "Chloe",
                    Icon = "chloe.png"
                },
                new Hero
                {
                    Id = 58,
                    Key = "choux",
                    Name = "Choux",
                    Icon = "choux.png"
                },
                new Hero
                {
                    Id = 59,
                    Key = "christy",
                    Name = "Christy",
                    Icon = "christy.png"
                },
                new Hero
                {
                    Id = 60,
                    Key = "church-of-ilryos-axe",
                    Name = "Church of Ilryos Axe",
                    Icon = "churchaxe.png"
                },
                new Hero
                {
                    Id = 61,
                    Key = "cidd",
                    Name = "Cidd",
                    Icon = "cidd.png"
                },
                new Hero
                {
                    Id = 62,
                    Key = "clarissa",
                    Name = "Clarissa",
                    Icon = "clarissa.png"
                },
                new Hero
                {
                    Id = 63,
                    Key = "conquerer-lilias",
                    Name = "Conquerer Lilias",
                    Icon = "clilias.png"
                },
                new Hero
                {
                    Id = 64,
                    Key = "commander-lorina",
                    Name = "Commander Lorina",
                    Icon = "clorina.png"
                },
                new Hero
                {
                    Id = 65,
                    Key = "celestial-mercedes",
                    Name = "Celestial Mercedes",
                    Icon = "cmeru.png"
                },
                new Hero
                {
                    Id = 66,
                    Key = "crescent-moon-rin",
                    Name = "Crescent Moon Rin",
                    Icon = "cmrin.png"
                },
                new Hero
                {
                    Id = 67,
                    Key = "coli",
                    Name = "Coli",
                    Icon = "coli.png"
                },
                new Hero
                {
                    Id = 68,
                    Key = "corvus",
                    Name = "Corvus",
                    Icon = "corvus.png"
                },
                new Hero
                {
                    Id = 69,
                    Key = "crozet",
                    Name = "Crozet",
                    Icon = "crozet.png"
                },
                new Hero
                {
                    Id = 70,
                    Key = "champion-zerato",
                    Name = "Champion Zerato",
                    Icon = "czerato.png"
                },
                new Hero
                {
                    Id = 71,
                    Key = "dark-corvus",
                    Name = "Dark Corvus",
                    Icon = "dcorvus.png"
                },
                new Hero
                {
                    Id = 72,
                    Key = "destina",
                    Name = "Destina",
                    Icon = "destina.png"
                },
                new Hero
                {
                    Id = 73,
                    Key = "diene",
                    Name = "Diene",
                    Icon = "diene.png"
                },
                new Hero
                {
                    Id = 74,
                    Key = "designer-lilibet",
                    Name = "Designer Lilibet",
                    Icon = "dilibet.png"
                },
                new Hero
                {
                    Id = 75,
                    Key = "dingo",
                    Name = "Dingo",
                    Icon = "dingo.png"
                },
                new Hero
                {
                    Id = 76,
                    Key = "dizzy",
                    Name = "Dizzy",
                    Icon = "dizzy.png"
                },
                new Hero
                {
                    Id = 77,
                    Key = "desert-jewel-basar",
                    Name = "Desert Jewel Basar",
                    Icon = "djb.png"
                },
                new Hero
                {
                    Id = 78,
                    Key = "doll-maker-pearlhorizon",
                    Name = "Doll Maker Pearlhorizon",
                    Icon = "dmpearlhorizon.png"
                },
                new Hero
                {
                    Id = 79,
                    Key = "dominiel",
                    Name = "Dominiel",
                    Icon = "dom.png"
                },
                new Hero
                {
                    Id = 80,
                    Key = "doris",
                    Name = "Doris",
                    Icon = "doris.png"
                },
                new Hero
                {
                    Id = 81,
                    Key = "eaton",
                    Name = "Eaton",
                    Icon = "eaton.png"
                },
                new Hero
                {
                    Id = 82,
                    Key = "eda",
                    Name = "Eda",
                    Icon = "eda.png"
                },
                new Hero
                {
                    Id = 83,
                    Key = "elena",
                    Name = "Elena",
                    Icon = "elena.png"
                },
                new Hero
                {
                    Id = 84,
                    Key = "elphelt",
                    Name = "Elphelt",
                    Icon = "elphelt.png"
                },
                new Hero
                {
                    Id = 85,
                    Key = "elson",
                    Name = "Elson",
                    Icon = "elson.png"
                },
                new Hero
                {
                    Id = 86,
                    Key = "emilia",
                    Name = "Emilia",
                    Icon = "emilia.png"
                },
                new Hero
                {
                    Id = 87,
                    Key = "enott",
                    Name = "Enott",
                    Icon = "Enott-icon.png"
                },
                new Hero
                {
                    Id = 88,
                    Key = "ervalen",
                    Name = "Ervalen",
                    Icon = "Ervalen-icon.png"
                },
                new Hero
                {
                    Id = 89,
                    Key = "fairy-tale-tenebria",
                    Name = "Fairytale Tenebria",
                    Icon = "Fairytale-Tenebria-icon.png"
                },
                new Hero
                {
                    Id = 90,
                    Key = "falconer-kluri",
                    Name = "Falconer Kluri",
                    Icon = "Falconer-Kluri-icon.png"
                },
                new Hero
                {
                    Id = 91,
                    Key = "fallen-cecilia",
                    Name = "Fallen Cecilia",
                    Icon = "Fallen-Cecilia-icon.png"
                },
                new Hero
                {
                    Id = 92,
                    Key = "fighter-maya",
                    Name = "Fighter Maya",
                    Icon = "Fighter-Maya-icon.png"
                },
                new Hero
                {
                    Id = 93,
                    Key = "flan",
                    Name = "Flan",
                    Icon = "Flan-icon-1-1.png"
                },
                new Hero
                {
                    Id = 94,
                    Key = "free-spirit-tieria",
                    Name = "Free Spirit Tieria",
                    Icon = "Free-Spirit-Tieria-icon.png"
                },
                new Hero
                {
                    Id = 95,
                    Key = "furious",
                    Name = "Furious",
                    Icon = "Furious-icon.png"
                },
                new Hero
                {
                    Id = 96,
                    Key = "general-purrgis",
                    Name = "General Purrgis",
                    Icon = "General-Purrgis-icon.png"
                },
                new Hero
                {
                    Id = 97,
                    Key = "glenn",
                    Name = "Glenn",
                    Icon = "Glenn-icon-real.png"
                },
                new Hero
                {
                    Id = 98,
                    Key = "gloomyrain",
                    Name = "Gloomyrain",
                    Icon = "Gloomyrain-icon.png"
                },
                new Hero
                {
                    Id = 99,
                    Key = "godmother",
                    Name = "Godmother",
                    Icon = "Godmother-icon-real.png"
                },
                new Hero
                {
                    Id = 100,
                    Key = "great-chief-khawana",
                    Name = "Great Chief Khawana",
                    Icon = "Great-Chief-Khawana-icon.png"
                },
                new Hero
                {
                    Id = 101,
                    Key = "guider-aither",
                    Name = "Guider Aither",
                    Icon = "Guider-Aither-icon.png"
                },
                new Hero
                {
                    Id = 102,
                    Key = "hasol",
                    Name = "Hasol",
                    Icon = "hasol-icon.jpeg"
                },
                new Hero
                {
                    Id = 103,
                    Key = "haste",
                    Name = "Haste",
                    Icon = "Haste-icon.png"
                },
                new Hero
                {
                    Id = 104,
                    Key = "hataan",
                    Name = "Hataan",
                    Icon = "Hataan-icon.png"
                },
                new Hero
                {
                    Id = 105,
                    Key = "hazel",
                    Name = "Hazel",
                    Icon = "Hazel-icon.png"
                },
                new Hero
                {
                    Id = 106,
                    Key = "helen",
                    Name = "Helen",
                    Icon = "Helen-icon.png"
                },
                new Hero
                {
                    Id = 107,
                    Key = "helga",
                    Name = "Helga",
                    Icon = "Helga-icon.png"
                },
                new Hero
                {
                    Id = 108,
                    Key = "holiday-yufine",
                    Name = "Holiday Yufine",
                    Icon = "Holiday-yufine-icon-for-real.png"
                },
                new Hero
                {
                    Id = 109,
                    Key = "holy-flame-adin",
                    Name = "Holy Flame Adin",
                    Icon = "holy-flame-adin-icon.jpeg"
                },
                new Hero
                {
                    Id = 110,
                    Key = "hurado",
                    Name = "Hurado",
                    Icon = "Hurado-icon.png"
                },
                new Hero
                {
                    Id = 111,
                    Key = "hwayoung",
                    Name = "Hwayoung",
                    Icon = "hwayoung-icon.jpeg"
                },
                new Hero
                {
                    Id = 112,
                    Key = "ian",
                    Name = "Ian",
                    Icon = "ian-icon-1.png"
                },
                new Hero
                {
                    Id = 113,
                    Key = "ilynav",
                    Name = "Ilynav",
                    Icon = "Ilynav-icon.png"
                },
                new Hero
                {
                    Id = 114,
                    Key = "inferno-khawazu",
                    Name = "Inferno Khawazu",
                    Icon = "Inferno-Khawazu-icon-actual.png"
                },
                new Hero
                {
                    Id = 115,
                    Key = "iseria",
                    Name = "Iseria",
                    Icon = "Iseria-icon.png"
                },
                new Hero
                {
                    Id = 116,
                    Key = "jack-o",
                    Name = "Jack'O",
                    Icon = "jack-o-icon.jpeg"
                },
                new Hero
                {
                    Id = 117,
                    Key = "januta",
                    Name = "Januta",
                    Icon = "januta-icon.jpeg"
                },
                new Hero
                {
                    Id = 118,
                    Key = "jecht",
                    Name = "Jecht",
                    Icon = "Jecht-icon.png"
                },
                new Hero
                {
                    Id = 119,
                    Key = "jena",
                    Name = "Jena",
                    Icon = "Jena-icon.png"
                },
                new Hero
                {
                    Id = 120,
                    Key = "judge-kise",
                    Name = "Judge Kise",
                    Icon = "Judge-Kise-icon.png"
                },
                new Hero
                {
                    Id = 121,
                    Key = "judith",
                    Name = "Judith",
                    Icon = "Judith-icon.jpeg"
                },
                new Hero
                {
                    Id = 122,
                    Key = "kanna",
                    Name = "Kanna",
                    Icon = "Kanna-icon.png"
                },
                new Hero
                {
                    Id = 123,
                    Key = "karin",
                    Name = "Karin",
                    Icon = "Karin-icon.jpeg"
                },
                new Hero
                {
                    Id = 124,
                    Key = "khawana",
                    Name = "Khawana",
                    Icon = "kawa-3.png"
                },
                new Hero
                {
                    Id = 125,
                    Key = "kawerick",
                    Name = "Kawerick",
                    Icon = "kawerick-2.png"
                },
                new Hero
                {
                    Id = 126,
                    Key = "ken",
                    Name = "Ken",
                    Icon = "Ken-icon.png"
                },
                new Hero
                {
                    Id = 127,
                    Key = "khawazu",
                    Name = "Khawazu",
                    Icon = "khawazu-3.png"
                },
                new Hero
                {
                    Id = 128,
                    Key = "kikirat-v2",
                    Name = "Kikirat V2",
                    Icon = "kikirat-v2-icon.png"
                },
                new Hero
                {
                    Id = 129,
                    Key = "kiris",
                    Name = "Kiris",
                    Icon = "Kiris-icon.jpeg"
                },
                new Hero
                {
                    Id = 130,
                    Key = "kitty-cat-clarissa",
                    Name = "Kitty Cat Clarissa",
                    Icon = "kitty-icon.png"
                },
                new Hero
                {
                    Id = 131,
                    Key = "kizuna-ai",
                    Name = "Kizuna Ai",
                    Icon = "kizuna-ai-icon.jpeg"
                },
                new Hero
                {
                    Id = 132,
                    Key = "krau",
                    Name = "Krau",
                    Icon = "Krau-icon.jpeg"
                },
                new Hero
                {
                    Id = 133,
                    Key = "kluri",
                    Name = "Kluri",
                    Icon = "Kururi-icon.jpeg"
                },
                new Hero
                {
                    Id = 134,
                    Key = "laika",
                    Name = "Laika",
                    Icon = "Laika-icon.png"
                },
                new Hero
                {
                    Id = 135,
                    Key = "landy",
                    Name = "Landy",
                    Icon = "Landy-icon-2.png"
                },
                new Hero
                {
                    Id = 136,
                    Key = "ras",
                    Name = "Ras",
                    Icon = "Las-icon.jpeg"
                },
                new Hero
                {
                    Id = 137,
                    Key = "last-rider-krau",
                    Name = "Last Rider Krau",
                    Icon = "last-rider-krau-icon.jpeg"
                },
                new Hero
                {
                    Id = 138,
                    Key = "lots",
                    Name = "Lots",
                    Icon = "Latz-icon.jpeg"
                },
                new Hero
                {
                    Id = 139,
                    Key = "lena",
                    Name = "Lena",
                    Icon = "lena.jpeg"
                },
                new Hero
                {
                    Id = 140,
                    Key = "leo",
                    Name = "Leo",
                    Icon = "Leo-icon.jpeg"
                },
                new Hero
                {
                    Id = 141,
                    Key = "lidia",
                    Name = "Lidia",
                    Icon = "lidia-face.png"
                },
                new Hero
                {
                    Id = 142,
                    Key = "lilias",
                    Name = "Lilias",
                    Icon = "lilias-icon.jpeg"
                },
                new Hero
                {
                    Id = 143,
                    Key = "lilibet",
                    Name = "Lilibet",
                    Icon = "lilibet-3.png"
                },
                new Hero
                {
                    Id = 144,
                    Key = "lionheart-cermia",
                    Name = "Lionheart Cermia",
                    Icon = "lionheart-cermia-icon.jpeg"
                },
                new Hero
                {
                    Id = 145,
                    Key = "little-queen-charlotte",
                    Name = "Little Queen Charlotte",
                    Icon = "Little-Queen-Charlotte-icon.png"
                },
                new Hero
                {
                    Id = 146,
                    Key = "roana",
                    Name = "Roana",
                    Icon = "roana.png"
                },
                new Hero
                {
                    Id = 147,
                    Key = "lorina",
                    Name = "Lorina",
                    Icon = "Lorina-icon.jpeg"
                },
                new Hero
                {
                    Id = 148,
                    Key = "lucy",
                    Name = "Lucy",
                    Icon = "Lucy-icon.png"
                },
                new Hero
                {
                    Id = 149,
                    Key = "ludwig",
                    Name = "Ludwig",
                    Icon = "Ludwig-icon.jpeg"
                },
                new Hero
                {
                    Id = 150,
                    Key = "luluca",
                    Name = "Luluca",
                    Icon = "luluca-icon.png"
                },
                new Hero
                {
                    Id = 151,
                    Key = "luna",
                    Name = "Luna",
                    Icon = "Luna-icon.jpeg"
                },
                new Hero
                {
                    Id = 152,
                    Key = "magic-scholar-doris",
                    Name = "Magic Scholar Doris",
                    Icon = "Magic-Scholar-Doris-icon-1.png"
                },
                new Hero
                {
                    Id = 153,
                    Key = "mascot-hazel",
                    Name = "Mascot Hazel",
                    Icon = "mascot.png"
                },
                new Hero
                {
                    Id = 154,
                    Key = "maya",
                    Name = "Maya",
                    Icon = "Maya-icon.png"
                },
                new Hero
                {
                    Id = 155,
                    Key = "mediator-kawerick",
                    Name = "Mediator Kawerick",
                    Icon = "Mediator-Kawerick-icon.png"
                },
                new Hero
                {
                    Id = 156,
                    Key = "melany",
                    Name = "Melany",
                    Icon = "Melany-icon.png"
                },
                new Hero
                {
                    Id = 157,
                    Key = "melissa",
                    Name = "Melissa",
                    Icon = "melissa-icon.jpeg"
                },
                new Hero
                {
                    Id = 158,
                    Key = "mercedes",
                    Name = "Mercedes",
                    Icon = "Mercedes-icon.png"
                },
                new Hero
                {
                    Id = 159,
                    Key = "mercenary-helga",
                    Name = "Mercenary Helga",
                    Icon = "mercenary-helga-face.png"
                },
                new Hero
                {
                    Id = 160,
                    Key = "milim",
                    Name = "Milim",
                    Icon = "Milim-icon.png"
                },
                new Hero
                {
                    Id = 161,
                    Key = "mirsa",
                    Name = "Mirsa",
                    Icon = "Mirsa-icon.jpeg"
                },
                new Hero
                {
                    Id = 162,
                    Key = "mistychain",
                    Name = "Mistychain",
                    Icon = "Mistychain-icon.jpeg"
                },
                new Hero
                {
                    Id = 163,
                    Key = "silver-blade-aramintha",
                    Name = "Silver Blade Aramintha",
                    Icon = "ml-aramintha-icon.png"
                },
                new Hero
                {
                    Id = 164,
                    Key = "martial-artist-ken",
                    Name = "Martial Artist Ken",
                    Icon = "mlken.jpeg"
                },
                new Hero
                {
                    Id = 165,
                    Key = "montmorancy",
                    Name = "Montmorancy",
                    Icon = "Montmorancy-Icon.png"
                },
                new Hero
                {
                    Id = 166,
                    Key = "mort",
                    Name = "Mort",
                    Icon = "Mort-icon.png"
                },
                new Hero
                {
                    Id = 167,
                    Key = "mucacha",
                    Name = "Mucacha",
                    Icon = "Mucacha-icon.jpeg"
                },
                new Hero
                {
                    Id = 168,
                    Key = "mui",
                    Name = "Mui",
                    Icon = "mui-face.png"
                },
                new Hero
                {
                    Id = 169,
                    Key = "muse-rima",
                    Name = "Muse Rima",
                    Icon = "Muse-Rima-icon.png"
                },
                new Hero
                {
                    Id = 170,
                    Key = "muwi",
                    Name = "Muwi",
                    Icon = "muwi-icon.jpeg"
                },
                new Hero
                {
                    Id = 171,
                    Key = "nemunas",
                    Name = "Nemunas",
                    Icon = "Nemunas-icon.jpeg"
                },
                new Hero
                {
                    Id = 172,
                    Key = "operator-sigret",
                    Name = "Operator Sigret",
                    Icon = "Operator-Sigret-icon.png"
                },
                new Hero
                {
                    Id = 173,
                    Key = "orte",
                    Name = "Orte",
                    Icon = "orte-icon.jpeg"
                },
                new Hero
                {
                    Id = 174,
                    Key = "otillie",
                    Name = "Otillie",
                    Icon = "Otillie-icon.jpeg"
                },
                new Hero
                {
                    Id = 175,
                    Key = "pavel",
                    Name = "Pavel",
                    Icon = "pavel-1.png"
                },
                new Hero
                {
                    Id = 176,
                    Key = "pearlhorizon",
                    Name = "Pearlhorizon",
                    Icon = "Pearlhorizon-icon.png"
                },
                new Hero
                {
                    Id = 177,
                    Key = "peira",
                    Name = "Peira",
                    Icon = "peira-icon.jpeg"
                },
                new Hero
                {
                    Id = 178,
                    Key = "penelope",
                    Name = "Penelope",
                    Icon = "Penelope-icon.png"
                },
                new Hero
                {
                    Id = 179,
                    Key = "pirate-captain-flan",
                    Name = "Pirate Captain Flan",
                    Icon = "pirate-captain-flan-icon.jpeg"
                },
                new Hero
                {
                    Id = 180,
                    Key = "politis",
                    Name = "Politis",
                    Icon = "Politis-icon.png"
                },
                new Hero
                {
                    Id = 181,
                    Key = "purrgis",
                    Name = "Purrgis",
                    Icon = "Purrgis-icon.jpeg"
                },
                new Hero
                {
                    Id = 182,
                    Key = "pyllis",
                    Name = "Pyllis",
                    Icon = "Pyllis-icon.jpeg"
                },
                new Hero
                {
                    Id = 183,
                    Key = "blaze-dingo",
                    Name = "Blaze Dingo",
                    Icon = "blaze-dingo.png"
                },
                new Hero
                {
                    Id = 184,
                    Key = "ravi",
                    Name = "Ravi",
                    Icon = "Raci-icon.jpeg"
                },
                new Hero
                {
                    Id = 185,
                    Key = "ram",
                    Name = "Ram",
                    Icon = "Ram-icon.png"
                },
                new Hero
                {
                    Id = 186,
                    Key = "ran",
                    Name = "Ran",
                    Icon = "Ran-icon.png"
                },
                new Hero
                {
                    Id = 187,
                    Key = "ray",
                    Name = "Ray",
                    Icon = "Ray-icon.png"
                },
                new Hero
                {
                    Id = 188,
                    Key = "rem",
                    Name = "Rem",
                    Icon = "Rem.png"
                },
                new Hero
                {
                    Id = 189,
                    Key = "remnant-violet",
                    Name = "Remnant Violet",
                    Icon = "remnant-violet-icon.jpeg"
                },
                new Hero
                {
                    Id = 190,
                    Key = "requiemroar",
                    Name = "Requiemroar",
                    Icon = "Requiemroar-icon.jpeg"
                },
                new Hero
                {
                    Id = 191,
                    Key = "researcher-carrot",
                    Name = "Researcher Carrot",
                    Icon = "researcher-carrot-icon.jpeg"
                },
                new Hero
                {
                    Id = 192,
                    Key = "rikoris",
                    Name = "Rikoris",
                    Icon = "Rikoris-icon.jpeg"
                },
                new Hero
                {
                    Id = 193,
                    Key = "rima",
                    Name = "Rima",
                    Icon = "Rima-icon.jpeg"
                },
                new Hero
                {
                    Id = 194,
                    Key = "rimuru",
                    Name = "Rimuru",
                    Icon = "Rimuru-icon.png"
                },
                new Hero
                {
                    Id = 195,
                    Key = "rin",
                    Name = "Rin",
                    Icon = "Rin-icon.jpeg"
                },
                new Hero
                {
                    Id = 196,
                    Key = "romann",
                    Name = "Romann",
                    Icon = "Romann-icon.jpeg"
                },
                new Hero
                {
                    Id = 197,
                    Key = "roozid",
                    Name = "Roozid",
                    Icon = "Roozid-icon.jpeg"
                },
                new Hero
                {
                    Id = 198,
                    Key = "rose",
                    Name = "Rose",
                    Icon = "Rose-icon.jpeg"
                },
                new Hero
                {
                    Id = 199,
                    Key = "ruele-of-light",
                    Name = "Ruele of Light",
                    Icon = "Ruele-of-Light-icon.jpeg"
                },
                new Hero
                {
                    Id = 200,
                    Key = "sage-baal-and-sezan",
                    Name = "Sage Baal and Sezan",
                    Icon = "Sage-Baal-Sezan-icon.png"
                },
                new Hero
                {
                    Id = 201,
                    Key = "schuri",
                    Name = "Schuri",
                    Icon = "Schuri-icon.jpeg"
                },
                new Hero
                {
                    Id = 202,
                    Key = "maid-chloe",
                    Name = "Maid Chloe",
                    Icon = "maid-chloe.png"
                },
                new Hero
                {
                    Id = 203,
                    Key = "kise",
                    Name = "Kise",
                    Icon = "kise.png"
                },
                new Hero
                {
                    Id = 204,
                    Key = "kayron",
                    Name = "Kayron",
                    Icon = "kayron.png"
                },
                new Hero
                {
                    Id = 205,
                    Key = "seaside-bellona",
                    Name = "Seaside Bellona",
                    Icon = "seaside-bellona-icon.jpeg"
                },
                new Hero
                {
                    Id = 206,
                    Key = "sigret",
                    Name = "Sigret",
                    Icon = "Sekret-icons.jpeg"
                },
                new Hero
                {
                    Id = 207,
                    Key = "senya",
                    Name = "Senya",
                    Icon = "Senya-icon.png"
                },
                new Hero
                {
                    Id = 208,
                    Key = "serila",
                    Name = "Serila",
                    Icon = "Serila-icon.jpeg"
                },
                new Hero
                {
                    Id = 209,
                    Key = "sez",
                    Name = "Sez",
                    Icon = "Sez-icon.jpeg"
                },
                new Hero
                {
                    Id = 210,
                    Key = "shadow-knight-pyllis",
                    Name = "Shadow Knight Pyllis",
                    Icon = "Shadow-Knight-Pyllis-icon.png"
                },
                new Hero
                {
                    Id = 211,
                    Key = "shadow-rose",
                    Name = "Shadow Rose",
                    Icon = "Shadow-Rose-icon.jpeg"
                },
                new Hero
                {
                    Id = 212,
                    Key = "shooting-star-achates",
                    Name = "Shooting Star Achates",
                    Icon = "Shooting-Star-Achates.jpeg"
                },
                new Hero
                {
                    Id = 213,
                    Key = "shuna",
                    Name = "Shuna",
                    Icon = "Shuna-icon.png"
                },
                new Hero
                {
                    Id = 214,
                    Key = "silk",
                    Name = "Silk",
                    Icon = "Silk-icon.jpeg"
                },
                new Hero
                {
                    Id = 215,
                    Key = "sinful-angelica",
                    Name = "Sinful Angelica",
                    Icon = "singelica.png"
                },
                new Hero
                {
                    Id = 216,
                    Key = "sol-badguy",
                    Name = "Sol Badguy",
                    Icon = "sol-3.png"
                },
                new Hero
                {
                    Id = 217,
                    Key = "solitaria",
                    Name = "Solitaria",
                    Icon = "Solitaria-icon.png"
                },
                new Hero
                {
                    Id = 218,
                    Key = "sonia",
                    Name = "Sonia",
                    Icon = "Sonia-icon.png"
                },
                new Hero
                {
                    Id = 219,
                    Key = "specimen-sez",
                    Name = "Specimen Sez",
                    Icon = "specimen-sez.jpeg"
                },
                new Hero
                {
                    Id = 220,
                    Key = "spirit-eye-celine",
                    Name = "Spirit Eye Celine",
                    Icon = "Spirit-Eye-Celine-icon.png"
                },
                new Hero
                {
                    Id = 221,
                    Key = "straze",
                    Name = "Staze",
                    Icon = "Straze-icon.png"
                },
                new Hero
                {
                    Id = 222,
                    Key = "summertime-iseria",
                    Name = "Summertime Iseria",
                    Icon = "Summertime-Iseria-icon.png"
                },
                new Hero
                {
                    Id = 223,
                    Key = "support-model-brinus",
                    Name = "Support Model Brinus",
                    Icon = "Support-Model-Brinus-icon.png"
                },
                new Hero
                {
                    Id = 224,
                    Key = "surin",
                    Name = "Surin",
                    Icon = "Surin-icon.jpeg"
                },
                new Hero
                {
                    Id = 225,
                    Key = "sven",
                    Name = "Sven",
                    Icon = "Sven-icon.jpeg"
                },
                new Hero
                {
                    Id = 226,
                    Key = "taeyou",
                    Name = "Taeyou",
                    Icon = "taeyou-icon.jpeg"
                },
                new Hero
                {
                    Id = 227,
                    Key = "tamarinne",
                    Name = "Tamarinne",
                    Icon = "tammarine-face.png"
                },
                new Hero
                {
                    Id = 228,
                    Key = "taranor-guard",
                    Name = "Taranor Guard",
                    Icon = "taranor-guard-icon.png"
                },
                new Hero
                {
                    Id = 229,
                    Key = "taranor-royal-guard",
                    Name = "Taranor Royal Guard",
                    Icon = "taranor-royal-guard-icon.png"
                },
                new Hero
                {
                    Id = 230,
                    Key = "tempest-surin",
                    Name = "Tempest Surin",
                    Icon = "Tempest-Surin-icon.png"
                },
                new Hero
                {
                    Id = 231,
                    Key = "tenebria",
                    Name = "Tenebria",
                    Icon = "Tenebria-icon.jpeg"
                },
                new Hero
                {
                    Id = 232,
                    Key = "righteous-theif-roozid",
                    Name = "Righteous Thief Roozid",
                    Icon = "thief-roozid.png"
                },
                new Hero
                {
                    Id = 233,
                    Key = "tieria",
                    Name = "Tieria",
                    Icon = "Tieria-icon.jpeg"
                },
                new Hero
                {
                    Id = 234,
                    Key = "top-model-luluca",
                    Name = "Top Model Luluca",
                    Icon = "top-model-luluca.jpeg"
                },
                new Hero
                {
                    Id = 235,
                    Key = "troublemaker-crozet",
                    Name = "Troublemaker Crozet",
                    Icon = "troublemaker-crozet-icon.jpeg"
                },
                new Hero
                {
                    Id = 236,
                    Key = "tywin",
                    Name = "Tywin",
                    Icon = "Tywin-icon.jpeg"
                },
                new Hero
                {
                    Id = 237,
                    Key = "verdant-adin",
                    Name = "Verdant Adin",
                    Icon = "verdant-adin-icon.jpeg"
                },
                new Hero
                {
                    Id = 238,
                    Key = "vigilante-leader-glenn",
                    Name = "Vigilante Leader Glenn",
                    Icon = "vigilante-leader-glenn.jpeg"
                },
                new Hero
                {
                    Id = 239,
                    Key = "vildred",
                    Name = "Vildred",
                    Icon = "Vildred-icon.jpeg"
                },
                new Hero
                {
                    Id = 240,
                    Key = "violet",
                    Name = "Violet",
                    Icon = "Violet-icon.png"
                },
                new Hero
                {
                    Id = 241,
                    Key = "specter-tenebria",
                    Name = "Specter Tenebria",
                    Icon = "Visionary-Tenebria.jpeg"
                },
                new Hero
                {
                    Id = 242,
                    Key = "vivian",
                    Name = "Vivian",
                    Icon = "vivian_1.png"
                },
                new Hero
                {
                    Id = 243,
                    Key = "wanda",
                    Name = "Wanda",
                    Icon = "Wanda-icon.jpeg"
                },
                new Hero
                {
                    Id = 244,
                    Key = "wanderer-silk",
                    Name = "Wanderer-Silk-icon",
                    Icon = "Wanderer-Silk-icon.jpeg"
                },
                new Hero
                {
                    Id = 245,
                    Key = "roaming-warrior-leo",
                    Name = "Roaming Warrior Leo",
                    Icon = "warrior-leo.jpeg"
                },
                new Hero
                {
                    Id = 246,
                    Key = "watcher-schuri",
                    Name = "Watcher Schuri",
                    Icon = "watcherschuri.jpeg"
                },
                new Hero
                {
                    Id = 247,
                    Key = "yoonryoung",
                    Name = "Yoonryoung",
                    Icon = "yoonryoung-icon.jpeg"
                },
                new Hero
                {
                    Id = 248,
                    Key = "yufine",
                    Name = "Yufine",
                    Icon = "Yufine-icon.jpeg"
                },
                new Hero
                {
                    Id = 249,
                    Key = "yulha",
                    Name = "Yulha",
                    Icon = "yulha-icon.jpeg"
                },
                new Hero
                {
                    Id = 250,
                    Key = "yuna",
                    Name = "Yuna",
                    Icon = "Yuna-icon.jpeg"
                },
                new Hero
                {
                    Id = 251,
                    Key = "zahhak",
                    Name = "Zahhak",
                    Icon = "Zahhak-icon-real.png"
                },
                new Hero
                {
                    Id = 252,
                    Key = "zealot-carmainerose",
                    Name = "Zealot Carmainerose",
                    Icon = "Zealot-Carmainerose-icon.png"
                },
                new Hero
                {
                    Id = 253,
                    Key = "zeno",
                    Name = "Zeno",
                    Icon = "zeno.jpeg"
                },
                new Hero
                {
                    Id = 254,
                    Key = "zerato",
                    Name = "Zerato",
                    Icon = "Zerato-icon.jpeg"
                },
                new Hero
                {
                    Id = 255,
                    Key = "faithless-lidica",
                    Name = "Faithless Lidica",
                    Icon = "Faithless-Lidica-icon.png"
                },
                new Hero
                {
                    Id = 256,
                    Key = "gunther",
                    Name = "Gunther",
                    Icon = "Gunther-icon.png"
                }
            );
        }
    }
}

