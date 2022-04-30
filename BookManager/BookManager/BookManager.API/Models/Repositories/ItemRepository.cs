﻿using BookManager.API.Data;
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
        public ItemRepository(ApplicationDbContext context)
        {
            this._context = context;
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

                ItemResponse newitem = new ItemResponse()
                {
                    Book = await _context.Books.FirstOrDefaultAsync(x => x.Id == item.BookId),
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
    }
}
