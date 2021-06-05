using Microsoft.EntityFrameworkCore.Migrations;

namespace Gotcha.Migrations
{
    public partial class contractUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Contracts_User_Id",
                table: "Contracts",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Users_User_Id",
                table: "Contracts",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Users_User_Id",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_User_Id",
                table: "Contracts");
        }
    }
}
