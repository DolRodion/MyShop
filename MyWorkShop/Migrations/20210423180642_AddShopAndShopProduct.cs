using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class AddShopAndShopProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeProdyctsEnum = table.Column<int>(type: "int", nullable: false),
                    IsAvaliable = table.Column<bool>(type: "bit", nullable: false),
                    PriceProduct = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ManufacturerProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionProduct = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shops_ShopProducts_ShopProductsId",
                        column: x => x.ShopProductsId,
                        principalTable: "ShopProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shops_ShopProductsId",
                table: "Shops",
                column: "ShopProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "ShopProducts");
        }
    }
}
