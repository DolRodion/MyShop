using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class AddServices_Re : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceService = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DescriptionService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopId = table.Column<int>(type: "int", nullable: false),
                    DiscountsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopServices_Discounts_DiscountsId",
                        column: x => x.DiscountsId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopServices_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopServices_DiscountsId",
                table: "ShopServices",
                column: "DiscountsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopServices_ShopId",
                table: "ShopServices",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopServices");
        }
    }
}
