using BookManager.API.Models.DTOS.Responses;
using BookManager.API.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BookManager.API.Models.Repositories.ExtractBookFromGoogleApi;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("[Controller]/api")]
    public class ItemController : ControllerBase
    {
        private readonly IItemInterface _itemservice;
        public ItemController(IItemInterface itemInterface)
        {
            this._itemservice = itemInterface;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemResponse>> GetItems()
        {
            var result = await _itemservice.GetItems();
            return result;
        }

        [HttpPost]
        public async Task<BookManager.Models.Item> AddItem(BookManager.Models.Item item)
        {
            var result = await _itemservice.AddItem(item);
            return result;
        }
    }
}
