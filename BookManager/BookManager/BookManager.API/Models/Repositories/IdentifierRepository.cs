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
    public class IdentifierRepository : IidentifierInterface
    {

        private readonly ApplicationDbContext _context;
        public IdentifierRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<AddIdentifierResponse> AddIdentifier(Identifiers identifiers)
        {
            var ispresent = await _context.Identifiers.FirstOrDefaultAsync(i => i.Indentifier == identifiers.Indentifier);
            if (ispresent != null)
                return new AddIdentifierResponse()
                {
                    Success = false,
                    Message = "Identificativo gia presente",
                    AddedIdentifier = null,
                    Errors = null
                };

            var isBook = await _context.Books.FirstOrDefaultAsync(x => x.Id == identifiers.BookId);
            if(isBook is null)
            {
                return new AddIdentifierResponse()
                {
                    Success = false,
                    Message = "libro non presente",
                    AddedIdentifier = null,
                    Errors = null
                };
            }

            var result = await _context.AddAsync(identifiers);
            await _context.SaveChangesAsync();
            if (result.Entity != null)
                return new AddIdentifierResponse()
                {
                    Success = true,
                    Message = "Identificativo aggiunto",
                    Errors = null,
                    AddedIdentifier = result.Entity
                };

            return new AddIdentifierResponse()
            {
                Success = false,
                Message = "Identificativo non aggiunto",
                AddedIdentifier = null,
                Errors = null
            };
        }
    }
}
