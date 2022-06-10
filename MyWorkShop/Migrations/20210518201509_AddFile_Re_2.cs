using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class AddFile_Re_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_File_FileId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_FileId",
                table: "ShopProducts");

            migrationBuilder.RenameColumn(
                name: "FileId",
                table: "ShopProducts",
                newName: "FilesId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_FilesId",
                table: "ShopProducts",
                column: "FilesId",
                unique: true,
                filter: "[FilesId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_File_FilesId",
                table: "ShopProducts",
                column: "FilesId",
                principalTable: "File",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_File_FilesId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_FilesId",
                table: "ShopProducts");

            migrationBuilder.RenameColumn(
                name: "FilesId",
                table: "ShopProducts",
                newName: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_FileId",
                table: "ShopProducts",
                column: "FileId",
                unique: true,
                filter: "[FileId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_File_FileId",
                table: "ShopProducts",
                column: "FileId",
                principalTable: "File",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
