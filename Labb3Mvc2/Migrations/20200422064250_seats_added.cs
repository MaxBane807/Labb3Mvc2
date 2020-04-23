using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb3Mvc2.Migrations
{
    public partial class seats_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "Cars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seats",
                table: "Cars");
        }
    }
}
