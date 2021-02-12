using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class correction2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WareHouses_JobPositions_ManagerId",
                schema: "wrhs",
                table: "WareHouses");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "acnt",
                table: "AccountentTrees",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullCode",
                schema: "acnt",
                table: "AccountentTrees",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                schema: "acnt",
                table: "AccountentTrees",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_WareHouses_Employees_ManagerId",
                schema: "wrhs",
                table: "WareHouses",
                column: "ManagerId",
                principalSchema: "empl",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WareHouses_Employees_ManagerId",
                schema: "wrhs",
                table: "WareHouses");

            migrationBuilder.DropIndex(
                name: "IX_AccountentTrees_Code",
                schema: "acnt",
                table: "AccountentTrees");

            migrationBuilder.DropIndex(
                name: "IX_AccountentTrees_FullCode",
                schema: "acnt",
                table: "AccountentTrees");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "acnt",
                table: "AccountentTrees",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "FullCode",
                schema: "acnt",
                table: "AccountentTrees",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                schema: "acnt",
                table: "AccountentTrees",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

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
    }
}
