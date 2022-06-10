using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class AddBuyersAndPurchasesRe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchasesId",
                table: "ShopProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyersId = table.Column<int>(type: "int", nullable: false),
                    DatePurchases = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchases_Buyers_BuyersId",
                        column: x => x.BuyersId,
                        principalTable: "Buyers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_PurchasesId",
                table: "ShopProducts",
                column: "PurchasesId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_BuyersId",
                table: "Purchases",
                column: "BuyersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_Purchases_PurchasesId",
                table: "ShopProducts",
                column: "PurchasesId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_Purchases_PurchasesId",
                table: "ShopProducts");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_PurchasesId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "PurchasesId",
                table: "ShopProducts");
        }
    }
}
