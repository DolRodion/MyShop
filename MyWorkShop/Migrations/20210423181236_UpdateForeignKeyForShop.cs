using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class UpdateForeignKeyForShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shops_ShopProducts_ShopProductsId",
                table: "Shops");

            migrationBuilder.DropIndex(
                name: "IX_Shops_ShopProductsId",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "ShopProductsId",
                table: "Shops");

            migrationBuilder.AddColumn<int>(
                name: "ShopId",
                table: "ShopProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_ShopId",
                table: "ShopProducts",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_Shops_ShopId",
                table: "ShopProducts",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_Shops_ShopId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_ShopId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "ShopProducts");

            migrationBuilder.AddColumn<int>(
                name: "ShopProductsId",
                table: "Shops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Shops_ShopProductsId",
                table: "Shops",
                column: "ShopProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_ShopProducts_ShopProductsId",
                table: "Shops",
                column: "ShopProductsId",
                principalTable: "ShopProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
