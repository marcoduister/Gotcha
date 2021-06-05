using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gotcha.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Rol = table.Column<int>(nullable: false),
                    UserActive = table.Column<bool>(nullable: false),
                    ProfileImage = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Maker_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameTypes_Users_Maker_Id",
                        column: x => x.Maker_Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Maker_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_Users_Maker_Id",
                        column: x => x.Maker_Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RuleSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Maker_Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RuleSets_Users_Maker_Id",
                        column: x => x.Maker_Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Maker_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Words_Users_Maker_Id",
                        column: x => x.Maker_Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WordSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Maker_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WordSets_Users_Maker_Id",
                        column: x => x.Maker_Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RuleLinks",
                columns: table => new
                {
                    Rule_Id = table.Column<Guid>(nullable: false),
                    RuleSet_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleLinks", x => new { x.RuleSet_Id, x.Rule_Id });
                    table.ForeignKey(
                        name: "FK_RuleLinks_RuleSets_RuleSet_Id",
                        column: x => x.RuleSet_Id,
                        principalTable: "RuleSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RuleLinks_Rules_Rule_Id",
                        column: x => x.Rule_Id,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EindTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    MaxPlayers = table.Column<int>(nullable: true),
                    RandomWiner = table.Column<Guid>(nullable: true),
                    BestKill = table.Column<Guid>(nullable: true),
                    Maker_Id = table.Column<Guid>(nullable: false),
                    RuleSet_Id = table.Column<Guid>(nullable: true),
                    GameType_Id = table.Column<Guid>(nullable: true),
                    WordSet_Id = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_GameTypes_GameType_Id",
                        column: x => x.GameType_Id,
                        principalTable: "GameTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Users_Maker_Id",
                        column: x => x.Maker_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_RuleSets_RuleSet_Id",
                        column: x => x.RuleSet_Id,
                        principalTable: "RuleSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_WordSets_WordSet_Id",
                        column: x => x.WordSet_Id,
                        principalTable: "WordSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WordLinks",
                columns: table => new
                {
                    Word_Id = table.Column<Guid>(nullable: false),
                    WordSet_Id = table.Column<Guid>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Game_Id = table.Column<Guid>(nullable: false),
                    User_Id = table.Column<Guid>(nullable: false),
                    Word_Id = table.Column<Guid>(nullable: false),
                    EliminatedTime = table.Column<DateTime>(nullable: false),
                    Eliminations = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Games_Game_Id",
                        column: x => x.Game_Id,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_Game_Id",
                table: "Contracts",
                column: "Game_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameType_Id",
                table: "Games",
                column: "GameType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Maker_Id",
                table: "Games",
                column: "Maker_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_RuleSet_Id",
                table: "Games",
                column: "RuleSet_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_WordSet_Id",
                table: "Games",
                column: "WordSet_Id");

            migrationBuilder.CreateIndex(
                name: "IX_GameTypes_Maker_Id",
                table: "GameTypes",
                column: "Maker_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RuleLinks_Rule_Id",
                table: "RuleLinks",
                column: "Rule_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_Maker_Id",
                table: "Rules",
                column: "Maker_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RuleSets_Maker_Id",
                table: "RuleSets",
                column: "Maker_Id");

            migrationBuilder.CreateIndex(
                name: "IX_WordLinks_Word_Id",
                table: "WordLinks",
                column: "Word_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Words_Maker_Id",
                table: "Words",
                column: "Maker_Id");

            migrationBuilder.CreateIndex(
                name: "IX_WordSets_Maker_Id",
                table: "WordSets",
                column: "Maker_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "RuleLinks");

            migrationBuilder.DropTable(
                name: "WordLinks");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "GameTypes");

            migrationBuilder.DropTable(
                name: "RuleSets");

            migrationBuilder.DropTable(
                name: "WordSets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
