using BookManager.Models;
using BookManager.WEB.Models.DTOS.Requests;
using BookManager.WEB.Models.DTOS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.WEB.Services
{
    public interface IBookInterface
    {
        public Task<IEnumerable<ItemResponse>> GetItems();
        public Task<IEnumerable<BookResponseModel>> GetBooks();

        public Task<ItemResponse> GetItem(int ItemId);

        public Task<BookResponseModel> GetBook(int BookId);

        public Task<IEnumerable<ItemResponse>> Search(string Terms);
        public  Task<SavedBooks> AddBookToFavourites(AddBookTOFavouireRequest req);
    }
}
