using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;

namespace BookManager.WEB.Services
{
    public interface IBookService
    {
        public Task<IEnumerable<Book>> GetBooks();
    }
}
