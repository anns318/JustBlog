using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FA.JustBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentTablr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedDate", "PostId" },
                values: new object[,]
                {
                    { 1, "Post 1 rat hay, tuyet voi", new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5399), 1 },
                    { 2, "Post 1 rat hay, tuyet voi 2", new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5402), 1 },
                    { 3, "Post 1 rat hay, tuyet voi 3", new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5403), 1 },
                    { 4, "Post 2 rat hay, tuyet voi", new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5404), 2 },
                    { 5, "Post 2 rat hay, tuyet voi 2", new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5405), 2 },
                    { 6, "Post 3 rat hay, tuyet voi", new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5406), 3 },
                    { 7, "Post 4 rat hay, tuyet voi", new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5407), 4 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 7, 9, 18, 28, 319, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

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
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 14, 32, 37, 828, DateTimeKind.Local).AddTicks(4176));

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
    }
}
