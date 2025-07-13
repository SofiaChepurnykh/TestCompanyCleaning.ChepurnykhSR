using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCompanyCleaning.Migrations
{
    /// <inheritdoc />
    public partial class add_requestitem12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "WindowWashing",
                table: "RequestItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "WindowWashing" },
                values: new object[] { new DateTime(2025, 7, 13, 15, 13, 46, 737, DateTimeKind.Local).AddTicks(6931), true });

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "WindowWashing" },
                values: new object[] { new DateTime(2025, 7, 13, 15, 13, 46, 737, DateTimeKind.Local).AddTicks(6934), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WindowWashing",
                table: "RequestItems");

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 11, 37, 38, 53, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 11, 37, 38, 53, DateTimeKind.Local).AddTicks(3683));
        }
    }
}
