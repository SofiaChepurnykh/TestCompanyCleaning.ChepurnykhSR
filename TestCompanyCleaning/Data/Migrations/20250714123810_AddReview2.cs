using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCompanyCleaning.Migrations
{
    /// <inheritdoc />
    public partial class AddReview2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "RequestItems",
                type: "int",
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
                values: new object[] { new DateTime(2025, 7, 14, 17, 38, 10, 131, DateTimeKind.Local).AddTicks(6130), null, null });

            migrationBuilder.UpdateData(
                table: "RequestItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Rating", "ReviewComment" },
                values: new object[] { new DateTime(2025, 7, 14, 17, 38, 10, 131, DateTimeKind.Local).AddTicks(6133), null, null });
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

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestItemId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_RequestItems_RequestItemId",
                        column: x => x.RequestItemId,
                        principalTable: "RequestItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
    }
}
