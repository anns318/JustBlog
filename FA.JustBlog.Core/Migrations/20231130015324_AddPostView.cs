using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FA.JustBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddPostView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostTitle",
                table: "Posts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "PostContent",
                table: "Posts",
                newName: "Content");

            migrationBuilder.AddColumn<int>(
                name: "View",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "CreatedDate", "Title", "View" },
                values: new object[,]
                {
                    { 1, "This is my first post", new DateTime(2023, 11, 30, 8, 53, 24, 233, DateTimeKind.Local).AddTicks(3796), "Post 1", 100 },
                    { 2, "This is my first post", new DateTime(2023, 11, 30, 8, 53, 24, 233, DateTimeKind.Local).AddTicks(3813), "Post 3", 95 },
                    { 3, "This is my first post", new DateTime(2023, 11, 30, 8, 53, 24, 233, DateTimeKind.Local).AddTicks(3815), "Post 4", 20 },
                    { 4, "This is my first post", new DateTime(2023, 11, 30, 8, 53, 24, 233, DateTimeKind.Local).AddTicks(3816), "Post 5", 50 },
                    { 5, "This is my first post", new DateTime(2023, 11, 30, 8, 53, 24, 233, DateTimeKind.Local).AddTicks(3816), "Post 2", 111 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "View",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Posts",
                newName: "PostTitle");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Posts",
                newName: "PostContent");
        }
    }
}
