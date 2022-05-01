using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManager.API.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titolo = table.Column<string>(type: "TEXT", nullable: false),
                    Publisher = table.Column<string>(type: "TEXT", nullable: false),
                    PublishDate = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PageCount = table.Column<int>(type: "INTEGER", nullable: false),
                    MaturityRating = table.Column<string>(type: "TEXT", nullable: false),
                    ContentVersion = table.Column<string>(type: "TEXT", nullable: false),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: false),
                    Language = table.Column<string>(type: "TEXT", nullable: false),
                    RatingAverage = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    AuthorName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identifiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Indentifier = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifiers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identifiers_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingValue = table.Column<int>(type: "INTEGER", nullable: false),
                    RatingDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ratings_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discussions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    DiscussionTitle = table.Column<string>(type: "TEXT", nullable: false),
                    DiscussionPublishDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discussions_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReviewStars = table.Column<int>(type: "INTEGER", nullable: false),
                    ReviewContent = table.Column<string>(type: "TEXT", nullable: false),
                    ReviewPublishDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reviews_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentContent = table.Column<string>(type: "TEXT", nullable: false),
                    UpVotes = table.Column<int>(type: "INTEGER", nullable: false),
                    DownVotes = table.Column<int>(type: "INTEGER", nullable: false),
                    AnswerCommentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentId = table.Column<int>(type: "INTEGER", nullable: true),
                    DiscussionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Discussions_DiscussionId",
                        column: x => x.DiscussionId,
                        principalTable: "Discussions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ContentVersion", "Description", "ImageLink", "Language", "MaturityRating", "PageCount", "PublishDate", "Publisher", "RatingAverage", "Titolo" },
                values: new object[] { 1, "COntent versione Demo", "Descrizione libro di prova", "Image Link Demo", "IT", "Maturity rating Demo", 320, "01/05/2022", "Publisher Demo", 0.0, "Libro Demo1" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AnswerCommentId", "CommentContent", "CommentId", "DiscussionId", "DownVotes", "UpVotes", "UserId" },
                values: new object[] { 1, 0, "Comment Demo 1 Comment Demo 1 Comment Demo 1 Comment Demo 1", null, null, 0, 0, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AnswerCommentId", "CommentContent", "CommentId", "DiscussionId", "DownVotes", "UpVotes", "UserId" },
                values: new object[] { 2, 1, "Risposta Comment Demo1", null, null, 0, 1, 2 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AuthorName", "BookId" },
                values: new object[] { 1, "Autore Demo1", 1 });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AuthorName", "BookId" },
                values: new object[] { 2, "Autore Demo2", 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BookId", "CategoryName" },
                values: new object[] { 1, 1, "CategoryName1" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BookId", "CategoryName" },
                values: new object[] { 2, 1, "CategoryName2" });

            migrationBuilder.InsertData(
                table: "Identifiers",
                columns: new[] { "Id", "BookId", "Indentifier", "Type" },
                values: new object[] { 1, 1, "IDENTIFIER DEMO 1", "Identifier Type1Demo" });

            migrationBuilder.InsertData(
                table: "Identifiers",
                columns: new[] { "Id", "BookId", "Indentifier", "Type" },
                values: new object[] { 2, 1, "IDENTIFIER DEMO 1", "Identifier Type1Demo2" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "id", "BookId", "RatingDate", "RatingValue", "UserId" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 1, 19, 30, 12, 503, DateTimeKind.Local).AddTicks(4505), 7, 1 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "id", "BookId", "RatingDate", "RatingValue", "UserId" },
                values: new object[] { 2, 1, new DateTime(2022, 5, 1, 19, 30, 12, 503, DateTimeKind.Local).AddTicks(5254), 6, 2 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "id", "BookId", "RatingDate", "RatingValue", "UserId" },
                values: new object[] { 3, 1, new DateTime(2022, 5, 1, 19, 30, 12, 503, DateTimeKind.Local).AddTicks(5290), 8, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_BookId",
                table: "Authors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BookId",
                table: "Categories",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentId",
                table: "Comments",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DiscussionId",
                table: "Comments",
                column: "DiscussionId");

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_ItemId",
                table: "Discussions",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Identifiers_BookId",
                table: "Identifiers",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_BookId",
                table: "Ratings",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ItemId",
                table: "Reviews",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Identifiers");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Discussions");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
