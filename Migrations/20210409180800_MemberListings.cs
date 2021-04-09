using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonTCGTrades.Migrations
{
    public partial class MemberListings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MemberID",
                table: "Listings",
                newName: "MemberId");

            migrationBuilder.AlterColumn<string>(
                name: "MemberId",
                table: "Listings",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.CreateIndex(
                name: "IX_Listings_MemberId",
                table: "Listings",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_AspNetUsers_MemberId",
                table: "Listings",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_AspNetUsers_MemberId",
                table: "Listings");

            migrationBuilder.DropIndex(
                name: "IX_Listings_MemberId",
                table: "Listings");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Listings",
                newName: "MemberID");

            migrationBuilder.AlterColumn<string>(
                name: "MemberID",
                table: "Listings",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);
        }
    }
}
