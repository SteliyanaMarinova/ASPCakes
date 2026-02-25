using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPCakes.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategodiesId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategodiesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategodiesId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesId",
                table: "Products",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoriesId",
                table: "Products",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoriesId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoriesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CategodiesId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategodiesId",
                table: "Products",
                column: "CategodiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategodiesId",
                table: "Products",
                column: "CategodiesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
