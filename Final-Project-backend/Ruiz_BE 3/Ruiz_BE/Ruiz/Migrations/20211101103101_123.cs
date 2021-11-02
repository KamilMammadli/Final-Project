using Microsoft.EntityFrameworkCore.Migrations;

namespace Ruiz.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogTags_Tags_TagId",
                table: "BlogTags");

            migrationBuilder.DropIndex(
                name: "IX_BlogTags_TagId",
                table: "BlogTags");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "BlogTags");

            migrationBuilder.AddColumn<int>(
                name: "BTagId",
                table: "BlogTags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BTags", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_BTagId",
                table: "BlogTags",
                column: "BTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTags_BTags_BTagId",
                table: "BlogTags",
                column: "BTagId",
                principalTable: "BTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogTags_BTags_BTagId",
                table: "BlogTags");

            migrationBuilder.DropTable(
                name: "BTags");

            migrationBuilder.DropIndex(
                name: "IX_BlogTags_BTagId",
                table: "BlogTags");

            migrationBuilder.DropColumn(
                name: "BTagId",
                table: "BlogTags");

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "BlogTags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_TagId",
                table: "BlogTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogTags_Tags_TagId",
                table: "BlogTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
