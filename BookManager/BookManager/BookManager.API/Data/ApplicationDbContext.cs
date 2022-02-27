using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;

namespace BookManager.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<Identifiers> Identifiers { get; set; }
        public DbSet<Review> Reviews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>().HasData(new Book()
            {
                Id = 1,
                Description = "Descrizione libro di prova",
                ImageLink = "Image Link Demo",
                ContentVersion = "COntent versione Demo",
                Language = "IT",
                MaturityRating = "Maturity rating Demo",
                PageCount = 320,
                PublishDate = DateTime.Now.ToShortDateString(),
                Publisher = "Publisher Demo",
                Titolo = "Libro Demo1",
            });

            modelBuilder.Entity<Author>().HasData(new Author()
            {
                AuthorName = "Autore Demo1",
                BookId = 1,
                Id = 1
            });

            modelBuilder.Entity<Author>().HasData(new Author()
            {
                AuthorName = "Autore Demo2",
                BookId = 1,
                Id = 2
            });

            modelBuilder.Entity<Categories>().HasData(new Categories()
            {
                Id = 1,
                BookId = 1,
                CategoryName = "CategoryName1"
            });
            modelBuilder.Entity<Categories>().HasData(new Categories()
            {
                Id = 2,
                BookId = 1,
                CategoryName = "CategoryName2"
            });

            modelBuilder.Entity<Identifiers>().HasData(new Identifiers()
            {
                BookId = 1,
                Id = 1,
                Indentifier = "IDENTIFIER DEMO 1",
                Type = "Identifier Type1Demo"
            });
            modelBuilder.Entity<Identifiers>().HasData(new Identifiers()
            {
                BookId = 1,
                Id = 2,
                Indentifier = "IDENTIFIER DEMO 1",
                Type = "Identifier Type1Demo2"
            });
        }

    }
}
