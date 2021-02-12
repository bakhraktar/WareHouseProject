using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class correction1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_Manufacturers_FirstMoneyUnitId",
                schema: "crcy",
                table: "Currencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_Manufacturers_SecondMoneyUnitId",
                schema: "crcy",
                table: "Currencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_MoneyUnitId",
                schema: "prdc",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                schema: "mnun",
                table: "Manufacturers");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                schema: "mnun",
                newName: "MoneyUnits",
                newSchema: "mnun");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoneyUnits",
                schema: "mnun",
                table: "MoneyUnits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Currencies_MoneyUnits_FirstMoneyUnitId",
                schema: "crcy",
                table: "Currencies",
                column: "FirstMoneyUnitId",
                principalSchema: "mnun",
                principalTable: "MoneyUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Currencies_MoneyUnits_SecondMoneyUnitId",
                schema: "crcy",
                table: "Currencies",
                column: "SecondMoneyUnitId",
                principalSchema: "mnun",
                principalTable: "MoneyUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MoneyUnits_MoneyUnitId",
                schema: "prdc",
                table: "Products",
                column: "MoneyUnitId",
                principalSchema: "mnun",
                principalTable: "MoneyUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_MoneyUnits_FirstMoneyUnitId",
                schema: "crcy",
                table: "Currencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_MoneyUnits_SecondMoneyUnitId",
                schema: "crcy",
                table: "Currencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MoneyUnits_MoneyUnitId",
                schema: "prdc",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoneyUnits",
                schema: "mnun",
                table: "MoneyUnits");

            migrationBuilder.RenameTable(
                name: "MoneyUnits",
                schema: "mnun",
                newName: "Manufacturers",
                newSchema: "mnun");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                schema: "mnun",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Currencies_Manufacturers_FirstMoneyUnitId",
                schema: "crcy",
                table: "Currencies",
                column: "FirstMoneyUnitId",
                principalSchema: "mnun",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Currencies_Manufacturers_SecondMoneyUnitId",
                schema: "crcy",
                table: "Currencies",
                column: "SecondMoneyUnitId",
                principalSchema: "mnun",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_MoneyUnitId",
                schema: "prdc",
                table: "Products",
                column: "MoneyUnitId",
                principalSchema: "mnun",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
