using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class AddServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_ShopProducts_ShopProductsId",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_ShopProductsId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "ShopProductsId",
                table: "Discounts");

            migrationBuilder.AddColumn<int>(
                name: "DiscountsId",
                table: "ShopProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_DiscountsId",
                table: "ShopProducts",
                column: "DiscountsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_Discounts_DiscountsId",
                table: "ShopProducts",
                column: "DiscountsId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_Discounts_DiscountsId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_DiscountsId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "DiscountsId",
                table: "ShopProducts");

            migrationBuilder.AddColumn<int>(
                name: "ShopProductsId",
                table: "Discounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ShopProductsId",
                table: "Discounts",
                column: "ShopProductsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_ShopProducts_ShopProductsId",
                table: "Discounts",
                column: "ShopProductsId",
                principalTable: "ShopProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
