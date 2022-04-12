using BookManager.Models;
using BookManager.Web.Models.DTOS.Responses;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookManager.WEB.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient _httpClient;
        public BookService(HttpClient client)
        {
            this._httpClient = client;
        }
        public async Task<IEnumerable<Book>> GetBooks()
        {
            var result= await _httpClient.GetJsonAsync<IEnumerable<BookResponseModel>>("Book/api");
            return result.ToList().Select(x => x.Book);
        }
    }
}
