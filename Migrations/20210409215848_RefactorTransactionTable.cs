using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonTCGTrades.Migrations
{
    public partial class RefactorTransactionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MemberId",
                table: "Transactions",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_MemberId",
                table: "Transactions",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_AspNetUsers_MemberId",
                table: "Transactions",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_AspNetUsers_MemberId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_MemberId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Transactions");
        }
    }
}
