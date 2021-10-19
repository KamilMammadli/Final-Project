using Microsoft.EntityFrameworkCore.Migrations;

namespace Ruiz.Migrations
{
    public partial class BlogTablecreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 40, nullable: false),
                    DetailImage = table.Column<string>(maxLength: 40, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<string>(maxLength: 70, nullable: true),
                    AuthorName = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
