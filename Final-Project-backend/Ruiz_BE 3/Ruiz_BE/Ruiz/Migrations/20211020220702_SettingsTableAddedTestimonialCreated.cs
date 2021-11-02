using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ruiz.Migrations
{
    public partial class SettingsTableAddedTestimonialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutUsContent",
                table: "Settings",
                maxLength: 600,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutUsPhoto",
                table: "Settings",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkdayFinishDay",
                table: "Settings",
                maxLength: 30,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkdayFinishTime",
                table: "Settings",
                maxLength: 30,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkdayStartDay",
                table: "Settings",
                maxLength: 30,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkdayStartTime",
                table: "Settings",
                maxLength: 30,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Blogs",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutUsContent",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "AboutUsPhoto",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WorkdayFinishDay",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WorkdayFinishTime",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WorkdayStartDay",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "WorkdayStartTime",
                table: "Settings");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "Blogs",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldMaxLength: 70);
        }
    }
}
