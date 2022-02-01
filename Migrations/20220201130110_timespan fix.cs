using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseManagement.Migrations
{
    public partial class timespanfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartingTimeDB",
                table: "Courses",
                newName: "StartingTimeDb");

            migrationBuilder.RenameColumn(
                name: "StartingDateDB",
                table: "Courses",
                newName: "StartingDateDb");

            migrationBuilder.RenameColumn(
                name: "EndingDateDB",
                table: "Courses",
                newName: "EndingDateDb");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartingTimeDb",
                table: "Courses",
                type: "time",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartingDateDb",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndingDateDb",
                table: "Courses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Courses",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartingTimeDb",
                table: "Courses",
                newName: "StartingTimeDB");

            migrationBuilder.RenameColumn(
                name: "StartingDateDb",
                table: "Courses",
                newName: "StartingDateDB");

            migrationBuilder.RenameColumn(
                name: "EndingDateDb",
                table: "Courses",
                newName: "EndingDateDB");

            migrationBuilder.AlterColumn<string>(
                name: "StartingTimeDB",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "StartingDateDB",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EndingDateDB",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Courses",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);
        }
    }
}
