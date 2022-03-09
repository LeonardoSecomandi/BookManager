using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.API.Data;

namespace BookManager.API.Models.Repositories
{
    public class ExtractBookFromGoogleApi
    {
        private readonly ApplicationDbContext _context;
        public ExtractBookFromGoogleApi(ApplicationDbContext context)
        {
            this._context = context;
        }
        
        public void ExtractBook(string Link)
        {

        }
    }
}
