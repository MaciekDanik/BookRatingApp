using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookRating_App.Migrations
{
    /// <inheritdoc />
    public partial class rateCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rateCount",
                table: "Book",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rateCount",
                table: "Book");
        }
    }
}
