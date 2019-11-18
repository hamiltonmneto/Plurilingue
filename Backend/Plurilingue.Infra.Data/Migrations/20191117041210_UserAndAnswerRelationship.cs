using Microsoft.EntityFrameworkCore.Migrations;

namespace Plurilingue.Infra.Data.Migrations
{
    public partial class UserAndAnswerRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "User_Id",
                table: "Answer",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Answer_User_Id",
                table: "Answer",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_User_User_Id",
                table: "Answer",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_User_User_Id",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_User_Id",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "Answer");
        }
    }
}
