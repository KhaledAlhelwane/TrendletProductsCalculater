using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrendletProductsCalculater.Migrations
{
    /// <inheritdoc />
    public partial class productsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "ProductId", "ProductName" },
                values: new object[,]
                {
                { 1, Guid.NewGuid().ToString(), "حقیبة" },
                { 2, Guid.NewGuid().ToString(), "حذاء" },
                { 3, Guid.NewGuid().ToString(), "ملابس" },
                { 4, Guid.NewGuid().ToString(), "اكسسوارات" }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4 }
            );
        }
    }
}
