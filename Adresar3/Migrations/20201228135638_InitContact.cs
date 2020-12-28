using Microsoft.EntityFrameworkCore.Migrations;

namespace Adresar3.Migrations
{
    public partial class InitContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    OwnerID = table.Column<string>(nullable: false),
                    ContactId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ContactNum = table.Column<int>(nullable: false),
                    ContactNum1 = table.Column<int>(nullable: true),
                    ContactNum2 = table.Column<int>(nullable: true),
                    ContactNum3 = table.Column<int>(nullable: true),
                    ContactNum4 = table.Column<int>(nullable: true),
                    ContactNum5 = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    OwnerID = table.Column<string>(nullable: false),
                    ContactId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ContactNum = table.Column<int>(nullable: false),
                    ContactNum1 = table.Column<int>(nullable: true),
                    ContactNum2 = table.Column<int>(nullable: true),
                    ContactNum3 = table.Column<int>(nullable: true),
                    ContactNum4 = table.Column<int>(nullable: true),
                    ContactNum5 = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                });
        }
    }
}
