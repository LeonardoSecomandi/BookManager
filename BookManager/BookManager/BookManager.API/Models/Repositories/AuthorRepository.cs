using BookManager.API.Data;
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
    public class AuthorRepository : IAuthorInterface
    {
        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<AddAuthorResponse> AddAuthor(Author author)
        {
            var isBook = await _context.Books.FirstOrDefaultAsync(b => b.Id == author.BookId);
            if (isBook is null)
                return new AddAuthorResponse()
                {
                    Success = false,
                    Message = "Libro non trovato",
                    Errors = null,
                    AddedAuthor = null
                };
            var result = await _context.AddAsync(author);
            await _context.SaveChangesAsync();
            if (result.Entity is not null)
                return new AddAuthorResponse()
                {
                    Success = true,
                    Message = "Autore aggiunto",
                    Errors = null,
                    AddedAuthor = result.Entity
                };
            return new AddAuthorResponse()
            {
                Success = false,
                Message = "errore nell'aggiunta dell'autore",
                Errors = null,
                AddedAuthor = null
            };
        }
    }
}
