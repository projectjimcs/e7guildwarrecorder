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
                name: "match",
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
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_match", x => x.Id);
                    table.ForeignKey(
                        name: "FK_match_hero_Defense1Id",
                        column: x => x.Defense1Id,
                        principalTable: "hero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_match_hero_Defense2Id",
                        column: x => x.Defense2Id,
                        principalTable: "hero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_match_hero_Defense3Id",
                        column: x => x.Defense3Id,
                        principalTable: "hero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_match_hero_Offense1Id",
                        column: x => x.Offense1Id,
                        principalTable: "hero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_match_hero_Offense2Id",
                        column: x => x.Offense2Id,
                        principalTable: "hero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_match_hero_Offense3Id",
                        column: x => x.Offense3Id,
                        principalTable: "hero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_match_Defense1Id",
                table: "match",
                column: "Defense1Id");

            migrationBuilder.CreateIndex(
                name: "IX_match_Defense2Id",
                table: "match",
                column: "Defense2Id");

            migrationBuilder.CreateIndex(
                name: "IX_match_Defense3Id",
                table: "match",
                column: "Defense3Id");

            migrationBuilder.CreateIndex(
                name: "IX_match_Offense1Id",
                table: "match",
                column: "Offense1Id");

            migrationBuilder.CreateIndex(
                name: "IX_match_Offense2Id",
                table: "match",
                column: "Offense2Id");

            migrationBuilder.CreateIndex(
                name: "IX_match_Offense3Id",
                table: "match",
                column: "Offense3Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "match");

            migrationBuilder.DropTable(
                name: "hero");
        }
    }
}
