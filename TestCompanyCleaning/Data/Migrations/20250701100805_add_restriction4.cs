using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCompanyCleaning.Migrations
{
    /// <inheritdoc />
    public partial class add_restriction4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Services",
                table: "RequestItems");

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 1, 15, 8, 5, 227, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 1, 15, 8, 5, 227, DateTimeKind.Local).AddTicks(6019));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Services",
                table: "RequestItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Services" },
                values: new object[] { new DateTime(2025, 7, 1, 14, 43, 56, 227, DateTimeKind.Local).AddTicks(5153), "[\"\\u0412\\u043B\\u0430\\u0436\\u043D\\u0430\\u044F \\u0443\\u0431\\u043E\\u0440\\u043A\\u0430\",\"\\u0412\\u044B\\u043D\\u043E\\u0441 \\u043C\\u0443\\u0441\\u043E\\u0440\\u0430\"]" });

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Services" },
                values: new object[] { new DateTime(2025, 7, 1, 14, 43, 56, 227, DateTimeKind.Local).AddTicks(5157), "[\"\\u041E\\u0447\\u0438\\u0441\\u0442\\u043A\\u0430 \\u043E\\u0444\\u0438\\u0441\\u043D\\u043E\\u0439 \\u0442\\u0435\\u0445\\u043D\\u0438\\u043A\\u0438\"]" });
        }
    }
}
