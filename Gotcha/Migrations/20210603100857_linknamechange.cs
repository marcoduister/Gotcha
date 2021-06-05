using Microsoft.EntityFrameworkCore.Migrations;

namespace Gotcha.Migrations
{
    public partial class linknamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RuleLinks_RuleSets_RuleSet_Id",
                table: "RuleLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_RuleLinks_Rules_Rule_Id",
                table: "RuleLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_WordWordset_WordSets_WordSet_Id",
                table: "WordWordset");

            migrationBuilder.DropForeignKey(
                name: "FK_WordWordset_Words_Word_Id",
                table: "WordWordset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WordWordset",
                table: "WordWordset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RuleLinks",
                table: "RuleLinks");

            migrationBuilder.RenameTable(
                name: "WordWordset",
                newName: "WordWordsets");

            migrationBuilder.RenameTable(
                name: "RuleLinks",
                newName: "RuleRuleSets");

            migrationBuilder.RenameIndex(
                name: "IX_WordWordset_Word_Id",
                table: "WordWordsets",
                newName: "IX_WordWordsets_Word_Id");

            migrationBuilder.RenameIndex(
                name: "IX_RuleLinks_Rule_Id",
                table: "RuleRuleSets",
                newName: "IX_RuleRuleSets_Rule_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WordWordsets",
                table: "WordWordsets",
                columns: new[] { "WordSet_Id", "Word_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RuleRuleSets",
                table: "RuleRuleSets",
                columns: new[] { "RuleSet_Id", "Rule_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_RuleRuleSets_RuleSets_RuleSet_Id",
                table: "RuleRuleSets",
                column: "RuleSet_Id",
                principalTable: "RuleSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RuleRuleSets_Rules_Rule_Id",
                table: "RuleRuleSets",
                column: "Rule_Id",
                principalTable: "Rules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WordWordsets_WordSets_WordSet_Id",
                table: "WordWordsets",
                column: "WordSet_Id",
                principalTable: "WordSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WordWordsets_Words_Word_Id",
                table: "WordWordsets",
                column: "Word_Id",
                principalTable: "Words",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RuleRuleSets_RuleSets_RuleSet_Id",
                table: "RuleRuleSets");

            migrationBuilder.DropForeignKey(
                name: "FK_RuleRuleSets_Rules_Rule_Id",
                table: "RuleRuleSets");

            migrationBuilder.DropForeignKey(
                name: "FK_WordWordsets_WordSets_WordSet_Id",
                table: "WordWordsets");

            migrationBuilder.DropForeignKey(
                name: "FK_WordWordsets_Words_Word_Id",
                table: "WordWordsets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WordWordsets",
                table: "WordWordsets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RuleRuleSets",
                table: "RuleRuleSets");

            migrationBuilder.RenameTable(
                name: "WordWordsets",
                newName: "WordWordset");

            migrationBuilder.RenameTable(
                name: "RuleRuleSets",
                newName: "RuleLinks");

            migrationBuilder.RenameIndex(
                name: "IX_WordWordsets_Word_Id",
                table: "WordWordset",
                newName: "IX_WordWordset_Word_Id");

            migrationBuilder.RenameIndex(
                name: "IX_RuleRuleSets_Rule_Id",
                table: "RuleLinks",
                newName: "IX_RuleLinks_Rule_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WordWordset",
                table: "WordWordset",
                columns: new[] { "WordSet_Id", "Word_Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_RuleLinks",
                table: "RuleLinks",
                columns: new[] { "RuleSet_Id", "Rule_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_RuleLinks_RuleSets_RuleSet_Id",
                table: "RuleLinks",
                column: "RuleSet_Id",
                principalTable: "RuleSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RuleLinks_Rules_Rule_Id",
                table: "RuleLinks",
                column: "Rule_Id",
                principalTable: "Rules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WordWordset_WordSets_WordSet_Id",
                table: "WordWordset",
                column: "WordSet_Id",
                principalTable: "WordSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WordWordset_Words_Word_Id",
                table: "WordWordset",
                column: "Word_Id",
                principalTable: "Words",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
