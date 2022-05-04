using BookManager.Models;
using BookManager.WEB.Models.DTOS.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.WEB.Services
{
    public interface IReviewInterface
    {
        public Task<Review> AddReview(AddReviewRequest req);
    }
}
