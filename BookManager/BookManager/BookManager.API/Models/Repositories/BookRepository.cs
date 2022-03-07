﻿using BookManager.API.Data;
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
                var Ratingaverage = Ratings.Select(x => x.RatingValue).Average();

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

            return new BookResponseModel()
            {
                Success = true,
                Message = "libro trovato",
                Book = Book,
                Errors = null
            };

        }
    }
}
