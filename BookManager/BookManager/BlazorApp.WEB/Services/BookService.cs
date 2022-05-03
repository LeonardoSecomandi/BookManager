using BookManager.WEB.Models.DTOS.Responses;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp.WEB.Services
{
    public class BookService : IBookInterface
    {

        private readonly HttpClient _httpCleint;
        public BookService(HttpClient client)
        {
            this._httpCleint = client;
        }

        public Task<BookResponseModel> GetBook(int BookId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookResponseModel>> GetBooks()
        {
            var result = await _httpCleint.GetJsonAsync<IEnumerable<BookResponseModel>>("Book/api");
            return result;
        }

        public async Task<IEnumerable<ItemResponse>> GetItems()
        {
            var result = await _httpCleint.GetJsonAsync<IEnumerable<ItemResponse>>("Item/api");
            return result;
        }

        public Task<ItemResponse> GetItem(int ItemId)
        {
            throw new NotImplementedException();
        }
    }
}
