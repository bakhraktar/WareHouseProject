using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "acnt");

            migrationBuilder.EnsureSchema(
                name: "brnd");

            migrationBuilder.EnsureSchema(
                name: "clrs");

            migrationBuilder.EnsureSchema(
                name: "crcy");

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
                name: "orgt");

            migrationBuilder.EnsureSchema(
                name: "prct");

            migrationBuilder.EnsureSchema(
                name: "prdc");

            migrationBuilder.EnsureSchema(
                name: "prdt");

            migrationBuilder.EnsureSchema(
                name: "wrhs");

            migrationBuilder.CreateTable(
                name: "AccountentTrees",
                schema: "acnt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentTreeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountentTrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountentTrees_AccountentTrees_ParentTreeId",
                        column: x => x.ParentTreeId,
                        principalSchema: "acnt",
                        principalTable: "AccountentTrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                schema: "brnd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                schema: "clrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                schema: "gndr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPositions",
                schema: "jbps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                schema: "mnfc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                schema: "mnun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                schema: "brnd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationTypes",
                schema: "orgt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Origins",
                schema: "orgn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                schema: "prct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                schema: "prdt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                schema: "wrhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    AccountentTreeCodeId = table.Column<int>(type: "int", nullable: true),
                    Report = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WareHouses_AccountentTrees_AccountentTreeCodeId",
                        column: x => x.AccountentTreeCodeId,
                        principalSchema: "acnt",
                        principalTable: "AccountentTrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                schema: "crcy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstMoneyUnitId = table.Column<int>(type: "int", nullable: true),
                    Course = table.Column<int>(type: "int", nullable: false),
                    SecondMoneyUnitId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currencies_Manufacturers_FirstMoneyUnitId",
                        column: x => x.FirstMoneyUnitId,
                        principalSchema: "mnun",
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Currencies_Manufacturers_SecondMoneyUnitId",
                        column: x => x.SecondMoneyUnitId,
                        principalSchema: "mnun",
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "empl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountentTreeCodeId = table.Column<int>(type: "int", nullable: true),
                    PersonalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobPositionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AccountentTrees_AccountentTreeCodeId",
                        column: x => x.AccountentTreeCodeId,
                        principalSchema: "acnt",
                        principalTable: "AccountentTrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Genders_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "gndr",
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalSchema: "jbps",
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalSchema: "brnd",
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                schema: "orgn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountentTreeCodeId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPSAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_AccountentTrees_AccountentTreeCodeId",
                        column: x => x.AccountentTreeCodeId,
                        principalSchema: "acnt",
                        principalTable: "AccountentTrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Organizations_OrganizationTypes_OrganizationTypeId",
                        column: x => x.OrganizationTypeId,
                        principalSchema: "orgt",
                        principalTable: "OrganizationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "prdc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountentTreeCodeId = table.Column<int>(type: "int", nullable: true),
                    Report = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoneyUnitId = table.Column<int>(type: "int", nullable: true),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: true),
                    ProcutTypeId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true),
                    OriginId = table.Column<int>(type: "int", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    Proto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelfCost = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AccountentTrees_AccountentTreeCodeId",
                        column: x => x.AccountentTreeCodeId,
                        principalSchema: "acnt",
                        principalTable: "AccountentTrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "brnd",
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalSchema: "clrs",
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalSchema: "mnfc",
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_MoneyUnitId",
                        column: x => x.MoneyUnitId,
                        principalSchema: "mnun",
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Origins_OriginId",
                        column: x => x.OriginId,
                        principalSchema: "orgn",
                        principalTable: "Origins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalSchema: "prct",
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProcutTypeId",
                        column: x => x.ProcutTypeId,
                        principalSchema: "prdt",
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountentTrees_ParentTreeId",
                schema: "acnt",
                table: "AccountentTrees",
                column: "ParentTreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_FirstMoneyUnitId",
                schema: "crcy",
                table: "Currencies",
                column: "FirstMoneyUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_SecondMoneyUnitId",
                schema: "crcy",
                table: "Currencies",
                column: "SecondMoneyUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AccountentTreeCodeId",
                schema: "empl",
                table: "Employees",
                column: "AccountentTreeCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                schema: "empl",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobPositionId",
                schema: "empl",
                table: "Employees",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalityId",
                schema: "empl",
                table: "Employees",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AccountentTreeCodeId",
                schema: "orgn",
                table: "Organizations",
                column: "AccountentTreeCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_OrganizationTypeId",
                schema: "orgn",
                table: "Organizations",
                column: "OrganizationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AccountentTreeCodeId",
                schema: "prdc",
                table: "Products",
                column: "AccountentTreeCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                schema: "prdc",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                schema: "prdc",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturerId",
                schema: "prdc",
                table: "Products",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MoneyUnitId",
                schema: "prdc",
                table: "Products",
                column: "MoneyUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OriginId",
                schema: "prdc",
                table: "Products",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProcutTypeId",
                schema: "prdc",
                table: "Products",
                column: "ProcutTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                schema: "prdc",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WareHouses_AccountentTreeCodeId",
                schema: "wrhs",
                table: "WareHouses",
                column: "AccountentTreeCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies",
                schema: "crcy");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "empl");

            migrationBuilder.DropTable(
                name: "Organizations",
                schema: "orgn");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "prdc");

            migrationBuilder.DropTable(
                name: "WareHouses",
                schema: "wrhs");

            migrationBuilder.DropTable(
                name: "Genders",
                schema: "gndr");

            migrationBuilder.DropTable(
                name: "JobPositions",
                schema: "jbps");

            migrationBuilder.DropTable(
                name: "Nationalities",
                schema: "brnd");

            migrationBuilder.DropTable(
                name: "OrganizationTypes",
                schema: "orgt");

            migrationBuilder.DropTable(
                name: "Brands",
                schema: "brnd");

            migrationBuilder.DropTable(
                name: "Colors",
                schema: "clrs");

            migrationBuilder.DropTable(
                name: "Manufacturers",
                schema: "mnfc");

            migrationBuilder.DropTable(
                name: "Manufacturers",
                schema: "mnun");

            migrationBuilder.DropTable(
                name: "Origins",
                schema: "orgn");

            migrationBuilder.DropTable(
                name: "ProductCategories",
                schema: "prct");

            migrationBuilder.DropTable(
                name: "ProductTypes",
                schema: "prdt");

            migrationBuilder.DropTable(
                name: "AccountentTrees",
                schema: "acnt");
        }
    }
}
