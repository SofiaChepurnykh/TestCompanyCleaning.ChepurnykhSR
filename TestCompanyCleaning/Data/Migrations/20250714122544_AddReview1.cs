using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCompanyCleaning.Migrations
{
    /// <inheritdoc />
    public partial class AddReview1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reviews_RequestItemId",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 17, 25, 43, 978, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 17, 25, 43, 978, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RequestItemId",
                table: "Reviews",
                column: "RequestItemId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reviews_RequestItemId",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 17, 0, 7, 130, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 14, 17, 0, 7, 130, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RequestItemId",
                table: "Reviews",
                column: "RequestItemId");
        }
    }
}
