using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addedAbstractProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountentTrees_AccountentTrees_ParentTreeId",
                schema: "acnt",
                table: "AccountentTrees");

            migrationBuilder.RenameColumn(
                name: "ParentTreeId",
                schema: "acnt",
                table: "AccountentTrees",
                newName: "AccountentTreeId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountentTrees_ParentTreeId",
                schema: "acnt",
                table: "AccountentTrees",
                newName: "IX_AccountentTrees_AccountentTreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountentTrees_AccountentTrees_AccountentTreeId",
                schema: "acnt",
                table: "AccountentTrees",
                column: "AccountentTreeId",
                principalSchema: "acnt",
                principalTable: "AccountentTrees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountentTrees_AccountentTrees_AccountentTreeId",
                schema: "acnt",
                table: "AccountentTrees");

            migrationBuilder.RenameColumn(
                name: "AccountentTreeId",
                schema: "acnt",
                table: "AccountentTrees",
                newName: "ParentTreeId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountentTrees_AccountentTreeId",
                schema: "acnt",
                table: "AccountentTrees",
                newName: "IX_AccountentTrees_ParentTreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountentTrees_AccountentTrees_ParentTreeId",
                schema: "acnt",
                table: "AccountentTrees",
                column: "ParentTreeId",
                principalSchema: "acnt",
                principalTable: "AccountentTrees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
