using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FA.JustBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class EditTableCategoryNameIntoTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Posts",
                newName: "TagId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                newName: "IX_Posts_TagId");

            migrationBuilder.CreateTable(
                name: "Tags",
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
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6686), "EF Post", "Entity Framework" },
                    { 2, new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6699), "MVC Post", "MVC" },
                    { 3, new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6700), "C# Post", "C#" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "Posts",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_TagId",
                table: "Posts",
                newName: "IX_Posts_CategoryId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 10, 20, 44, 1, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_CategoryId",
                table: "Posts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
