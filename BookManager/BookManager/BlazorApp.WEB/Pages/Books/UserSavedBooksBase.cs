using BlazorApp.WEB.Services;
using BookManager.Models;
using BookManager.WEB.Models.DTOS.Responses;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.WEB.Pages.Books
{
    public class UserSavedBooksBase : ComponentBase
    {
        [Inject]
        protected IBookInterface BookService { get; set; }

        protected IEnumerable<Book> EleItem { get; set; }
        protected List<ItemResponse> ItemList = new List<ItemResponse>();

        protected override async Task OnInitializedAsync()
        {
            var Items = await BookService.GetItems();
            EleItem = await BookService.GetUserSavedBooks();
            foreach(var Item in EleItem)
            {
                var ItemCorrespond = Items.FirstOrDefault(x => x.Book.Id == Item.Id);
                ItemList.Add(ItemCorrespond);
            }
            return;
        }
    }
}
