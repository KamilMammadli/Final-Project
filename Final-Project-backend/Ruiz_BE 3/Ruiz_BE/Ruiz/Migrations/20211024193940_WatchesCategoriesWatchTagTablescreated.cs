using Microsoft.EntityFrameworkCore.Migrations;

namespace Ruiz.Migrations
{
    public partial class WatchesCategoriesWatchTagTablescreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Watches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    Color = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 1500, nullable: true),
                    IsAvailable = table.Column<bool>(nullable: false),
                    IsNew = table.Column<bool>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Watches_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Watches_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WatchImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WatchId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchImages_Watches_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WatchTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WatchId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WatchTags_Watches_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Watches_BrandId",
                table: "Watches",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_CategoryId",
                table: "Watches",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchImages_WatchId",
                table: "WatchImages",
                column: "WatchId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchTags_TagId",
                table: "WatchTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchTags_WatchId",
                table: "WatchTags",
                column: "WatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WatchImages");

            migrationBuilder.DropTable(
                name: "WatchTags");

            migrationBuilder.DropTable(
                name: "Watches");
        }
    }
}
