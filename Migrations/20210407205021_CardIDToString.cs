using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonTCGTrades.Migrations
{
    public partial class CardIDToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CardID",
                table: "Listings",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(uint),
                oldType: "int unsigned");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<uint>(
                name: "CardID",
                table: "Listings",
                type: "int unsigned",
                nullable: false,
                defaultValue: 0u,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }
    }
}
