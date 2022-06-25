using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E7GuildWarRecorder.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Icon = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hero", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Result = table.Column<string>(type: "VARCHAR(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Offense1Id = table.Column<int>(type: "int", nullable: true),
                    Offense2Id = table.Column<int>(type: "int", nullable: true),
                    Offense3Id = table.Column<int>(type: "int", nullable: true),
                    Defense1Id = table.Column<int>(type: "int", nullable: true),
                    Defense2Id = table.Column<int>(type: "int", nullable: true),
                    Defense3Id = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Match_hero_Defense1Id",
                        column: x => x.Defense1Id,
                        principalTable: "hero",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Match_hero_Defense2Id",
                        column: x => x.Defense2Id,
                        principalTable: "hero",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Match_hero_Defense3Id",
                        column: x => x.Defense3Id,
                        principalTable: "hero",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Match_hero_Offense1Id",
                        column: x => x.Offense1Id,
                        principalTable: "hero",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Match_hero_Offense2Id",
                        column: x => x.Offense2Id,
                        principalTable: "hero",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Match_hero_Offense3Id",
                        column: x => x.Offense3Id,
                        principalTable: "hero",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "hero",
                columns: new[] { "Id", "Icon", "Key", "Name" },
                values: new object[,]
                {
                    { 1, "achates.png", "achates", "Achates" },
                    { 2, "acidd.png", "assassin-cidd", "Assassin Cidd" },
                    { 3, "acoli.png", "assassin-coli", "Assassin Coli" },
                    { 4, "adin.png", "adin", "Adin" },
                    { 5, "adlay.png", "adlay", "Adlay" },
                    { 6, "ainos.png", "ainos", "Ainos" },
                    { 7, "ains.png", "ains", "Ains" },
                    { 8, "aither.png", "aither", "Aither" },
                    { 9, "alenica.png", "alencia", "Alencia" },
                    { 10, "alexa.png", "alexa", "Alexa" },
                    { 11, "alots.png", "auxiliary-lots", "Auxiliary Lots" },
                    { 12, "ameru.png", "archdemon-mercedes", "Archdemon Mercedes" },
                    { 13, "amomo.png", "angelic-montmorancy", "Angelic Montmorancy" },
                    { 14, "angelica.png", "angelica", "Angelica" },
                    { 15, "aola.png", "angel-of-light-angelica", "Angel of Light Angelica" },
                    { 16, "aramintha.png", "aramintha", "Aramintha" },
                    { 17, "aras.png", "adventurer-ras", "Adventurer Ras" },
                    { 18, "aravi.png", "apocalypse-ravi", "Apocalypse Ravi" },
                    { 19, "arby.png", "arbiter-vildred", "Arbiter Vildred" },
                    { 20, "aria.png", "aria", "Aria" },
                    { 21, "armin.png", "armin", "Armin" },
                    { 22, "arowell.png", "arowell", "Arowell" },
                    { 23, "arwanda.png", "all-rounder-wanda", "All-Rounder Wanda" },
                    { 24, "asscart.png", "assassin-cartuja", "Assassin Cartuja" },
                    { 25, "atywin.png", "ambitious-tywin", "Ambitious Tywin" },
                    { 26, "axegod.png", "chaos-sect-axe", "Chaos Sect Axe" },
                    { 27, "azalea.png", "azalea", "Azalea" },
                    { 28, "baal.png", "baal", "Baal" },
                    { 29, "badcat.png", "bad-cat-armin", "Bad Cat Armin" },
                    { 30, "baiken.png", "baiken", "Baiken" },
                    { 31, "basar.png", "basar", "Basar" },
                    { 32, "bask.png", "bask", "Bask" },
                    { 33, "batisse.png", "batisse", "Batisse" },
                    { 34, "bbk.png", "blood-blade-karin", "Blood Blade Karin" },
                    { 35, "bcorpsinquisitor.png", "butcher-corps-inquisitor", "Butcher Corps Inquisitor" },
                    { 36, "belian.png", "belian", "Belian" },
                    { 37, "bellona.png", "bellona", "Bellona" },
                    { 38, "biseria.png", "briar-witch-iseria", "Briar Witch Iseria" },
                    { 39, "bmh.png", "blood-moon-haste", "Blood Moon Haste" },
                    { 40, "bromann.png", "benevolent-romann", "Benevolent Romann" },
                    { 41, "camilla.png", "camilla", "Camilla" },
                    { 42, "captainrikoris.png", "captain-rikoris", "Captain Rikoris" },
                    { 43, "carmainerose.png", "carmainerose", "Carmainerose" },
                    { 44, "carmin.png", "crimson-armin", "Crimson Armin" },
                    { 45, "carrot.png", "carrot", "Carrot" },
                    { 46, "cartuja.png", "cartuja", "Cartuja" },
                    { 47, "ccharles.png", "closer-charles", "Closer Charles" },
                    { 48, "cdom.png", "challenger-dominiel", "Challenger Dominiel" },
                    { 49, "cecilia.png", "cecilia", "Cecilia" },
                    { 50, "celeste.png", "celeste", "Celeste" },
                    { 51, "celine.png", "celine", "Celine" },
                    { 52, "cerise.png", "cerise", "Cerise" },
                    { 53, "cermia.png", "cermia", "Cermia" },
                    { 54, "chaosinquisitor.png", "chaos-inquisitor", "Chaos Inquisitor" },
                    { 55, "charles.png", "charles", "Charles" },
                    { 56, "charlotte.png", "charlotte", "Charlotte" },
                    { 57, "chloe.png", "chloe", "Chloe" },
                    { 58, "choux.png", "choux", "Choux" },
                    { 59, "christy.png", "christy", "Christy" },
                    { 60, "churchaxe.png", "church-of-ilryos-axe", "Church of Ilryos Axe" },
                    { 61, "cidd.png", "cidd", "Cidd" },
                    { 62, "clarissa.png", "clarissa", "Clarissa" },
                    { 63, "clilias.png", "conquerer-lilias", "Conquerer Lilias" },
                    { 64, "clorina.png", "commander-lorina", "Commander Lorina" },
                    { 65, "cmeru.png", "celestial-mercedes", "Celestial Mercedes" },
                    { 66, "cmrin.png", "crescent-moon-rin", "Crescent Moon Rin" },
                    { 67, "coli.png", "coli", "Coli" },
                    { 68, "corvus.png", "corvus", "Corvus" },
                    { 69, "crozet.png", "crozet", "Crozet" },
                    { 70, "czerato.png", "champion-zerato", "Champion Zerato" },
                    { 71, "dcorvus.png", "dark-corvus", "Dark Corvus" },
                    { 72, "destina.png", "destina", "Destina" },
                    { 73, "diene.png", "diene", "Diene" },
                    { 74, "dilibet.png", "designer-lilibet", "Designer Lilibet" },
                    { 75, "dingo.png", "dingo", "Dingo" },
                    { 76, "dizzy.png", "dizzy", "Dizzy" },
                    { 77, "djb.png", "desert-jewel-basar", "Desert Jewel Basar" },
                    { 78, "dmpearlhorizon.png", "doll-maker-pearlhorizon", "Doll Maker Pearlhorizon" },
                    { 79, "dom.png", "dominiel", "Dominiel" },
                    { 80, "doris.png", "doris", "Doris" },
                    { 81, "eaton.png", "eaton", "Eaton" },
                    { 82, "eda.png", "eda", "Eda" },
                    { 83, "elena.png", "elena", "Elena" },
                    { 84, "elphelt.png", "elphelt", "Elphelt" },
                    { 85, "elson.png", "elson", "Elson" },
                    { 86, "emilia.png", "emilia", "Emilia" },
                    { 87, "Enott-icon.png", "enott", "Enott" },
                    { 88, "Ervalen-icon.png", "ervalen", "Ervalen" },
                    { 89, "Fairytale-Tenebria-icon.png", "fairy-tale-tenebria", "Fairytale Tenebria" },
                    { 90, "Falconer-Kluri-icon.png", "falconer-kluri", "Falconer Kluri" },
                    { 91, "Fallen-Cecilia-icon.png", "fallen-cecilia", "Fallen Cecilia" },
                    { 92, "Fighter-Maya-icon.png", "fighter-maya", "Fighter Maya" },
                    { 93, "Flan-icon-1-1.png", "flan", "Flan" },
                    { 94, "Free-Spirit-Tieria-icon.png", "free-spirit-tieria", "Free Spirit Tieria" },
                    { 95, "Furious-icon.png", "furious", "Furious" },
                    { 96, "General-Purrgis-icon.png", "general-purrgis", "General Purrgis" },
                    { 97, "Glenn-icon-real.png", "glenn", "Glenn" },
                    { 98, "Gloomyrain-icon.png", "gloomyrain", "Gloomyrain" },
                    { 99, "Godmother-icon-real.png", "godmother", "Godmother" },
                    { 100, "Great-Chief-Khawana-icon.png", "great-chief-khawana", "Great Chief Khawana" },
                    { 101, "Guider-Aither-icon.png", "guider-aither", "Guider Aither" },
                    { 102, "hasol-icon.jpeg", "hasol", "Hasol" },
                    { 103, "Haste-icon.png", "haste", "Haste" },
                    { 104, "Hataan-icon.png", "hataan", "Hataan" },
                    { 105, "Hazel-icon.png", "hazel", "Hazel" },
                    { 106, "Helen-icon.png", "helen", "Helen" },
                    { 107, "Helga-icon.png", "helga", "Helga" },
                    { 108, "Holiday-yufine-icon-for-real.png", "holiday-yufine", "Holiday Yufine" },
                    { 109, "holy-flame-adin-icon.jpeg", "holy-flame-adin", "Holy Flame Adin" },
                    { 110, "Hurado-icon.png", "hurado", "Hurado" },
                    { 111, "hwayoung-icon.jpeg", "hwayoung", "Hwayoung" },
                    { 112, "ian-icon-1.png", "ian", "Ian" },
                    { 113, "Ilynav-icon.png", "ilynav", "Ilynav" },
                    { 114, "Inferno-Khawazu-icon-actual.png", "inferno-khawazu", "Inferno Khawazu" },
                    { 115, "Iseria-icon.png", "iseria", "Iseria" },
                    { 116, "jack-o-icon.jpeg", "jack-o", "Jack'O" },
                    { 117, "januta-icon.jpeg", "januta", "Januta" },
                    { 118, "Jecht-icon.png", "jecht", "Jecht" },
                    { 119, "Jena-icon.png", "jena", "Jena" },
                    { 120, "Judge-Kise-icon.png", "judge-kise", "Judge Kise" },
                    { 121, "Judith-icon.jpeg", "judith", "Judith" },
                    { 122, "Kanna-icon.png", "kanna", "Kanna" },
                    { 123, "Karin-icon.jpeg", "karin", "Karin" },
                    { 124, "kawa-3.png", "khawana", "Khawana" },
                    { 125, "kawerick-2.png", "kawerick", "Kawerick" },
                    { 126, "Ken-icon.png", "ken", "Ken" },
                    { 127, "khawazu-3.png", "khawazu", "Khawazu" },
                    { 128, "kikirat-v2-icon.png", "kikirat-v2", "Kikirat V2" },
                    { 129, "Kiris-icon.jpeg", "kiris", "Kiris" },
                    { 130, "kitty-icon.png", "kitty-cat-clarissa", "Kitty Cat Clarissa" },
                    { 131, "kizuna-ai-icon.jpeg", "kizuna-ai", "Kizuna Ai" },
                    { 132, "Krau-icon.jpeg", "krau", "Krau" },
                    { 133, "Kururi-icon.jpeg", "kluri", "Kluri" },
                    { 134, "Laika-icon.png", "laika", "Laika" },
                    { 135, "Landy-icon-2.png", "landy", "Landy" },
                    { 136, "Las-icon.jpeg", "ras", "Ras" },
                    { 137, "last-rider-krau-icon.jpeg", "last-rider-krau", "Last Rider Krau" },
                    { 138, "Latz-icon.jpeg", "lots", "Lots" },
                    { 139, "lena.jpeg", "lena", "Lena" },
                    { 140, "Leo-icon.jpeg", "leo", "Leo" },
                    { 141, "lidia-face.png", "lidia", "Lidia" },
                    { 142, "lilias-icon.jpeg", "lilias", "Lilias" },
                    { 143, "lilibet-3.png", "lilibet", "Lilibet" },
                    { 144, "lionheart-cermia-icon.jpeg", "lionheart-cermia", "Lionheart Cermia" },
                    { 145, "Little-Queen-Charlotte-icon.png", "little-queen-charlotte", "Little Queen Charlotte" },
                    { 146, "roana.png", "roana", "Roana" },
                    { 147, "Lorina-icon.jpeg", "lorina", "Lorina" },
                    { 148, "Lucy-icon.png", "lucy", "Lucy" },
                    { 149, "Ludwig-icon.jpeg", "ludwig", "Ludwig" },
                    { 150, "luluca-icon.png", "luluca", "Luluca" },
                    { 151, "Luna-icon.jpeg", "luna", "Luna" },
                    { 152, "Magic-Scholar-Doris-icon-1.png", "magic-scholar-doris", "Magic Scholar Doris" },
                    { 153, "mascot.png", "mascot-hazel", "Mascot Hazel" },
                    { 154, "Maya-icon.png", "maya", "Maya" },
                    { 155, "Mediator-Kawerick-icon.png", "mediator-kawerick", "Mediator Kawerick" },
                    { 156, "Melany-icon.png", "melany", "Melany" },
                    { 157, "melissa-icon.jpeg", "melissa", "Melissa" },
                    { 158, "Mercedes-icon.png", "mercedes", "Mercedes" },
                    { 159, "mercenary-helga-face.png", "mercenary-helga", "Mercenary Helga" },
                    { 160, "Milim-icon.png", "milim", "Milim" },
                    { 161, "Mirsa-icon.jpeg", "mirsa", "Mirsa" },
                    { 162, "Mistychain-icon.jpeg", "mistychain", "Mistychain" },
                    { 163, "ml-aramintha-icon.png", "silver-blade-aramintha", "Silver Blade Aramintha" },
                    { 164, "mlken.jpeg", "martial-artist-ken", "Martial Artist Ken" },
                    { 165, "Montmorancy-Icon.png", "montmorancy", "Montmorancy" },
                    { 166, "Mort-icon.png", "mort", "Mort" },
                    { 167, "Mucacha-icon.jpeg", "mucacha", "Mucacha" },
                    { 168, "mui-face.png", "mui", "Mui" },
                    { 169, "Muse-Rima-icon.png", "muse-rima", "Muse Rima" },
                    { 170, "muwi-icon.jpeg", "muwi", "Muwi" },
                    { 171, "Nemunas-icon.jpeg", "nemunas", "Nemunas" },
                    { 172, "Operator-Sigret-icon.png", "operator-sigret", "Operator Sigret" },
                    { 173, "orte-icon.jpeg", "orte", "Orte" },
                    { 174, "Otillie-icon.jpeg", "otillie", "Otillie" },
                    { 175, "pavel-1.png", "pavel", "Pavel" },
                    { 176, "Pearlhorizon-icon.png", "pearlhorizon", "Pearlhorizon" },
                    { 177, "peira-icon.jpeg", "peira", "Peira" },
                    { 178, "Penelope-icon.png", "penelope", "Penelope" },
                    { 179, "pirate-captain-flan-icon.jpeg", "pirate-captain-flan", "Pirate Captain Flan" },
                    { 180, "Politis-icon.png", "politis", "Politis" },
                    { 181, "Purrgis-icon.jpeg", "purrgis", "Purrgis" },
                    { 182, "Pyllis-icon.jpeg", "pyllis", "Pyllis" },
                    { 183, "blaze-dingo.png", "blaze-dingo", "Blaze Dingo" },
                    { 184, "Raci-icon.jpeg", "ravi", "Ravi" },
                    { 185, "Ram-icon.png", "ram", "Ram" },
                    { 186, "Ran-icon.png", "ran", "Ran" },
                    { 187, "Ray-icon.png", "ray", "Ray" },
                    { 188, "Rem.png", "rem", "Rem" },
                    { 189, "remnant-violet-icon.jpeg", "remnant-violet", "Remnant Violet" },
                    { 190, "Requiemroar-icon.jpeg", "requiemroar", "Requiemroar" },
                    { 191, "researcher-carrot-icon.jpeg", "researcher-carrot", "Researcher Carrot" },
                    { 192, "Rikoris-icon.jpeg", "rikoris", "Rikoris" },
                    { 193, "Rima-icon.jpeg", "rima", "Rima" },
                    { 194, "Rimuru-icon.png", "rimuru", "Rimuru" },
                    { 195, "Rin-icon.jpeg", "rin", "Rin" },
                    { 196, "Romann-icon.jpeg", "romann", "Romann" },
                    { 197, "Roozid-icon.jpeg", "roozid", "Roozid" },
                    { 198, "Rose-icon.jpeg", "rose", "Rose" },
                    { 199, "Ruele-of-Light-icon.jpeg", "ruele-of-light", "Ruele of Light" },
                    { 200, "Sage-Baal-Sezan-icon.png", "sage-baal-and-sezan", "Sage Baal and Sezan" },
                    { 201, "Schuri-icon.jpeg", "schuri", "Schuri" },
                    { 202, "maid-chloe.png", "maid-chloe", "Maid Chloe" },
                    { 203, "kise.png", "kise", "Kise" },
                    { 204, "kayron.png", "kayron", "Kayron" },
                    { 205, "seaside-bellona-icon.jpeg", "seaside-bellona", "Seaside Bellona" },
                    { 206, "Sekret-icons.jpeg", "sigret", "Sigret" },
                    { 207, "Senya-icon.png", "senya", "Senya" },
                    { 208, "Serila-icon.jpeg", "serila", "Serila" },
                    { 209, "Sez-icon.jpeg", "sez", "Sez" },
                    { 210, "Shadow-Knight-Pyllis-icon.png", "shadow-knight-pyllis", "Shadow Knight Pyllis" },
                    { 211, "Shadow-Rose-icon.jpeg", "shadow-rose", "Shadow Rose" },
                    { 212, "Shooting-Star-Achates.jpeg", "shooting-star-achates", "Shooting Star Achates" },
                    { 213, "Shuna-icon.png", "shuna", "Shuna" },
                    { 214, "Silk-icon.jpeg", "silk", "Silk" },
                    { 215, "singelica.png", "sinful-angelica", "Sinful Angelica" },
                    { 216, "sol-3.png", "sol-badguy", "Sol Badguy" },
                    { 217, "Solitaria-icon.png", "solitaria", "Solitaria" },
                    { 218, "Sonia-icon.png", "sonia", "Sonia" },
                    { 219, "specimen-sez.jpeg", "specimen-sez", "Specimen Sez" },
                    { 220, "Spirit-Eye-Celine-icon.png", "spirit-eye-celine", "Spirit Eye Celine" },
                    { 221, "Straze-icon.png", "straze", "Staze" },
                    { 222, "Summertime-Iseria-icon.png", "summertime-iseria", "Summertime Iseria" },
                    { 223, "Support-Model-Brinus-icon.png", "support-model-brinus", "Support Model Brinus" },
                    { 224, "Surin-icon.jpeg", "surin", "Surin" },
                    { 225, "Sven-icon.jpeg", "sven", "Sven" },
                    { 226, "taeyou-icon.jpeg", "taeyou", "Taeyou" },
                    { 227, "tammarine-face.png", "tamarinne", "Tamarinne" },
                    { 228, "taranor-guard-icon.png", "taranor-guard", "Taranor Guard" },
                    { 229, "taranor-royal-guard-icon.png", "taranor-royal-guard", "Taranor Royal Guard" },
                    { 230, "Tempest-Surin-icon.png", "tempest-surin", "Tempest Surin" },
                    { 231, "Tenebria-icon.jpeg", "tenebria", "Tenebria" },
                    { 232, "thief-roozid.png", "righteous-theif-roozid", "Righteous Thief Roozid" },
                    { 233, "Tieria-icon.jpeg", "tieria", "Tieria" },
                    { 234, "top-model-luluca.jpeg", "top-model-luluca", "Top Model Luluca" },
                    { 235, "troublemaker-crozet-icon.jpeg", "troublemaker-crozet", "Troublemaker Crozet" },
                    { 236, "Tywin-icon.jpeg", "tywin", "Tywin" },
                    { 237, "verdant-adin-icon.jpeg", "verdant-adin", "Verdant Adin" },
                    { 238, "vigilante-leader-glenn.jpeg", "vigilante-leader-glenn", "Vigilante Leader Glenn" },
                    { 239, "Vildred-icon.jpeg", "vildred", "Vildred" },
                    { 240, "Violet-icon.png", "violet", "Violet" },
                    { 241, "Visionary-Tenebria.jpeg", "specter-tenebria", "Specter Tenebria" },
                    { 242, "vivian_1.png", "vivian", "Vivian" },
                    { 243, "Wanda-icon.jpeg", "wanda", "Wanda" },
                    { 244, "Wanderer-Silk-icon.jpeg", "wanderer-silk", "Wanderer-Silk-icon" },
                    { 245, "warrior-leo.jpeg", "roaming-warrior-leo", "Roaming Warrior Leo" },
                    { 246, "watcherschuri.jpeg", "watcher-schuri", "Watcher Schuri" },
                    { 247, "yoonryoung-icon.jpeg", "yoonryoung", "Yoonryoung" },
                    { 248, "Yufine-icon.jpeg", "yufine", "Yufine" },
                    { 249, "yulha-icon.jpeg", "yulha", "Yulha" },
                    { 250, "Yuna-icon.jpeg", "yuna", "Yuna" },
                    { 251, "Zahhak-icon-real.png", "zahhak", "Zahhak" },
                    { 252, "Zealot-Carmainerose-icon.png", "zealot-carmainerose", "Zealot Carmainerose" },
                    { 253, "zeno.jpeg", "zeno", "Zeno" },
                    { 254, "Zerato-icon.jpeg", "zerato", "Zerato" },
                    { 255, "Faithless-Lidica-icon.png", "faithless-lidica", "Faithless Lidica" },
                    { 256, "Gunther-icon.png", "gunther", "Gunther" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Match_Defense1Id",
                table: "Match",
                column: "Defense1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Defense2Id",
                table: "Match",
                column: "Defense2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Defense3Id",
                table: "Match",
                column: "Defense3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Offense1Id",
                table: "Match",
                column: "Offense1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Offense2Id",
                table: "Match",
                column: "Offense2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Offense3Id",
                table: "Match",
                column: "Offense3Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropTable(
                name: "hero");
        }
    }
}
