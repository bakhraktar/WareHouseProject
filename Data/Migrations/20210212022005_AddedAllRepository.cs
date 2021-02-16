using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedAllRepository : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                schema: "wrhs",
                table: "WareHouses",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "GPSAdress",
                schema: "orgn",
                table: "Organizations",
                newName: "GPSAddress");

            migrationBuilder.RenameColumn(
                name: "EmailAdress",
                schema: "orgn",
                table: "Organizations",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "Adress",
                schema: "orgn",
                table: "Organizations",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                schema: "wrhs",
                table: "WareHouses",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "GPSAddress",
                schema: "orgn",
                table: "Organizations",
                newName: "GPSAdress");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                schema: "orgn",
                table: "Organizations",
                newName: "EmailAdress");

            migrationBuilder.RenameColumn(
                name: "Address",
                schema: "orgn",
                table: "Organizations",
                newName: "Adress");
        }
    }
}
