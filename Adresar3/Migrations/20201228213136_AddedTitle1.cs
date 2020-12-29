using Microsoft.EntityFrameworkCore.Migrations;

namespace Adresar3.Migrations
{
    public partial class AddedTitle1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Contact",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Contact");
        }
    }
}
