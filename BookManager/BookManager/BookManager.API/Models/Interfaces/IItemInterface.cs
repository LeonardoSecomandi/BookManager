using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.API.Models.DTOS.Responses;
using BookManager.Models;

namespace BookManager.API.Models.Interfaces
{
    public interface IItemInterface
    {
        public Task<IEnumerable<ItemResponse>> GetItems();
        public Task<BookManager.Models.Item> AddItem(BookManager.Models.Item item);
    }
}
