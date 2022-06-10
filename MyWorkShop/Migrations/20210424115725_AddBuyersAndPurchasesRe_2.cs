using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class AddBuyersAndPurchasesRe_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_Purchases_PurchasesId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_PurchasesId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "PurchasesId",
                table: "ShopProducts");

            migrationBuilder.CreateTable(
                name: "PurchasesShopProducts",
                columns: table => new
                {
                    PurchasesId = table.Column<int>(type: "int", nullable: false),
                    ShopProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasesShopProducts", x => new { x.PurchasesId, x.ShopProductsId });
                    table.ForeignKey(
                        name: "FK_PurchasesShopProducts_Purchases_PurchasesId",
                        column: x => x.PurchasesId,
                        principalTable: "Purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchasesShopProducts_ShopProducts_ShopProductsId",
                        column: x => x.ShopProductsId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchasesShopProducts_ShopProductsId",
                table: "PurchasesShopProducts",
                column: "ShopProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchasesShopProducts");

            migrationBuilder.AddColumn<int>(
                name: "PurchasesId",
                table: "ShopProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_PurchasesId",
                table: "ShopProducts",
                column: "PurchasesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_Purchases_PurchasesId",
                table: "ShopProducts",
                column: "PurchasesId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
