using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class AddTransactionLog_Re : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilesId",
                table: "TransactionLog",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLog_FilesId",
                table: "TransactionLog",
                column: "FilesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLog_File_FilesId",
                table: "TransactionLog",
                column: "FilesId",
                principalTable: "File",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLog_File_FilesId",
                table: "TransactionLog");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLog_FilesId",
                table: "TransactionLog");

            migrationBuilder.DropColumn(
                name: "FilesId",
                table: "TransactionLog");
        }
    }
}
