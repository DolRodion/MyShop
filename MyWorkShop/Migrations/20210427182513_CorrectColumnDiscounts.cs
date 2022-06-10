using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class CorrectColumnDiscounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Discounts_ShopProductsId",
                table: "Discounts");

            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "Discounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ShopProductsId",
                table: "Discounts",
                column: "ShopProductsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Discounts_ShopProductsId",
                table: "Discounts");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Discounts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ShopProductsId",
                table: "Discounts",
                column: "ShopProductsId");
        }
    }
}
