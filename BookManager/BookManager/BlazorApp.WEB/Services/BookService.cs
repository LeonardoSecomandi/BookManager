using BookManager.Models;
using BookManager.WEB.Models.DTOS.Requests;
using BookManager.WEB.Models.DTOS.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        private readonly AuthenticationStateProvider authenticationStateProvider;
        public BookService(HttpClient client,
            AuthenticationStateProvider authenticationStateProvider)
        {
            this._httpCleint = client;
            this.authenticationStateProvider = authenticationStateProvider;
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

        public async Task<ItemResponse> GetItem(int ItemId)
        {
            var result = await _httpCleint.GetJsonAsync<ItemResponse>($"Item/api/{ItemId}");
            return result;
        }

        public async Task<IEnumerable<ItemResponse>> Search(string Terms)
        {
            var result = await _httpCleint.GetJsonAsync<IEnumerable<ItemResponse>>($"Item/api/search/{Terms}");
            return result;
        }

        public async Task<SavedBooks> AddBookToFavourites(AddBookTOFavouireRequest request)
        {
            try
            {


                var User = await authenticationStateProvider.GetAuthenticationStateAsync();
                var UserInfo = User.User;
                string userId = UserInfo.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;
                var result = await _httpCleint.PostJsonAsync<SavedBooks>("Book/api/addtofavourites", new AddBookTOFavouireRequest()
                {
                    UserId = userId,
                    BookId = request.BookId
                });
                return result;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Book>> GetUserSavedBooks()
        {
                var User = await authenticationStateProvider.GetAuthenticationStateAsync();
                var UserInfo = User.User;
                string userId = UserInfo.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;
                var result = await _httpCleint.GetJsonAsync<IEnumerable<Book>>($"Book/api/savedbooks?UserId={userId}");
                return result;
        }
    }
}
