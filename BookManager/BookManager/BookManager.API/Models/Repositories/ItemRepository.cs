using BookManager.API.Data;
using BookManager.API.Models.DTOS.Responses;
using BookManager.API.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BookManager.API.Models.Repositories.ExtractBookFromGoogleApi;

namespace BookManager.API.Models.Repositories
{
    public class ItemRepository : IItemInterface
    {
        private readonly ApplicationDbContext _context;
        private readonly IBookRepositoryInterface BookService;
        public ItemRepository(ApplicationDbContext context,
            IBookRepositoryInterface BookService)
        {
            this._context = context;
            this.BookService = BookService;
        }
        public async Task<IEnumerable<ItemResponse>> GetItems()
        {
            List<ItemResponse> EleItem = new List<ItemResponse>();
            foreach(var item in _context.Items)
            {
                var itemdiscussion = await _context.Discussions.ToListAsync();
                itemdiscussion = itemdiscussion.Where(x => x.ItemId == item.Id).ToList();

                var itemreview = await _context.Reviews.ToListAsync();
                itemreview = itemreview.Where(x => x.ItemId == item.Id).ToList();

                var Book = await BookService.GetBookById(item.BookId);
                var b = Book.Book;
                b.RatingAverage = Book.RatingsAverage;

                ItemResponse newitem = new ItemResponse()
                {
                    ItemId=item.Id,
                    Book = b,
                    ItemDiscussionList = itemdiscussion,
                    ItemReviewList = itemreview
                };
                EleItem.Add(newitem);
            }
            return EleItem;
        }

        public async Task<BookManager.Models.Item> AddItem(BookManager.Models.Item item)
        {
            var result = await _context.AddAsync(item);
            return result.Entity;
        }

        public async Task<ItemResponse> GetItem(int itemid)
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == itemid);
            var discussionlist = await _context.Discussions.ToListAsync();
            discussionlist = discussionlist.Where(x => x.ItemId == itemid).ToList();

            var reviewlist = await _context.Reviews.ToListAsync();
            reviewlist = reviewlist.Where(x => x.ItemId == itemid).ToList();

            var Book = await BookService.GetBookById(item.BookId);
            var b = Book.Book;
            b.RatingAverage = Book.RatingsAverage;


            return new ItemResponse()
            {
                ItemId = item.Id,
                Book = b,
                ItemDiscussionList = discussionlist,
                ItemReviewList = reviewlist
            };
        }
    }
}
