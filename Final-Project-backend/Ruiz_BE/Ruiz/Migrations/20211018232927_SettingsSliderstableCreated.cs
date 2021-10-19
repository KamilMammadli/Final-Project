using Microsoft.EntityFrameworkCore.Migrations;

namespace Ruiz.Migrations
{
    public partial class SettingsSliderstableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderLogo = table.Column<string>(maxLength: 30, nullable: true),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 25, nullable: true),
                    Fax = table.Column<string>(maxLength: 25, nullable: true),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    FbIcon = table.Column<string>(maxLength: 50, nullable: true),
                    TwitterIcon = table.Column<string>(maxLength: 50, nullable: true),
                    InstagramIcon = table.Column<string>(maxLength: 50, nullable: true),
                    LinkedinIcon = table.Column<string>(maxLength: 50, nullable: true),
                    RssIcon = table.Column<string>(maxLength: 50, nullable: true),
                    Paymentmethods = table.Column<string>(maxLength: 30, nullable: true),
                    GooglePlayImg = table.Column<string>(maxLength: 30, nullable: true),
                    AppStoreImg = table.Column<string>(maxLength: 30, nullable: true),
                    Banner1 = table.Column<string>(maxLength: 20, nullable: true),
                    Banner2 = table.Column<string>(maxLength: 20, nullable: true),
                    Banner3 = table.Column<string>(maxLength: 20, nullable: true),
                    Banner4 = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BgImage = table.Column<string>(maxLength: 40, nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    SubTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Content = table.Column<string>(maxLength: 150, nullable: true),
                    SubTitle2 = table.Column<string>(maxLength: 50, nullable: true),
                    Order = table.Column<int>(nullable: false),
                    RedirectUrl = table.Column<string>(maxLength: 50, nullable: true),
                    BtnText = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
