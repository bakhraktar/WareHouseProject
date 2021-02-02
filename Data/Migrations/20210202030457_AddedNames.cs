using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Gender_GenderId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobPosition_JobPositionId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Nationality_NationalityId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brand_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Color_ColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturer_ManufacturerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MoneyUnit_MoneyUnitId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Origin_OriginId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategory_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductType_ProcutTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Origin",
                table: "Origin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nationality",
                table: "Nationality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoneyUnit",
                table: "MoneyUnit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturer",
                table: "Manufacturer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPosition",
                table: "JobPosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brand",
                table: "Brand");

            migrationBuilder.EnsureSchema(
                name: "brnd");

            migrationBuilder.EnsureSchema(
                name: "clrs");

            migrationBuilder.EnsureSchema(
                name: "empl");

            migrationBuilder.EnsureSchema(
                name: "gndr");

            migrationBuilder.EnsureSchema(
                name: "jbps");

            migrationBuilder.EnsureSchema(
                name: "mnfc");

            migrationBuilder.EnsureSchema(
                name: "mnun");

            migrationBuilder.EnsureSchema(
                name: "orgn");

            migrationBuilder.EnsureSchema(
                name: "prct");

            migrationBuilder.EnsureSchema(
                name: "prdc");

            migrationBuilder.EnsureSchema(
                name: "prdt");

            migrationBuilder.EnsureSchema(
                name: "wrhs");

            migrationBuilder.RenameTable(
                name: "WareHouses",
                newName: "WareHouses",
                newSchema: "wrhs");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "prdc");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employees",
                newSchema: "empl");

            migrationBuilder.RenameTable(
                name: "ProductType",
                newName: "ProductTypes",
                newSchema: "prdt");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "ProductCategories",
                newSchema: "prct");

            migrationBuilder.RenameTable(
                name: "Origin",
                newName: "Origins",
                newSchema: "orgn");

            migrationBuilder.RenameTable(
                name: "Nationality",
                newName: "Nationalities",
                newSchema: "brnd");

            migrationBuilder.RenameTable(
                name: "MoneyUnit",
                newName: "Manufacturers",
                newSchema: "mnun");

            migrationBuilder.RenameTable(
                name: "Manufacturer",
                newName: "Manufacturers",
                newSchema: "mnfc");

            migrationBuilder.RenameTable(
                name: "JobPosition",
                newName: "JobPositions",
                newSchema: "jbps");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders",
                newSchema: "gndr");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "Colors",
                newSchema: "clrs");

            migrationBuilder.RenameTable(
                name: "Brand",
                newName: "Brands",
                newSchema: "brnd");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypes",
                schema: "prdt",
                table: "ProductTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                schema: "prct",
                table: "ProductCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Origins",
                schema: "orgn",
                table: "Origins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nationalities",
                schema: "brnd",
                table: "Nationalities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                schema: "mnun",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                schema: "mnfc",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPositions",
                schema: "jbps",
                table: "JobPositions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                schema: "gndr",
                table: "Genders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                schema: "clrs",
                table: "Colors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                schema: "brnd",
                table: "Brands",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Genders_GenderId",
                schema: "empl",
                table: "Employees",
                column: "GenderId",
                principalSchema: "gndr",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobPositions_JobPositionId",
                schema: "empl",
                table: "Employees",
                column: "JobPositionId",
                principalSchema: "jbps",
                principalTable: "JobPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                schema: "empl",
                table: "Employees",
                column: "NationalityId",
                principalSchema: "brnd",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                schema: "prdc",
                table: "Products",
                column: "BrandId",
                principalSchema: "brnd",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_ColorId",
                schema: "prdc",
                table: "Products",
                column: "ColorId",
                principalSchema: "clrs",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                schema: "prdc",
                table: "Products",
                column: "ManufacturerId",
                principalSchema: "mnfc",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Origins_OriginId",
                schema: "prdc",
                table: "Products",
                column: "OriginId",
                principalSchema: "orgn",
                principalTable: "Origins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                schema: "prdc",
                table: "Products",
                column: "ProductCategoryId",
                principalSchema: "prct",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProcutTypeId",
                schema: "prdc",
                table: "Products",
                column: "ProcutTypeId",
                principalSchema: "prdt",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Genders_GenderId",
                schema: "empl",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobPositions_JobPositionId",
                schema: "empl",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                schema: "empl",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                schema: "prdc",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_ColorId",
                schema: "prdc",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_ManufacturerId",
                schema: "prdc",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_MoneyUnitId",
                schema: "prdc",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Origins_OriginId",
                schema: "prdc",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                schema: "prdc",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProcutTypeId",
                schema: "prdc",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypes",
                schema: "prdt",
                table: "ProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                schema: "prct",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Origins",
                schema: "orgn",
                table: "Origins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nationalities",
                schema: "brnd",
                table: "Nationalities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                schema: "mnun",
                table: "Manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                schema: "mnfc",
                table: "Manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPositions",
                schema: "jbps",
                table: "JobPositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                schema: "gndr",
                table: "Genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                schema: "clrs",
                table: "Colors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                schema: "brnd",
                table: "Brands");

            migrationBuilder.RenameTable(
                name: "WareHouses",
                schema: "wrhs",
                newName: "WareHouses");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "prdc",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "empl",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                schema: "prdt",
                newName: "ProductType");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                schema: "prct",
                newName: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "Origins",
                schema: "orgn",
                newName: "Origin");

            migrationBuilder.RenameTable(
                name: "Nationalities",
                schema: "brnd",
                newName: "Nationality");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                schema: "mnun",
                newName: "MoneyUnit");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                schema: "mnfc",
                newName: "Manufacturer");

            migrationBuilder.RenameTable(
                name: "JobPositions",
                schema: "jbps",
                newName: "JobPosition");

            migrationBuilder.RenameTable(
                name: "Genders",
                schema: "gndr",
                newName: "Gender");

            migrationBuilder.RenameTable(
                name: "Colors",
                schema: "clrs",
                newName: "Color");

            migrationBuilder.RenameTable(
                name: "Brands",
                schema: "brnd",
                newName: "Brand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Origin",
                table: "Origin",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nationality",
                table: "Nationality",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoneyUnit",
                table: "MoneyUnit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturer",
                table: "Manufacturer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPosition",
                table: "JobPosition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brand",
                table: "Brand",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Gender_GenderId",
                table: "Employees",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobPosition_JobPositionId",
                table: "Employees",
                column: "JobPositionId",
                principalTable: "JobPosition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Nationality_NationalityId",
                table: "Employees",
                column: "NationalityId",
                principalTable: "Nationality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brand_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Color_ColorId",
                table: "Products",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturer_ManufacturerId",
                table: "Products",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MoneyUnit_MoneyUnitId",
                table: "Products",
                column: "MoneyUnitId",
                principalTable: "MoneyUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Origin_OriginId",
                table: "Products",
                column: "OriginId",
                principalTable: "Origin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategory_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductType_ProcutTypeId",
                table: "Products",
                column: "ProcutTypeId",
                principalTable: "ProductType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
