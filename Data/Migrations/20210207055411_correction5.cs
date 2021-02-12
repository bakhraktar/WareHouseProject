using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class correction5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AccountentTrees_Code",
                schema: "acnt",
                table: "AccountentTrees",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountentTrees_FullCode",
                schema: "acnt",
                table: "AccountentTrees",
                column: "FullCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AccountentTrees_Code",
                schema: "acnt",
                table: "AccountentTrees");

            migrationBuilder.DropIndex(
                name: "IX_AccountentTrees_FullCode",
                schema: "acnt",
                table: "AccountentTrees");
        }
    }
}
