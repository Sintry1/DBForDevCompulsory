using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddProductRatingsAndForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating_Id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRatings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Rating_Id",
                table: "Products",
                column: "Rating_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductRatings_Rating_Id",
                table: "Products",
                column: "Rating_Id",
                principalTable: "ProductRatings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductRatings_Rating_Id",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductRatings");

            migrationBuilder.DropIndex(
                name: "IX_Products_Rating_Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Rating_Id",
                table: "Products");
        }
    }
}
