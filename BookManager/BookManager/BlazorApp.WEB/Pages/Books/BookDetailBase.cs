using BlazorApp.WEB.Services;
using BookManager.WEB.Models.DTOS.Responses;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.WEB.Pages.Books
{
    public class BookDetailBase : ComponentBase
    {
        [Inject]
        public IBookInterface BookService { get; set; }

        [Parameter]
        public string itemid { get; set; }

        protected ItemResponse Book = new ItemResponse();

        protected override async Task OnInitializedAsync()
        {
            Book = await BookService.GetItem(int.Parse(itemid));
            return;
        }
    }
}
