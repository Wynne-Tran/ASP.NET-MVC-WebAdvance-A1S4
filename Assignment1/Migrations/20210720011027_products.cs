using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations
{
    public partial class products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductsId);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    TechniciansId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.TechniciansId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomersId);
                    table.ForeignKey(
                        name: "FK_Customers_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    IncidentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechniciansId = table.Column<int>(type: "int", nullable: false),
                    DayOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayClose = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.IncidentsId);
                    table.ForeignKey(
                        name: "FK_Incidents_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "CustomersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Technicians_TechniciansId",
                        column: x => x.TechniciansId,
                        principalTable: "Technicians",
                        principalColumn: "TechniciansId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "Canada" },
                    { 2, "USA" },
                    { 3, "Uk" },
                    { 4, "China" },
                    { 5, "Japan" },
                    { 6, "France" },
                    { 7, "Italia" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductsId", "Code", "Name", "Price", "Rdate" },
                values: new object[,]
                {
                    { 1, "LEAG10", "League Scheduler 1.0", 4.99m, new DateTime(2021, 7, 19, 21, 10, 26, 963, DateTimeKind.Local).AddTicks(9851) },
                    { 2, "LEAGD10", "League Scheduler Deluxe 1.0", 7.99m, new DateTime(2021, 7, 19, 21, 10, 26, 964, DateTimeKind.Local).AddTicks(8372) },
                    { 3, "DRAFT10", "Draft Manager 10", 4.99m, new DateTime(2021, 7, 19, 21, 10, 26, 964, DateTimeKind.Local).AddTicks(8450) }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechniciansId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "thihoangtram.tran@georgebrown.ca", "Wynne Tran", "4167221285" },
                    { 2, "kiani.forough@georgebrown.ca", "Forough Kiani", "4167686868" },
                    { 3, "matias.herter@georgebrown.ca", "Matias Herter", "4167999888" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomersId", "Address", "City", "CountryId", "Email", "FirstName", "LastName", "Phone", "PostalCode", "State" },
                values: new object[] { 1, "200 King", "Toronto", 1, "thihoangtram.tran@georgebrown.ca", "Kaitlyn", "Anthoni", "4167221285", "M6J 0B3", "Ontario" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomersId", "Address", "City", "CountryId", "Email", "FirstName", "LastName", "Phone", "PostalCode", "State" },
                values: new object[] { 2, "286 King", "Atlanta", 3, "", "Ania ", "Irvin", "4167221285", "M6J 111", "Quesbec" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomersId", "Address", "City", "CountryId", "Email", "FirstName", "LastName", "Phone", "PostalCode", "State" },
                values: new object[] { 3, "286 Richmond Hill", "Kingdom", 5, "abc@gmail.com", "Kendall ", "Maya", "4167123456", "M3r 7Y6", "Ottawa" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentsId", "CustomersId", "DayClose", "DayOpen", "Description", "ProductsId", "TechniciansId", "Title" },
                values: new object[] { 1, 1, new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5018), new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(4782), "Got 100 for this assignment", 1, 1, "Congratulation !" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentsId", "CustomersId", "DayClose", "DayOpen", "Description", "ProductsId", "TechniciansId", "Title" },
                values: new object[] { 2, 2, new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5488), new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5487), "Some errors happen !", 2, 2, "Could not install" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentsId", "CustomersId", "DayClose", "DayOpen", "Description", "ProductsId", "TechniciansId", "Title" },
                values: new object[] { 3, 3, new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5506), new DateTime(2021, 7, 19, 21, 10, 26, 965, DateTimeKind.Local).AddTicks(5505), "Application still run but need to fix some error", 3, 3, "Error Launching program" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountryId",
                table: "Customers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CustomersId",
                table: "Incidents",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductsId",
                table: "Incidents",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_TechniciansId",
                table: "Incidents",
                column: "TechniciansId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Technicians");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
