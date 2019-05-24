using Microsoft.EntityFrameworkCore.Migrations;

namespace Plurilingue.Infra.Data.Migrations
{
    public partial class AddedCountryAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "User");
        }
    }
}
