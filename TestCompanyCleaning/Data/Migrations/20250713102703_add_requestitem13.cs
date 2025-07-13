using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCompanyCleaning.Migrations
{
    /// <inheritdoc />
    public partial class add_requestitem13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CarpetСleaning",
                table: "RequestItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Disinfection",
                table: "RequestItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GarbageRemoval",
                table: "RequestItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeEquipmentCleaning",
                table: "RequestItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WetСleaning",
                table: "RequestItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarpetСleaning", "CreatedDate", "Disinfection", "GarbageRemoval", "OfficeEquipmentCleaning", "WetСleaning" },
                values: new object[] { false, new DateTime(2025, 7, 13, 15, 27, 3, 535, DateTimeKind.Local).AddTicks(8033), false, false, false, false });

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarpetСleaning", "CreatedDate", "Disinfection", "GarbageRemoval", "OfficeEquipmentCleaning", "WetСleaning" },
                values: new object[] { false, new DateTime(2025, 7, 13, 15, 27, 3, 535, DateTimeKind.Local).AddTicks(8035), false, false, false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarpetСleaning",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "Disinfection",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "GarbageRemoval",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "OfficeEquipmentCleaning",
                table: "RequestItems");

            migrationBuilder.DropColumn(
                name: "WetСleaning",
                table: "RequestItems");

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 15, 13, 46, 737, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 15, 13, 46, 737, DateTimeKind.Local).AddTicks(6934));
        }
    }
}
