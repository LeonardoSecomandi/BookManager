using BookManager.API.Models.DTOS.Requests;
using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BookManager.API.Models.Interfaces
{
    public interface IReviewInterface
    {
        public Task<Review> AddReview(AddReviewRequest req);
    }
}
