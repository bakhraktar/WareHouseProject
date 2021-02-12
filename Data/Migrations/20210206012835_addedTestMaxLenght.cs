using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addedTestMaxLenght : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                schema: "wrhs",
                table: "WareHouses",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                schema: "acnt",
                table: "AccountentTrees",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WareHouses_ManagerId",
                schema: "wrhs",
                table: "WareHouses",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_WareHouses_JobPositions_ManagerId",
                schema: "wrhs",
                table: "WareHouses",
                column: "ManagerId",
                principalSchema: "jbps",
                principalTable: "JobPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WareHouses_JobPositions_ManagerId",
                schema: "wrhs",
                table: "WareHouses");

            migrationBuilder.DropIndex(
                name: "IX_WareHouses_ManagerId",
                schema: "wrhs",
                table: "WareHouses");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                schema: "wrhs",
                table: "WareHouses");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                schema: "acnt",
                table: "AccountentTrees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);
        }
    }
}
