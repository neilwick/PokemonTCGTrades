using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonTCGTrades.Migrations
{
    public partial class TransactionsInStoreContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SenderID = table.Column<string>(type: "varchar(255)", nullable: false),
                    ReceiverID = table.Column<string>(type: "varchar(255)", nullable: false),
                    ListingID = table.Column<uint>(type: "int unsigned", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "DateTime", nullable: false),
                    InProgress = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Completed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PaymentID = table.Column<uint>(type: "int unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
