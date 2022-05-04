using BookManager.Models;
using BookManager.WEB.Models.DTOS.Requests;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.WEB.Services
{
    public class ReviewService : IReviewInterface
    {
        private readonly HttpClient _httpClient;
        public ReviewService(HttpClient client)
        {
            this._httpClient = client;
        }
        public async Task<Review> AddReview(AddReviewRequest req)
        {
            var result = await _httpClient.PostJsonAsync<Review>("Review/api", req);
            return result;
        }
    }
}
