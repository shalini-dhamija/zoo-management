using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooManagement.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Animals",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfAcquisition",
                table: "Animals",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateOfAcquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2001, 2, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1997, 9, 9, 23, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateOfAcquisition", "DateOfBirth" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfBirth",
                table: "Animals",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfAcquisition",
                table: "Animals",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateOfAcquisition", "DateOfBirth" },
                values: new object[] { new DateOnly(2001, 2, 3), new DateOnly(1997, 9, 10) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateOfAcquisition", "DateOfBirth" },
                values: new object[] { new DateOnly(2000, 1, 1), new DateOnly(1997, 10, 16) });
        }
    }
}
