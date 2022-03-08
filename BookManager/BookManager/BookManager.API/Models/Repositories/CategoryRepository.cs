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
    public class CategoryRepository : ICategoryInterface
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<AddCategoryResponse> AddCategory(Categories category)
        {
            var isBook = await _context.Books.FirstOrDefaultAsync(b => b.Id == category.BookId);
            if(isBook is null)
            {
                return new AddCategoryResponse()
                {
                    Success = false,
                    Message = "Libro non esistente",
                    Errors = null,
                    AddedCategory = null
                };
            }
            var result = await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            if (result.Entity is not null)
                return new AddCategoryResponse()
                {
                    Success = true,
                    Message = "Categoria aggiunta",
                    Errors = null,
                    AddedCategory = result.Entity
                };

            return new AddCategoryResponse()
            {
                Success = false,
                Message = "errore nell'aggiunta della categoria",
                Errors = null,
                AddedCategory = null
            };
        }
    }
}
