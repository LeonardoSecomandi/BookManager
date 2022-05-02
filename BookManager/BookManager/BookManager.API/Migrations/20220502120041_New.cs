using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManager.API.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ratingid",
                table: "Reviews",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Ratingid",
                table: "Reviews",
                column: "Ratingid");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Ratings_Ratingid",
                table: "Reviews",
                column: "Ratingid",
                principalTable: "Ratings",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Ratings_Ratingid",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_Ratingid",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Ratingid",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: "01/05/2022");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2022, 5, 1, 19, 30, 12, 503, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2022, 5, 1, 19, 30, 12, 503, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2022, 5, 1, 19, 30, 12, 503, DateTimeKind.Local).AddTicks(5290));
        }
    }
}
