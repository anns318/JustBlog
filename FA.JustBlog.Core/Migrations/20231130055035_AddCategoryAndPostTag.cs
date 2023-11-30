using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FA.JustBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryAndPostTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "Posts",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Posts",
                newName: "Id");

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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "PostId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(1820), "EF Post", "Entity Framework", 0 },
                    { 2, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(1835), "MVC Post", "MVC", 0 },
                    { 3, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(1836), "C# Post", "C#", 0 }
                });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "Id", "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 1 },
                    { 5, 2, 3 },
                    { 8, 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2007), "MVC", "MVC" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2011), "EF Core", "EF Core" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2012), "EF Framework", "EF Framework" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2013), "ADO.NET", "ADO.NET" },
                    { 5, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2014), "C#", "C#" },
                    { 6, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2015), ".Net", ".Net" },
                    { 7, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2016), "ASP.Net", "ASP.Net" },
                    { 8, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2017), "VB", "VB" },
                    { 9, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2017), "ASP.Net MVC", "ASP.Net MVC" },
                    { 10, new DateTime(2023, 11, 30, 12, 50, 35, 286, DateTimeKind.Local).AddTicks(2018), "RestApi", "RestApi" }
                });

            migrationBuilder.InsertData(
                table: "PostTag",
                columns: new[] { "Id", "PostId", "TagId" },
                values: new object[,]
                {
                    { 6, 3, 5 },
                    { 7, 3, 6 },
                    { 9, 4, 9 },
                    { 10, 5, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_PostId",
                table: "PostTag",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagId",
                table: "PostTag",
                column: "TagId");

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

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Posts",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Posts",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                newName: "IX_Posts_TagId");

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

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6686), "EF Post", "Entity Framework" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6699), "MVC Post", "MVC" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2023, 11, 30, 10, 23, 49, 638, DateTimeKind.Local).AddTicks(6700), "C# Post", "C#" });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
