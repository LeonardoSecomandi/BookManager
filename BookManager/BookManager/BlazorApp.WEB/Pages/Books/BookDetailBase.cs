using BlazorApp.WEB.Services;
using BookManager.WEB.Models.DTOS.Requests;
using BookManager.WEB.Models.DTOS.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
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

        [Inject]
        protected AuthenticationStateProvider _authenticationStateProvider { get; set; }

        [Inject]
        public IReviewInterface _reviewService { get; set; }

        [Parameter]
        public string itemid { get; set; }

        protected ItemResponse Book = new ItemResponse();

        protected string ReviewStars { get; set; }

        protected string ReviewContent { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Book = await BookService.GetItem(int.Parse(itemid));
            return;
        }

        protected async Task PostReview()
        {
            var User = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var UserInfo = User.User;
            string userId = UserInfo.FindFirst(c => c.Type.Contains("nameidentifier"))?.Value;

            var newReview = new AddReviewRequest()
            {
                ReviewStars = int.Parse(ReviewStars),
                ReviewContent = ReviewContent,
                BookId = Book.Book.Id,
                ReviewPublishDate = DateTime.Now,
                UserID = 20
            };

            var Result = await _reviewService.AddReview(newReview);

        }
    }
}
