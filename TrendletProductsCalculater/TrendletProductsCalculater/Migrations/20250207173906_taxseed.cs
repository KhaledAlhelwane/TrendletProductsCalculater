using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrendletProductsCalculater.Migrations
{
    /// <inheritdoc />
    public partial class taxseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "taxes",
               columns: new[] { "Id", "Name", "Value" },
               values: new object[,]
               {
            { 1, "%8.15", 8.15 },  // Use "d" for double
            { 2, "%6.625", 6.625 },
            { 3, "لا يوجد ضريبة", 0 }  // Ensure 0 is treated as double
               }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "taxes",
               keyColumn: "Id",
               keyValues: new object[] { 1, 2, 3 }
           );
        }
    }
}
