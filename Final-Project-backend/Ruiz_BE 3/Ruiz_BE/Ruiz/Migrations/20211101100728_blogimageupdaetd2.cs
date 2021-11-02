using Microsoft.EntityFrameworkCore.Migrations;

namespace Ruiz.Migrations
{
    public partial class blogimageupdaetd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailImage",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "SmallImage",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetailImage",
                table: "Blogs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SmallImage",
                table: "Blogs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
