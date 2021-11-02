using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ruiz.Migrations
{
    public partial class TestimonialTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WorkdayStartTime",
                table: "Settings",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "WorkdayStartDay",
                table: "Settings",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "WorkdayFinishTime",
                table: "Settings",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "WorkdayFinishDay",
                table: "Settings",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkdayStartTime",
                table: "Settings",
                type: "datetime2",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkdayStartDay",
                table: "Settings",
                type: "datetime2",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkdayFinishTime",
                table: "Settings",
                type: "datetime2",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkdayFinishDay",
                table: "Settings",
                type: "datetime2",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
