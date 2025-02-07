using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrendletProductsCalculater.Migrations
{
    /// <inheritdoc />
    public partial class productTypeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "productstype",
                columns: new[] { "Id", "Name", "AddedPrice", "ProductId" },
                values: new object[,]
                {
            // Accessories (اكسسوارات) - ProductId: 5856DBF8-6937-4F2D-8797-55B49731AB68
            { 1, "ساعة نسائي", 120, 4 },
            { 2, "ساعة رجالي", 120, 4 },
            { 3, "حزام", 120, 4 },
            { 4, "اسوارة", 120, 4 },
            { 5, "خاتم", 120, 4 },
            { 6, "حلق نسائي", 120, 4 },
            { 7, "سلسال", 120, 4 },

            // Clothing (ملابس) - ProductId: 87D5927E-B449-4454-9B21-743F4E797BB4
            { 8, "تیشرت نسائي", 130,3 },
            { 9, "تیشرت رجالي", 130,3 },
            { 10, "بلوفر نسائي", 190,3 },
            { 11, "بلوفر رجالي", 190,3 },
            { 12, "فستان", 300,3 },
            { 13, "بناتي", 120,3 },
            { 14, "ولادي", 120,3 },
            { 15, "جاكیت نسائي", 300,3 },
            { 16, "جاكیت رجالي", 300,3 },
            { 17, "بالطو نسائي", 300,3 }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "productstype",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }
            );
        }
    }
}
