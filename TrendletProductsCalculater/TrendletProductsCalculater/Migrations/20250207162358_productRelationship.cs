using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrendletProductsCalculater.Migrations
{
    /// <inheritdoc />
    public partial class productRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "productstype",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_productstype_ProductId",
                table: "productstype",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_productstype_products_ProductId",
                table: "productstype",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productstype_products_ProductId",
                table: "productstype");

            migrationBuilder.DropIndex(
                name: "IX_productstype_ProductId",
                table: "productstype");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "productstype");
        }
    }
}
