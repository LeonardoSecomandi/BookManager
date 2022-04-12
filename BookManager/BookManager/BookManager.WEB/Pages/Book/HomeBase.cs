using BookManager.WEB.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManager.Models;

namespace BookManager.WEB.Pages.Book
{
    public class HomeBase : ComponentBase
    {
        [Inject]
        protected IBookService bookService { get; set; }

        public IEnumerable<BookManager.Models.Book> EleBooks = new List<BookManager.Models.Book>();

        protected override async Task OnInitializedAsync()
        {
            EleBooks = await bookService.GetBooks();
        }

    }
}
