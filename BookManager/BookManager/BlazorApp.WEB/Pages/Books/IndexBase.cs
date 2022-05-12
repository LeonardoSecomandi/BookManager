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

        [Inject]
        protected NavigationManager nv { get; set; }

        public IEnumerable<ItemResponse> EleItem = new List<ItemResponse>();

        public IEnumerable<ItemResponse> SearchedItem = new List<ItemResponse>();
       public bool NoSearchResult = true;
        public bool StartSeach = false;

        protected string SearchedText { get; set; }

        List<Review> EleReviewAnteprima = new List<Review>();

        protected override async Task OnInitializedAsync()
        {
             EleItem = await BookService.GetItems();
            EleItem.ToList().OrderBy(x => x.Book.RatingAverage);
            SearchedText = "";
            StateHasChanged();
        }

        protected void ShowReviewClick(ItemResponse item)
        {
            EleReviewAnteprima.Clear();
            foreach(var review in item.ItemReviewList)
            {
                EleReviewAnteprima.Add(review);
            }
        }

        protected async Task Search()
        {
            StartSeach = true;
            SearchedItem = new List<ItemResponse>();
            if (string.IsNullOrEmpty(SearchedText))
            {
                nv.NavigateTo("/");
                return;
            }
                
            SearchedItem = await BookService.Search(SearchedText);
            SearchedItem = SearchedItem.ToList().Distinct();
            if (!SearchedItem.Any())
                NoSearchResult = true;
            if (SearchedItem.Any())
                NoSearchResult = false;

            StateHasChanged();
            StartSeach = false;
            return;
        }
    }
}
