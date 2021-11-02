using Microsoft.EntityFrameworkCore.Migrations;

namespace Ruiz.Migrations
{
    public partial class testimonialtablecreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 50, nullable: true),
                    FullName = table.Column<string>(maxLength: 50, nullable: true),
                    Position = table.Column<string>(maxLength: 50, nullable: true),
                    Text = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
