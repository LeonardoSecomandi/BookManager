using BookManager.API.Data;
using BookManager.API.Models.DTOS.Requests;
using BookManager.API.Models.DTOS.Responses;
using BookManager.API.Models.Interfaces;
using BookManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.API.Models.Repositories
{
    public class BookRepository : IBookRepositoryInterface
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<BookResponseModel>> GetBooks()
        {
            var Books = await _context.Books.ToListAsync();
            var EleBookResponse = new List<BookResponseModel>();
            foreach(var Book in Books)
            {
                var Author = await _context.Authors.Where(a => a.BookId == Book.Id).ToListAsync();
                var Category = await _context.Categories.Where(c => c.BookId == Book.Id).ToListAsync();
                var Identifier = await _context.Identifiers.Where(i => i.BookId == Book.Id).ToListAsync();
                var Ratings = await _context.Ratings.Where(r => r.BookId == Book.Id).ToListAsync();

                double Ratingaverage = 0;
                if (Ratings.Count==0)
                    Ratingaverage = 0;
                else if(Ratings.Count!=0)
                 Ratingaverage = Ratings.Select(x => x.RatingValue).Average();

                EleBookResponse.Add(new BookResponseModel()
                {
                    Success = true,
                    Message = "Lista Libri Ricevuta",
                    Errors = null,
                    Book = Book,
                    RatingsAverage=Ratingaverage //non viene mappata da sola
                    //RatingAverage=RatingAverage
                    //Author = Author,
                    //Categories = Category,        ///Non so perche ma li mette già dentro l'oggetto Book
                    //Identifiers = Identifier
                }) ;
            }
            return EleBookResponse;
        }

        public async Task<BookResponseModel> GetBookById(int id)
        {
            var Book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
            if (Book is null)
                return new BookResponseModel()
                {
                    Success = false,
                    Message = "Nesssun libro associato a id " + id,
                    Book = null,
                    Errors = null
                };

            var Author = await _context.Authors.Where(a => a.BookId == Book.Id).ToListAsync();
            var Category = await _context.Categories.Where(c => c.BookId == Book.Id).ToListAsync();
            var Identifier = await _context.Identifiers.Where(i => i.BookId == Book.Id).ToListAsync();

            var Ratings = await _context.Ratings.Where(r => r.BookId == Book.Id).ToListAsync();
            double Ratingaverage = 0;
            if (Ratings.Count == 0)
                Ratingaverage = 0;
            else if (Ratings.Count != 0)
                Ratingaverage = Ratings.Select(x => x.RatingValue).Average();
            Book.RatingAverage = Ratingaverage;

            return new BookResponseModel()
            {
                Success = true,
                Message = "libro trovato",
                Book = Book,
                Errors = null
            };

        }

        public async Task<AddBookResponse> AddBook(AddBookRequest req)
        {
            var isBook = await _context.Books.FirstOrDefaultAsync(x => x.Titolo == req.Book.Titolo);
            if (isBook != null)
                return null;

            var result = await _context.AddAsync(req.Book);
            await _context.SaveChangesAsync();
            if (result.Entity is not null)
            {
                return new AddBookResponse()
                {
                    Success = true,
                    Message = "Libro aggiunto",
                    Errors = null,
                    AddedBook = result.Entity
                };
            }
            return new AddBookResponse()
            {
                Success = true,
                Message = "errore nell'aggiunta del libro",
                Errors = null,
                AddedBook = null
            };
        }
    }
}
