using BlazorApp.WEB.Services;
using BookManager.WEB.Models.DTOS.Responses;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;

namespace BlazorApp.WEB.Pages.Books
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        protected IBookInterface BookService { get; set; }

        public IEnumerable<ItemResponse> EleItem = new List<ItemResponse>();

        List<Review> EleReviewAnteprima = new List<Review>();

        protected override async Task OnInitializedAsync()
        {
             EleItem = await BookService.GetItems();
        }

        protected void ShowReviewClick(ItemResponse item)
        {
            EleReviewAnteprima.Clear();
            foreach(var review in item.ItemReviewList)
            {
                EleReviewAnteprima.Add(review);
            }
        }
    }
}
