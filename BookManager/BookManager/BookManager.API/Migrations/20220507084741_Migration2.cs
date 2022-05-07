using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManager.API.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Books",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: "07/05/2022");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2022, 5, 7, 10, 47, 41, 405, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2022, 5, 7, 10, 47, 41, 405, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2022, 5, 7, 10, 47, 41, 405, DateTimeKind.Local).AddTicks(1272));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Publisher",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: "02/05/2022");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2022, 5, 2, 14, 0, 40, 609, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2022, 5, 2, 14, 0, 40, 609, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2022, 5, 2, 14, 0, 40, 609, DateTimeKind.Local).AddTicks(4442));
        }
    }
}
