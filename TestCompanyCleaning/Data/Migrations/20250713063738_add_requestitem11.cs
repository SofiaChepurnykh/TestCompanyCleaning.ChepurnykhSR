using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestCompanyCleaning.Migrations
{
    /// <inheritdoc />
    public partial class add_requestitem11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedServices");

            migrationBuilder.DropTable(
                name: "CleaningServices");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CleaningServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelectedServices",
                columns: table => new
                {
                    RequestItemId = table.Column<int>(type: "int", nullable: false),
                    CleaningServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedServices", x => new { x.RequestItemId, x.CleaningServiceId });
                    table.ForeignKey(
                        name: "FK_SelectedServices_CleaningServices_CleaningServiceId",
                        column: x => x.CleaningServiceId,
                        principalTable: "CleaningServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedServices_RequestItems_RequestItemId",
                        column: x => x.RequestItemId,
                        principalTable: "RequestItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CleaningServices",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Влажная уборка" },
                    { 2, "Вынос мусора" },
                    { 3, "Мойка окон" },
                    { 4, "Очистка офисной техники" }
                });

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 11, 19, 21, 82, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 7, 13, 11, 19, 21, 82, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.CreateIndex(
                name: "IX_SelectedServices_CleaningServiceId",
                table: "SelectedServices",
                column: "CleaningServiceId");
        }
    }
}
