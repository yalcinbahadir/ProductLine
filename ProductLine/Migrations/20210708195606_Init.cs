using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductLine.Migrations
{
    public partial class Init : Migration
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
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsControlled = table.Column<bool>(type: "bit", nullable: false),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Land = table.Column<int>(type: "int", nullable: true),
                    Market = table.Column<int>(type: "int", nullable: true)
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
                columns: new[] { "Id", "AssemblyNr", "CategoryId", "CretaedAt", "Description", "IsControlled", "Land", "Market", "Name", "RefNumber", "Target" },
                values: new object[,]
                {
                    { 1, "A12", 1, new DateTime(2021, 7, 8, 21, 56, 5, 787, DateTimeKind.Local).AddTicks(5791), "Description of brake-1", false, null, null, "Brake-1", "ABC123", null },
                    { 16, "A18", 3, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7996), "Description of Filter-11", false, null, null, "Filter-11", "ABK226", null },
                    { 9, "A10", 3, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7827), "Description of Filter-3", false, null, null, "Filter-3", "ABC228", null },
                    { 8, "A19", 3, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7806), "Description of Filter--2", false, null, null, "Filter-2", "ABC227", null },
                    { 7, "A18", 3, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7786), "Description of Filter-1", false, null, null, "Filter-1", "ABC226", null },
                    { 15, "A17", 2, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7950), "Description of Steer-31", false, null, null, "Steer-31", "ABA128", null },
                    { 14, "A16", 2, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7930), "Description of Steer--21", false, null, null, "Steer-21", "ABE127", null },
                    { 13, "A15", 2, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7909), "Description of Steer-11", false, null, null, "Steer-11", "ABS126", null },
                    { 6, "A17", 2, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7765), "Description of Steer-3", false, null, null, "Steer-3", "ABC128", null },
                    { 5, "A16", 2, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7740), "Description of Steer--2", false, null, null, "Steer-2", "ABC127", null },
                    { 4, "A15", 2, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7718), "Description of Steer-1", false, null, null, "Steer-1", "ABC126", null },
                    { 12, "A14", 1, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7889), "Description of brake-31", false, null, null, "Brake-31", "ABZ125", null },
                    { 11, "A13", 1, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7869), "Description of brake-21", false, null, null, "Brake-21", "ABD124", null },
                    { 10, "A12", 1, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7848), "Description of brake-11", false, null, null, "Brake-11", "ABd123", null },
                    { 3, "A14", 1, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7690), "Description of brake-3", false, null, null, "Brake-3", "ABC125", null },
                    { 2, "A13", 1, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(7619), "Description of brake-2", false, null, null, "Brake-2", "ABC124", null },
                    { 17, "A19", 3, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(8018), "Description of Filter--21", false, null, null, "Filter-21", "ABM227", null },
                    { 18, "A10", 3, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(8039), "Description of Filter-31", false, null, null, "Filter-31", "ABH228", null }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "CreatedAt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(8942), 1, "demo1.jpg" },
                    { 30, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(608), 7, "demo5.jpg" },
                    { 29, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(567), 7, "demo4.jpg" },
                    { 28, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(548), 7, "demo3.jfif" },
                    { 27, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(530), 7, "demo2.jfif" },
                    { 26, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(513), 7, "demo1.jpg" },
                    { 70, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1353), 15, "demo5.jpg" },
                    { 69, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1314), 15, "demo4.jpg" },
                    { 68, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1296), 15, "demo3.jfif" },
                    { 31, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(628), 8, "demo1.jpg" },
                    { 67, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1279), 15, "demo2.jfif" },
                    { 65, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1244), 14, "demo5.jpg" },
                    { 64, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1227), 14, "demo4.jpg" },
                    { 63, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1210), 14, "demo3.jfif" },
                    { 62, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1193), 14, "demo2.jfif" },
                    { 61, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1176), 14, "demo1.jpg" },
                    { 60, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1157), 13, "demo5.jpg" },
                    { 59, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1140), 13, "demo4.jpg" },
                    { 58, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1123), 13, "demo3.jfif" },
                    { 66, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1262), 15, "demo1.jpg" },
                    { 32, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(646), 8, "demo2.jfif" },
                    { 33, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(663), 8, "demo3.jfif" },
                    { 34, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(681), 8, "demo4.jpg" },
                    { 83, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1627), 18, "demo3.jfif" },
                    { 82, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1610), 18, "demo2.jfif" },
                    { 81, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1593), 18, "demo1.jpg" },
                    { 80, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1576), 17, "demo5.jpg" },
                    { 79, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1558), 17, "demo4.jpg" },
                    { 78, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1512), 17, "demo3.jfif" },
                    { 77, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1496), 17, "demo2.jfif" },
                    { 76, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1478), 17, "demo1.jpg" },
                    { 75, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1462), 16, "demo5.jpg" },
                    { 74, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1444), 16, "demo4.jpg" },
                    { 73, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1427), 16, "demo3.jfif" },
                    { 72, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1408), 16, "demo2.jfif" },
                    { 71, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1373), 16, "demo1.jpg" },
                    { 40, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(786), 9, "demo5.jpg" },
                    { 39, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(768), 9, "demo4.jpg" },
                    { 38, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(750), 9, "demo3.jfif" },
                    { 37, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(733), 9, "demo2.jfif" },
                    { 36, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(715), 9, "demo1.jpg" },
                    { 35, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(698), 8, "demo5.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "CreatedAt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 57, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1106), 13, "demo2.jfif" },
                    { 56, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1089), 13, "demo1.jpg" },
                    { 25, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(496), 6, "demo5.jpg" },
                    { 24, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(478), 6, "demo4.jpg" },
                    { 45, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(874), 10, "demo5.jpg" },
                    { 44, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(856), 10, "demo4.jpg" },
                    { 43, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(839), 10, "demo3.jfif" },
                    { 42, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(821), 10, "demo2.jfif" },
                    { 41, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(804), 10, "demo1.jpg" },
                    { 105, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(198), 3, "demo5.jpg" },
                    { 104, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(181), 3, "demo4.jpg" },
                    { 103, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(163), 3, "demo3.jfif" },
                    { 102, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(146), 3, "demo2.jfif" },
                    { 101, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(129), 3, "demo1.jpg" },
                    { 10, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(111), 2, "demo5.jpg" },
                    { 9, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(93), 2, "demo4.jpg" },
                    { 8, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(76), 2, "demo3.jfif" },
                    { 7, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(59), 2, "demo2.jfif" },
                    { 6, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(41), 2, "demo1.jpg" },
                    { 5, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(20), 1, "demo5.jpg" },
                    { 4, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(3), 1, "demo4.jpg" },
                    { 3, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(9984), 1, "demo3.jfif" },
                    { 2, new DateTime(2021, 7, 8, 21, 56, 5, 789, DateTimeKind.Local).AddTicks(9949), 1, "demo2.jfif" },
                    { 46, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(892), 11, "demo1.jpg" },
                    { 84, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1644), 18, "demo4.jpg" },
                    { 47, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(908), 11, "demo2.jfif" },
                    { 49, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(943), 11, "demo4.jpg" },
                    { 23, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(460), 6, "demo3.jfif" },
                    { 22, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(443), 6, "demo2.jfif" },
                    { 21, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(425), 6, "demo1.jpg" },
                    { 20, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(408), 5, "demo5.jpg" },
                    { 19, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(391), 5, "demo4.jpg" },
                    { 18, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(374), 5, "demo3.jfif" },
                    { 17, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(356), 5, "demo2.jfif" },
                    { 16, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(339), 5, "demo1.jpg" },
                    { 15, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(321), 4, "demo5.jpg" },
                    { 14, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(304), 4, "demo4.jpg" },
                    { 13, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(287), 4, "demo3.jfif" },
                    { 12, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(268), 4, "demo2.jfif" },
                    { 11, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(247), 4, "demo1.jpg" },
                    { 55, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1071), 12, "demo5.jpg" },
                    { 54, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1055), 12, "demo4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "CreatedAt", "ProductId", "Url" },
                values: new object[,]
                {
                    { 53, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1038), 12, "demo3.jfif" },
                    { 52, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1019), 12, "demo2.jfif" },
                    { 51, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(977), 12, "demo1.jpg" },
                    { 50, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(960), 11, "demo5.jpg" },
                    { 48, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(926), 11, "demo3.jfif" },
                    { 85, new DateTime(2021, 7, 8, 21, 56, 5, 790, DateTimeKind.Local).AddTicks(1661), 18, "demo5.jpg" }
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
