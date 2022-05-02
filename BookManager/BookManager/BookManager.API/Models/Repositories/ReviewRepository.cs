using BookManager.API.Data;
using BookManager.API.Models.DTOS.Requests;
using BookManager.API.Models.Interfaces;
using BookManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManager.API.Models.Repositories
{
    public class ReviewRepository : IReviewInterface
    {
        private readonly ApplicationDbContext _context;

        public ReviewRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<Review> AddReview(AddReviewRequest req)
        {
            var isBook = await _context.Books.FirstOrDefaultAsync(x => x.Id == req.BookId);
            //var isItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == req.ItemID);
            var itemid = await _context.Items.FirstOrDefaultAsync(x => x.BookId == req.BookId);
            var newReview = new Review()
            {
                ItemId = itemid.Id,
                ReviewStars = req.ReviewStars,
                ReviewContent = req.ReviewContent,
                ReviewPublishDate = req.ReviewPublishDate
            };

            var newRating = new Ratings()
            {
                RatingDate = req.ReviewPublishDate,
                BookId = req.BookId,
                RatingValue = req.ReviewStars,
                UserId = req.UserID
            };

            await _context.AddAsync(newReview);
            await _context.AddAsync(newRating);
            await _context.SaveChangesAsync();

            return newReview;
        

        }
    }
}
