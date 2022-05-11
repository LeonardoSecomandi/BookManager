#pragma checksum "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7ac6a2333220ac8a06d0118740dc4d00523d58"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.WEB.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using BlazorApp.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using BlazorApp.WEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
using BookManager.WEB.Models.DTOS.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
using BlazorApp.WEB.Services;

#line default
#line hidden
#nullable disable
    public partial class ItemCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "width: 18rem; margin-left:1rem");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 5 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
               Item.Book.ImageLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "class", "card-img-top");
            __builder.AddAttribute(6, "alt", "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
            __builder.AddContent(12, 
#nullable restore
#line 7 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
                                Item.Book.Titolo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "card-text");
            __builder.AddContent(16, 
#nullable restore
#line 8 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
                              Item.Book.Description?.Remove(4)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "h6");
            __builder.AddContent(20, "Valutazioni Complessive: ");
            __builder.AddContent(21, 
#nullable restore
#line 9 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
                                      Item.Book.RatingAverage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        \r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "#");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
                                  VisitBookDetail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-primary col-5");
            __builder.AddContent(29, "Dettagli");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "<br>\r\n            ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
                                            AddToFavourite

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "class", "btn btn-success col-3");
            __builder.AddAttribute(35, "style", "margin-left:0.5rem");
            __builder.AddMarkupContent(36, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-star"" viewBox=""0 0 16 16""><path d=""M2.866 14.85c-.078.444.36.791.746.593l4.39-2.256 4.389 2.256c.386.198.824-.149.746-.592l-.83-4.73 3.522-3.356c.33-.314.16-.888-.282-.95l-4.898-.696L8.465.792a.513.513 0 0 0-.927 0L5.354 5.12l-4.898.696c-.441.062-.612.636-.283.95l3.523 3.356-.83 4.73zm4.905-2.767-3.686 1.894.694-3.957a.565.565 0 0 0-.163-.505L1.71 6.745l4.052-.576a.525.525 0 0 0 .393-.288L8 2.223l1.847 3.658a.525.525 0 0 0 .393.288l4.052.575-2.906 2.77a.565.565 0 0 0-.163.506l.694 3.957-3.686-1.894a.503.503 0 0 0-.461 0z""></path></svg>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        <p></p>\r\n        ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "#");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
                              VisitBookDetail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, 
#nullable restore
#line 20 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
                                                Item.ItemReviewList.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(42, " Recensioni");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
       

    [Parameter]
    public ItemResponse Item { get; set; }

    [Inject]
    protected NavigationManager nv { get; set; }

    [Inject]
    protected IBookInterface BookService { get; set; }

    [Parameter]
    public EventCallback<ItemResponse> ShowReview { get; set; }

    [Inject]
    protected IJSRuntime JsRuntime { get; set; }

    protected void VisitBookDetail()
    {
        nv.NavigateTo($"/book/{Item.ItemId}/detail");
    }

    protected async void ShowAnteprima()
    {
        await ShowReview.InvokeAsync(Item);
    }

    protected async Task AddToFavourite()
    {
        var result = await BookService.AddBookToFavourites(new BookManager.WEB.Models.DTOS.Requests.AddBookTOFavouireRequest()
        {
            BookId = Item.Book.Id
        });
        if(result!=null)
            await JsRuntime.InvokeVoidAsync("alert", "Libro Aggiunto ai preferiti");

        if(result is null)
            await JsRuntime.InvokeVoidAsync("alert", "Libro già salvato");
        return;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
