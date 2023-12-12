using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class addShortDescForPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ShortDescription" },
                values: new object[] { new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6757), "Post 1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ShortDescription" },
                values: new object[] { new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6766), "Short post 2" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ShortDescription" },
                values: new object[] { new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6767), "Short post 3" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ShortDescription" },
                values: new object[] { new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6769), "Short post 4" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ShortDescription" },
                values: new object[] { new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6770), "Short post 5" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 15, 14, 7, 469, DateTimeKind.Local).AddTicks(6732));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 12, 8, 18, 12, 165, DateTimeKind.Local).AddTicks(1753));
        }
    }
}
