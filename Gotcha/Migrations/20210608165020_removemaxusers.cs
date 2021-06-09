using Microsoft.EntityFrameworkCore.Migrations;

namespace Gotcha.Migrations
{
    public partial class removemaxusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxPlayers",
                table: "Games");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxPlayers",
                table: "Games",
                type: "int",
                nullable: true);
        }
    }
}
