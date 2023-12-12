using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FA.JustBlog.Core.Migrations
{
    /// <inheritdoc />
    public partial class addCommentUserMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AddColumn<bool>(
                name: "IsAnnonymous",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "IsAnnonymous",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedDate", "PostId" },
                values: new object[,]
                {
                    { 1, "Post 1 rat hay, tuyet voi", new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(766), 1 },
                    { 2, "Post 1 rat hay, tuyet voi 2", new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(768), 1 },
                    { 3, "Post 1 rat hay, tuyet voi 3", new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(769), 1 },
                    { 4, "Post 2 rat hay, tuyet voi", new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(770), 2 },
                    { 5, "Post 2 rat hay, tuyet voi 2", new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(771), 2 },
                    { 6, "Post 3 rat hay, tuyet voi", new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(771), 3 },
                    { 7, "Post 4 rat hay, tuyet voi", new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(772), 4 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 10, 14, 8, 52, 723, DateTimeKind.Local).AddTicks(685));
        }
    }
}
