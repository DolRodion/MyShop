using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWorkShop.Migrations
{
    public partial class DeleteColumnLoginFromForum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Forum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Forum",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
