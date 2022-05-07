﻿// <auto-generated />
using System;
using BookManager.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookManager.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BookManager.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorName = "Autore Demo1",
                            BookId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorName = "Autore Demo2",
                            BookId = 1
                        });
                });

            modelBuilder.Entity("BookManager.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContentVersion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaturityRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublishDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.Property<double>("RatingAverage")
                        .HasColumnType("REAL");

                    b.Property<string>("Titolo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContentVersion = "COntent versione Demo",
                            Description = "Descrizione libro di prova",
                            ImageLink = "Image Link Demo",
                            Language = "IT",
                            MaturityRating = "Maturity rating Demo",
                            PageCount = 320,
                            PublishDate = "07/05/2022",
                            Publisher = "Publisher Demo",
                            RatingAverage = 0.0,
                            Titolo = "Libro Demo1"
                        });
                });

            modelBuilder.Entity("BookManager.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CategoryName = "CategoryName1"
                        },
                        new
                        {
                            Id = 2,
                            BookId = 1,
                            CategoryName = "CategoryName2"
                        });
                });

            modelBuilder.Entity("BookManager.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnswerCommentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CommentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DiscussionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DownVotes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UpVotes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("DiscussionId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnswerCommentId = 0,
                            CommentContent = "Comment Demo 1 Comment Demo 1 Comment Demo 1 Comment Demo 1",
                            DownVotes = 0,
                            UpVotes = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AnswerCommentId = 1,
                            CommentContent = "Risposta Comment Demo1",
                            DownVotes = 0,
                            UpVotes = 1,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("BookManager.Models.Discussion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DiscussionPublishDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DiscussionTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Discussions");
                });

            modelBuilder.Entity("BookManager.Models.Identifiers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Indentifier")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Identifiers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            Indentifier = "IDENTIFIER DEMO 1",
                            Type = "Identifier Type1Demo"
                        },
                        new
                        {
                            Id = 2,
                            BookId = 1,
                            Indentifier = "IDENTIFIER DEMO 1",
                            Type = "Identifier Type1Demo2"
                        });
                });

            modelBuilder.Entity("BookManager.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("BookManager.Models.Ratings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("RatingValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("BookId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            id = 1,
                            BookId = 1,
                            RatingDate = new DateTime(2022, 5, 7, 10, 47, 41, 405, DateTimeKind.Local).AddTicks(558),
                            RatingValue = 7,
                            UserId = 1
                        },
                        new
                        {
                            id = 2,
                            BookId = 1,
                            RatingDate = new DateTime(2022, 5, 7, 10, 47, 41, 405, DateTimeKind.Local).AddTicks(1239),
                            RatingValue = 6,
                            UserId = 2
                        },
                        new
                        {
                            id = 3,
                            BookId = 1,
                            RatingDate = new DateTime(2022, 5, 7, 10, 47, 41, 405, DateTimeKind.Local).AddTicks(1272),
                            RatingValue = 8,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("BookManager.Models.Review", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Ratingid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReviewContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReviewPublishDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ReviewStars")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("ItemId");

                    b.HasIndex("Ratingid");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BookManager.Models.Author", b =>
                {
                    b.HasOne("BookManager.Models.Book", "Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookManager.Models.Categories", b =>
                {
                    b.HasOne("BookManager.Models.Book", null)
                        .WithMany("Categories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookManager.Models.Comment", b =>
                {
                    b.HasOne("BookManager.Models.Comment", null)
                        .WithMany("Answers")
                        .HasForeignKey("CommentId");

                    b.HasOne("BookManager.Models.Discussion", null)
                        .WithMany("DiscussionComments")
                        .HasForeignKey("DiscussionId");
                });

            modelBuilder.Entity("BookManager.Models.Discussion", b =>
                {
                    b.HasOne("BookManager.Models.Item", null)
                        .WithMany("ItemDiscussionList")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookManager.Models.Identifiers", b =>
                {
                    b.HasOne("BookManager.Models.Book", null)
                        .WithMany("IndustryIdentifiers")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookManager.Models.Ratings", b =>
                {
                    b.HasOne("BookManager.Models.Book", null)
                        .WithMany("Ratings")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookManager.Models.Review", b =>
                {
                    b.HasOne("BookManager.Models.Item", null)
                        .WithMany("ItemReviewList")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManager.Models.Ratings", "Rating")
                        .WithMany()
                        .HasForeignKey("Ratingid");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("BookManager.Models.Book", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Categories");

                    b.Navigation("IndustryIdentifiers");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("BookManager.Models.Comment", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("BookManager.Models.Discussion", b =>
                {
                    b.Navigation("DiscussionComments");
                });

            modelBuilder.Entity("BookManager.Models.Item", b =>
                {
                    b.Navigation("ItemDiscussionList");

                    b.Navigation("ItemReviewList");
                });
#pragma warning restore 612, 618
        }
    }
}
