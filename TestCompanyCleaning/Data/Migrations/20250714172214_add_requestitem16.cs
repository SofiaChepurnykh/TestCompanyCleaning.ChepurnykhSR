using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCompanyCleaning.Migrations
{
    /// <inheritdoc />
    public partial class add_requestitem16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewComment",
                table: "RequestItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Rating", "ReviewComment" },
                values: new object[] { new DateTime(2025, 7, 14, 22, 22, 14, 74, DateTimeKind.Local).AddTicks(7041), null, null });

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Rating", "ReviewComment" },
                values: new object[] { new DateTime(2025, 7, 14, 22, 22, 14, 74, DateTimeKind.Local).AddTicks(7045), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "ReviewComment",
                table: "RequestItems");

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 18, 59, 27, 801, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 18, 59, 27, 801, DateTimeKind.Local).AddTicks(5641));
        }
    }
}
