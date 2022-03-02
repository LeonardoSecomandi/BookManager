using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.API.Models.DTOS.Responses;
using BookManager.Models;


namespace BookManager.API.Models.Interfaces
{
    public interface IBookRepositoryInterface
    {
        public Task<IEnumerable<BookResponseModel>> GetBooks();
        public Task<BookResponseModel> GetBookById(int id);
    }
}
