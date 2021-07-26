using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestServer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drawings",
                columns: table => new
                {
                    DrawingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Date = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Num1 = table.Column<int>(type: "int", nullable: false),
                    Num2 = table.Column<int>(type: "int", nullable: false),
                    Num3 = table.Column<int>(type: "int", nullable: false),
                    Num4 = table.Column<int>(type: "int", nullable: false),
                    Num5 = table.Column<int>(type: "int", nullable: false),
                    Kicker = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawings", x => x.DrawingId);
                });

            migrationBuilder.InsertData(
                table: "Drawings",
                columns: new[] { "DrawingId", "Date", "Kicker", "Name", "Num1", "Num2", "Num3", "Num4", "Num5" },
                values: new object[,]
                {
                    { 1, "1/10/21", 7, "Power Ball", 1, 5, 17, 22, 45 },
                    { 88, "1/10/21", 24, "Power Ball", 1, 8, 44, 53, 67 },
                    { 87, "1/10/21", 22, "Power Ball", 9, 20, 29, 45, 47 },
                    { 86, "1/10/21", 10, "Power Ball", 14, 47, 51, 56, 69 },
                    { 85, "1/10/21", 26, "Power Ball", 5, 8, 19, 21, 24 },
                    { 84, "1/10/21", 4, "Power Ball", 2, 33, 34, 60, 61 },
                    { 83, "1/10/21", 15, "Power Ball", 5, 13, 35, 44, 56 },
                    { 82, "1/10/21", 9, "Power Ball", 8, 23, 35, 59, 65 },
                    { 81, "1/10/21", 22, "Power Ball", 13, 14, 18, 34, 65 },
                    { 80, "1/10/21", 13, "Power Ball", 15, 32, 41, 60, 61 },
                    { 79, "1/10/21", 1, "Power Ball", 24, 32, 36, 38, 60 },
                    { 78, "1/10/21", 14, "Power Ball", 2, 20, 27, 45, 57 },
                    { 77, "1/10/21", 15, "Power Ball", 30, 39, 57, 58, 60 },
                    { 89, "1/10/21", 9, "Power Ball", 4, 20, 31, 33, 53 },
                    { 76, "1/10/21", 14, "Power Ball", 3, 16, 22, 34, 48 },
                    { 74, "1/10/21", 22, "Power Ball", 2, 40, 51, 64, 67 },
                    { 73, "1/10/21", 28, "Power Ball", 9, 21, 41, 49, 56 },
                    { 72, "1/10/21", 4, "Power Ball", 8, 40, 41, 51, 53 },
                    { 71, "1/10/21", 9, "Power Ball", 13, 23, 39, 41, 66 },
                    { 70, "1/10/21", 23, "Power Ball", 21, 44, 50, 59, 66 },
                    { 69, "1/10/21", 16, "Power Ball", 14, 15, 18, 34, 65 },
                    { 68, "1/10/21", 19, "Power Ball", 7, 13, 23, 25, 33 },
                    { 67, "1/10/21", 2, "Power Ball", 2, 15, 21, 35, 53 },
                    { 66, "1/10/21", 21, "Power Ball", 6, 30, 44, 52, 58 },
                    { 65, "1/10/21", 26, "Power Ball", 5, 8, 13, 34, 45 },
                    { 64, "1/10/21", 24, "Power Ball", 32, 35, 38, 51, 52 },
                    { 63, "1/10/21", 12, "Power Ball", 2, 35, 39, 47, 48 },
                    { 75, "1/10/21", 28, "Power Ball", 16, 32, 48, 63, 69 },
                    { 62, "1/10/21", 26, "Power Ball", 7, 17, 48, 53, 56 },
                    { 90, "1/10/21", 21, "Power Ball", 10, 24, 26, 51, 68 },
                    { 92, "1/10/21", 4, "Power Ball", 1, 5, 23, 24, 62 },
                    { 118, "1/10/21", 7, "Power Ball", 2, 11, 45, 49, 61 },
                    { 117, "1/10/21", 19, "Power Ball", 2, 43, 44, 54, 58 },
                    { 116, "1/10/21", 14, "Power Ball", 10, 23, 41, 53, 66 },
                    { 115, "1/10/21", 22, "Power Ball", 3, 4, 22, 33, 55 },
                    { 114, "1/10/21", 11, "Power Ball", 25, 36, 55, 60, 61 },
                    { 113, "1/10/21", 26, "Power Ball", 24, 31, 42, 52, 68 },
                    { 112, "1/10/21", 13, "Power Ball", 24, 41, 47, 57, 66 },
                    { 111, "1/10/21", 15, "Power Ball", 6, 22, 60, 62, 66 },
                    { 110, "1/10/21", 14, "Power Ball", 8, 10, 18, 33, 46 },
                    { 109, "1/10/21", 13, "Power Ball", 2, 4, 10, 47, 51 },
                    { 108, "1/10/21", 5, "Power Ball", 7, 17, 19, 44, 67 },
                    { 107, "1/10/21", 19, "Power Ball", 26, 30, 38, 57, 59 },
                    { 91, "1/10/21", 9, "Power Ball", 16, 30, 35, 39, 58 },
                    { 106, "1/10/21", 17, "Power Ball", 5, 31, 33, 51, 52 },
                    { 104, "1/10/21", 9, "Power Ball", 8, 12, 36, 46, 49 },
                    { 103, "1/10/21", 22, "Power Ball", 12, 15, 34, 37, 49 },
                    { 102, "1/10/21", 4, "Power Ball", 15, 40, 45, 57, 64 },
                    { 101, "1/10/21", 19, "Power Ball", 18, 27, 32, 39, 67 },
                    { 100, "1/10/21", 23, "Power Ball", 2, 34, 37, 46, 65 },
                    { 99, "1/10/21", 26, "Power Ball", 2, 7, 15, 37, 57 },
                    { 98, "1/10/21", 9, "Power Ball", 19, 23, 39, 59, 68 },
                    { 97, "1/10/21", 23, "Power Ball", 13, 16, 20, 35, 50 },
                    { 96, "1/10/21", 2, "Power Ball", 7, 20, 40, 45, 69 },
                    { 95, "1/10/21", 26, "Power Ball", 5, 39, 53, 54, 63 },
                    { 94, "1/10/21", 4, "Power Ball", 7, 19, 23, 54, 60 },
                    { 93, "1/10/21", 18, "Power Ball", 6, 8, 22, 39, 40 },
                    { 105, "1/10/21", 3, "Power Ball", 1, 24, 39, 53, 54 },
                    { 61, "1/10/21", 15, "Power Ball", 1, 5, 17, 22, 45 },
                    { 60, "1/10/21", 25, "Power Ball", 13, 27, 48, 49, 64 },
                    { 59, "1/10/21", 2, "Power Ball", 8, 28, 47, 50, 60 },
                    { 27, "1/10/21", 9, "Power Ball", 9, 20, 29, 45, 47 },
                    { 26, "1/10/21", 18, "Power Ball", 14, 47, 51, 56, 69 },
                    { 25, "1/10/21", 23, "Power Ball", 5, 8, 19, 21, 24 },
                    { 24, "1/10/21", 3, "Power Ball", 2, 33, 34, 60, 61 },
                    { 23, "1/10/21", 9, "Power Ball", 5, 13, 35, 44, 56 },
                    { 22, "1/10/21", 6, "Power Ball", 8, 23, 35, 59, 65 },
                    { 21, "1/10/21", 23, "Power Ball", 13, 14, 18, 34, 65 },
                    { 20, "1/10/21", 7, "Power Ball", 15, 32, 41, 60, 61 },
                    { 19, "1/10/21", 7, "Power Ball", 24, 32, 36, 38, 60 },
                    { 18, "1/10/21", 23, "Power Ball", 2, 20, 27, 45, 57 },
                    { 17, "1/10/21", 16, "Power Ball", 30, 39, 57, 58, 60 },
                    { 16, "1/10/21", 7, "Power Ball", 3, 16, 22, 34, 48 },
                    { 28, "1/10/21", 14, "Power Ball", 1, 8, 44, 53, 67 },
                    { 15, "1/10/21", 20, "Power Ball", 16, 32, 48, 63, 69 },
                    { 13, "1/10/21", 27, "Power Ball", 9, 21, 41, 49, 56 },
                    { 12, "1/10/21", 15, "Power Ball", 8, 40, 41, 51, 53 },
                    { 11, "1/10/21", 9, "Power Ball", 13, 23, 39, 41, 66 },
                    { 10, "1/10/21", 11, "Power Ball", 21, 44, 50, 59, 66 },
                    { 9, "1/10/21", 11, "Power Ball", 14, 15, 18, 34, 65 },
                    { 8, "1/10/21", 18, "Power Ball", 7, 13, 23, 25, 33 },
                    { 7, "1/10/21", 21, "Power Ball", 2, 15, 21, 35, 53 },
                    { 6, "1/10/21", 16, "Power Ball", 6, 30, 44, 52, 58 },
                    { 5, "1/10/21", 3, "Power Ball", 5, 8, 13, 34, 45 },
                    { 4, "1/10/21", 13, "Power Ball", 32, 35, 38, 51, 52 },
                    { 3, "1/10/21", 6, "Power Ball", 2, 35, 39, 47, 48 },
                    { 2, "1/10/21", 1, "Power Ball", 7, 17, 48, 53, 56 },
                    { 14, "1/10/21", 17, "Power Ball", 2, 40, 51, 64, 67 },
                    { 29, "1/10/21", 10, "Power Ball", 4, 20, 31, 33, 53 },
                    { 30, "1/10/21", 19, "Power Ball", 10, 24, 26, 51, 68 },
                    { 31, "1/10/21", 24, "Power Ball", 16, 30, 35, 39, 58 },
                    { 58, "1/10/21", 4, "Power Ball", 2, 11, 45, 49, 61 },
                    { 57, "1/10/21", 7, "Power Ball", 2, 43, 44, 54, 58 },
                    { 56, "1/10/21", 21, "Power Ball", 10, 23, 41, 53, 66 },
                    { 55, "1/10/21", 22, "Power Ball", 3, 4, 22, 33, 55 },
                    { 54, "1/10/21", 16, "Power Ball", 25, 36, 55, 60, 61 },
                    { 53, "1/10/21", 4, "Power Ball", 24, 31, 42, 52, 68 },
                    { 52, "1/10/21", 9, "Power Ball", 24, 41, 47, 57, 66 },
                    { 51, "1/10/21", 13, "Power Ball", 6, 22, 60, 62, 66 },
                    { 50, "1/10/21", 2, "Power Ball", 8, 10, 18, 33, 46 },
                    { 49, "1/10/21", 17, "Power Ball", 2, 4, 10, 47, 51 },
                    { 48, "1/10/21", 26, "Power Ball", 7, 17, 19, 44, 67 },
                    { 47, "1/10/21", 22, "Power Ball", 26, 30, 38, 57, 59 },
                    { 46, "1/10/21", 8, "Power Ball", 5, 31, 33, 51, 52 },
                    { 45, "1/10/21", 14, "Power Ball", 1, 24, 39, 53, 54 },
                    { 44, "1/10/21", 10, "Power Ball", 8, 12, 36, 46, 49 },
                    { 43, "1/10/21", 28, "Power Ball", 12, 15, 34, 37, 49 },
                    { 42, "1/10/21", 8, "Power Ball", 15, 40, 45, 57, 64 },
                    { 41, "1/10/21", 6, "Power Ball", 18, 27, 32, 39, 67 },
                    { 40, "1/10/21", 24, "Power Ball", 2, 34, 37, 46, 65 },
                    { 39, "1/10/21", 14, "Power Ball", 2, 7, 15, 37, 57 },
                    { 38, "1/10/21", 19, "Power Ball", 19, 23, 39, 59, 68 },
                    { 37, "1/10/21", 24, "Power Ball", 13, 16, 20, 35, 50 },
                    { 36, "1/10/21", 21, "Power Ball", 7, 20, 40, 45, 69 },
                    { 35, "1/10/21", 15, "Power Ball", 5, 39, 53, 54, 63 },
                    { 34, "1/10/21", 3, "Power Ball", 7, 19, 23, 54, 60 },
                    { 33, "1/10/21", 1, "Power Ball", 6, 8, 22, 39, 40 },
                    { 32, "1/10/21", 19, "Power Ball", 1, 5, 23, 24, 62 },
                    { 119, "1/10/21", 20, "Power Ball", 8, 28, 47, 50, 60 },
                    { 120, "1/10/21", 27, "Power Ball", 13, 27, 48, 49, 64 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drawings");
        }
    }
}
