using BlazorApp.WEB.Services;
using BookManager.WEB.Models.DTOS.Responses;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.WEB.Pages.Books
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        protected IBookInterface BookService { get; set; }

        public IEnumerable<ItemResponse> EleItem = new List<ItemResponse>();

        protected override async Task OnInitializedAsync()
        {
             EleItem = await BookService.GetItems();
        }
    }
}
