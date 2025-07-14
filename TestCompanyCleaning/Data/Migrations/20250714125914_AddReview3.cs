using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCompanyCleaning.Migrations
{
    /// <inheritdoc />
    public partial class AddReview3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewComment",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Rating" },
                values: new object[] { new DateTime(2025, 7, 14, 17, 59, 14, 586, DateTimeKind.Local).AddTicks(2792), null });

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Rating" },
                values: new object[] { new DateTime(2025, 7, 14, 17, 59, 14, 586, DateTimeKind.Local).AddTicks(2795), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewComment",
                table: "RequestItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "RequestItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Rating" },
                values: new object[] { new DateTime(2025, 7, 14, 17, 38, 10, 131, DateTimeKind.Local).AddTicks(6130), null });

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Rating" },
                values: new object[] { new DateTime(2025, 7, 14, 17, 38, 10, 131, DateTimeKind.Local).AddTicks(6133), null });
        }
    }
}
