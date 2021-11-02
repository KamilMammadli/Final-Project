using Microsoft.EntityFrameworkCore.Migrations;

namespace Ruiz.Migrations
{
    public partial class _12345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.CreateTable(
                name: "BlogBTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(nullable: false),
                    BTagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogBTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogBTags_BTags_BTagId",
                        column: x => x.BTagId,
                        principalTable: "BTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogBTags_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogBTags_BTagId",
                table: "BlogBTags",
                column: "BTagId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogBTags_BlogId",
                table: "BlogBTags",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogBTags");

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BTagId = table.Column<int>(type: "int", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogTags_BTags_BTagId",
                        column: x => x.BTagId,
                        principalTable: "BTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogTags_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_BTagId",
                table: "BlogTags",
                column: "BTagId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_BlogId",
                table: "BlogTags",
                column: "BlogId");
        }
    }
}
