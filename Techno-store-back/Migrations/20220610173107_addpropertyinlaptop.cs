using Microsoft.EntityFrameworkCore.Migrations;

namespace Techno_store_back.Web.Migrations
{
    public partial class addpropertyinlaptop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Laptops",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Laptops",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Laptops");
        }
    }
}
