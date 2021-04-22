using Microsoft.EntityFrameworkCore.Migrations;

namespace MTGWebsite.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "id", "CardNumber", "CardText", "ConvertedMana", "Expansion", "FlavorText", "Image", "ManaCost", "Name", "Rarity", "Type" },
                values: new object[] { 1, 7, "Choose one - ... ", 2, "Strixhaven: School of Mages", "None", "https://media.wizards.com/2021/stx/en_yh4p4W4O4x.png", "1 Colorless, 1 White", "Academic Probation", "Rare", "Sorcery - Lesson" });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "id", "CardNumber", "CardText", "ConvertedMana", "Expansion", "FlavorText", "Image", "ManaCost", "Name", "Rarity", "Type" },
                values: new object[] { 2, 8, "None", 2, "Strixhaven: School of Mages", "Ancient ruins...", "https://media.wizards.com/2021/stx/en_v5m1B5aTSo.png", "1 Colorless, 1 White", "Ageless Guardian", "Uncommon", "Creature - Spirit Soldier" });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "id", "CardNumber", "CardText", "ConvertedMana", "Expansion", "FlavorText", "Image", "ManaCost", "Name", "Rarity", "Type" },
                values: new object[] { 3, 9, "Target creature you...", 2, "Strixhaven: School of Mages", "I've lived too...", "https://media.wizards.com/2021/stx/en_2B1ejCfSFx.png", "1 Colorless, 1 White", "Beaming Defiance", "Common", "Instant" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Card",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
