using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestCompanyCleaning.Migrations
{
    /// <inheritdoc />
    public partial class add_requestitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Services = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RequestItems",
                columns: new[] { "Id", "Comment", "CreatedDate", "FullName", "OfficeAddress", "PhoneNumber", "RequestedDateTime", "Room", "Services" },
                values: new object[,]
                {
                    { 1, "Пожалуйста, уделите внимание углам", new DateTime(2025, 6, 30, 23, 14, 26, 236, DateTimeKind.Local).AddTicks(5883), "Иванов Иван Иванович", "Г. Тестовик, ул. Первая, д. 1", "89111111111", new DateTime(2025, 7, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), "1", "[\"\\u0412\\u043B\\u0430\\u0436\\u043D\\u0430\\u044F \\u0443\\u0431\\u043E\\u0440\\u043A\\u0430\",\"\\u0412\\u044B\\u043D\\u043E\\u0441 \\u043C\\u0443\\u0441\\u043E\\u0440\\u0430\"]" },
                    { 2, "4 компьютера", new DateTime(2025, 6, 30, 23, 14, 26, 236, DateTimeKind.Local).AddTicks(5886), "Петров Петр Петрович", "Г. Тестовик, ул. Вторая, д. 2", "89222222222", new DateTime(2025, 7, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), "2", "[\"\\u041E\\u0447\\u0438\\u0441\\u0442\\u043A\\u0430 \\u043E\\u0444\\u0438\\u0441\\u043D\\u043E\\u0439 \\u0442\\u0435\\u0445\\u043D\\u0438\\u043A\\u0438\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestItems");
        }
    }
}
