using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gotcha.Migrations
{
    public partial class addLinktable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordLinks");

            migrationBuilder.AlterColumn<Guid>(
                name: "Word_Id",
                table: "Contracts",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "WordWordset",
                columns: table => new
                {
                    WordSet_Id = table.Column<Guid>(nullable: false),
                    Word_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordWordset", x => new { x.WordSet_Id, x.Word_Id });
                    table.ForeignKey(
                        name: "FK_WordWordset_WordSets_WordSet_Id",
                        column: x => x.WordSet_Id,
                        principalTable: "WordSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WordWordset_Words_Word_Id",
                        column: x => x.Word_Id,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WordWordset_Word_Id",
                table: "WordWordset",
                column: "Word_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordWordset");

            migrationBuilder.AlterColumn<Guid>(
                name: "Word_Id",
                table: "Contracts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "WordLinks",
                columns: table => new
                {
                    WordSet_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Word_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordLinks", x => new { x.WordSet_Id, x.Word_Id });
                    table.ForeignKey(
                        name: "FK_WordLinks_WordSets_WordSet_Id",
                        column: x => x.WordSet_Id,
                        principalTable: "WordSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WordLinks_Words_Word_Id",
                        column: x => x.Word_Id,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WordLinks_Word_Id",
                table: "WordLinks",
                column: "Word_Id");
        }
    }
}
