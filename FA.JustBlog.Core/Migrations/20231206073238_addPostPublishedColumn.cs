using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class addPostPublishedColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsPublished" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4167), true });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsPublished" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4171), true });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsPublished" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4173), true });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsPublished", "View" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4174), false, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsPublished", "View" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4176), false, 0 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4143));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "View" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4887), 50 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "View" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4888), 111 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 28, 14, 590, DateTimeKind.Local).AddTicks(4821));
        }
    }
}
