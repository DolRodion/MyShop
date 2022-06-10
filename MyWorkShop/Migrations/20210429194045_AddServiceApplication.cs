using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class AddServiceApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceApplication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiceStatusEnum = table.Column<int>(type: "int", nullable: false),
                    Fio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceApplication_ShopServices_ShopServicesId",
                        column: x => x.ShopServicesId,
                        principalTable: "ShopServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceApplication_ShopServicesId",
                table: "ServiceApplication",
                column: "ShopServicesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceApplication");
        }
    }
}
