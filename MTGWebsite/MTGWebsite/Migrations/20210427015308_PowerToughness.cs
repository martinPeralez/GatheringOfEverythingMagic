using Microsoft.EntityFrameworkCore.Migrations;

namespace MTGWebsite.Migrations
{
    public partial class PowerToughness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Card",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "Card",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Toughness",
                table: "Card",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardCount = table.Column<int>(type: "int", nullable: false),
                    InStandardRotation = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "Toughness",
                table: "Card");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Card",
                newName: "id");
        }
    }
}
