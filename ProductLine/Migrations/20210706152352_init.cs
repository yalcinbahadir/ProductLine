using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductLine.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CretaedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssemblyNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 1, "ACategory" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 2, "BCategory" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 3, "CCategory" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AssemblyNr", "CategoryId", "CretaedAt", "Description", "Name", "RefNumber" },
                values: new object[,]
                {
                    { 1, "A12", 1, new DateTime(2021, 7, 6, 17, 23, 52, 227, DateTimeKind.Local).AddTicks(2287), "Description of brake-1", "Brake-1", "ABC123" },
                    { 16, "A18", 3, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4348), "Description of Filter-11", "Filter-11", "ABK226" },
                    { 9, "A10", 3, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4115), "Description of Filter-3", "Filter-3", "ABC228" },
                    { 8, "A19", 3, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4099), "Description of Filter--2", "Filter-2", "ABC227" },
                    { 7, "A18", 3, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4082), "Description of Filter-1", "Filter-1", "ABC226" },
                    { 15, "A17", 2, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4331), "Description of Steer-31", "Steer-31", "ABA128" },
                    { 14, "A16", 2, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4314), "Description of Steer--21", "Steer-21", "ABE127" },
                    { 13, "A15", 2, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4297), "Description of Steer-11", "Steer-11", "ABS126" },
                    { 6, "A17", 2, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4064), "Description of Steer-3", "Steer-3", "ABC128" },
                    { 5, "A16", 2, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4041), "Description of Steer--2", "Steer-2", "ABC127" },
                    { 4, "A15", 2, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4023), "Description of Steer-1", "Steer-1", "ABC126" },
                    { 12, "A14", 1, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4277), "Description of brake-31", "Brake-31", "ABZ125" },
                    { 11, "A13", 1, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4151), "Description of brake-21", "Brake-21", "ABD124" },
                    { 10, "A12", 1, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4134), "Description of brake-11", "Brake-11", "ABd123" },
                    { 3, "A14", 1, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4000), "Description of brake-3", "Brake-3", "ABC125" },
                    { 2, "A13", 1, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(3945), "Description of brake-2", "Brake-2", "ABC124" },
                    { 17, "A19", 3, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4366), "Description of Filter--21", "Filter-21", "ABM227" },
                    { 18, "A10", 3, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(4384), "Description of Filter-31", "Filter-31", "ABH228" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "CreatedAt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(5691), 1, "demo1.jpg" },
                    { 30, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7577), 7, "demo5.jpg" },
                    { 29, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7561), 7, "demo4.jpg" },
                    { 28, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7541), 7, "demo3.jfif" },
                    { 27, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7501), 7, "demo2.jfif" },
                    { 26, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7485), 7, "demo1.jpg" },
                    { 70, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8289), 15, "demo5.jpg" },
                    { 69, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8273), 15, "demo4.jpg" },
                    { 68, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8257), 15, "demo3.jfif" },
                    { 31, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7593), 8, "demo1.jpg" },
                    { 67, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8241), 15, "demo2.jfif" },
                    { 65, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8182), 14, "demo5.jpg" },
                    { 64, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8166), 14, "demo4.jpg" },
                    { 63, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8150), 14, "demo3.jfif" },
                    { 62, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8133), 14, "demo2.jfif" },
                    { 61, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8117), 14, "demo1.jpg" },
                    { 60, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8099), 13, "demo5.jpg" },
                    { 59, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8083), 13, "demo4.jpg" },
                    { 58, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8066), 13, "demo3.jfif" },
                    { 66, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8198), 15, "demo1.jpg" },
                    { 32, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7609), 8, "demo2.jfif" },
                    { 33, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7625), 8, "demo3.jfif" },
                    { 34, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7641), 8, "demo4.jpg" },
                    { 83, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8511), 18, "demo3.jfif" },
                    { 82, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8495), 18, "demo2.jfif" },
                    { 81, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8479), 18, "demo1.jpg" },
                    { 80, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8464), 17, "demo5.jpg" },
                    { 79, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8448), 17, "demo4.jpg" },
                    { 78, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8417), 17, "demo3.jfif" },
                    { 77, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8401), 17, "demo2.jfif" },
                    { 76, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8384), 17, "demo1.jpg" },
                    { 75, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8368), 16, "demo5.jpg" },
                    { 74, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8352), 16, "demo4.jpg" },
                    { 73, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8337), 16, "demo3.jfif" },
                    { 72, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8321), 16, "demo2.jfif" },
                    { 71, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8305), 16, "demo1.jpg" },
                    { 40, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7736), 9, "demo5.jpg" },
                    { 39, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7720), 9, "demo4.jpg" },
                    { 38, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7704), 9, "demo3.jfif" },
                    { 37, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7688), 9, "demo2.jfif" },
                    { 36, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7673), 9, "demo1.jpg" },
                    { 35, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7658), 8, "demo5.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "CreatedAt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 57, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8050), 13, "demo2.jfif" },
                    { 56, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8034), 13, "demo1.jpg" },
                    { 25, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7470), 6, "demo5.jpg" },
                    { 24, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7454), 6, "demo4.jpg" },
                    { 45, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7814), 10, "demo5.jpg" },
                    { 44, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7798), 10, "demo4.jpg" },
                    { 43, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7782), 10, "demo3.jfif" },
                    { 42, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7766), 10, "demo2.jfif" },
                    { 41, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7751), 10, "demo1.jpg" },
                    { 105, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7231), 3, "demo5.jpg" },
                    { 104, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7215), 3, "demo4.jpg" },
                    { 103, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7198), 3, "demo3.jfif" },
                    { 102, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7149), 3, "demo2.jfif" },
                    { 101, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7133), 3, "demo1.jpg" },
                    { 10, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7117), 2, "demo5.jpg" },
                    { 9, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7099), 2, "demo4.jpg" },
                    { 8, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7083), 2, "demo3.jfif" },
                    { 7, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7066), 2, "demo2.jfif" },
                    { 6, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7049), 2, "demo1.jpg" },
                    { 5, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7029), 1, "demo5.jpg" },
                    { 4, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7012), 1, "demo4.jpg" },
                    { 3, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(6993), 1, "demo3.jfif" },
                    { 2, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(6960), 1, "demo2.jfif" },
                    { 46, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7831), 11, "demo1.jpg" },
                    { 84, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8527), 18, "demo4.jpg" },
                    { 47, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7846), 11, "demo2.jfif" },
                    { 49, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7922), 11, "demo4.jpg" },
                    { 23, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7439), 6, "demo3.jfif" },
                    { 22, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7423), 6, "demo2.jfif" },
                    { 21, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7408), 6, "demo1.jpg" },
                    { 20, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7391), 5, "demo5.jpg" },
                    { 19, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7375), 5, "demo4.jpg" },
                    { 18, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7359), 5, "demo3.jfif" },
                    { 17, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7343), 5, "demo2.jfif" },
                    { 16, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7328), 5, "demo1.jpg" },
                    { 15, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7312), 4, "demo5.jpg" },
                    { 14, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7295), 4, "demo4.jpg" },
                    { 13, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7279), 4, "demo3.jfif" },
                    { 12, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7262), 4, "demo2.jfif" },
                    { 11, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7246), 4, "demo1.jpg" },
                    { 55, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8018), 12, "demo5.jpg" },
                    { 54, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8002), 12, "demo4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "CreatedAt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 53, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7986), 12, "demo3.jfif" },
                    { 52, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7970), 12, "demo2.jfif" },
                    { 51, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7954), 12, "demo1.jpg" },
                    { 50, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7938), 11, "demo5.jpg" },
                    { 48, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(7903), 11, "demo3.jfif" },
                    { 85, new DateTime(2021, 7, 6, 17, 23, 52, 229, DateTimeKind.Local).AddTicks(8542), 18, "demo5.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId",
                table: "Photos",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
