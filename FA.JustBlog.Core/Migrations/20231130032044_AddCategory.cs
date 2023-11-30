using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FA.JustBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9655), "EF Post", "Entity Framework" },
                    { 2, new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9669), "MVC Post", "MVC" },
                    { 3, new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9670), "C# Post", "C#" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 8, 55, 43, 905, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 8, 55, 43, 905, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 8, 55, 43, 905, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 8, 55, 43, 905, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 8, 55, 43, 905, DateTimeKind.Local).AddTicks(1468));
        }
    }
}
