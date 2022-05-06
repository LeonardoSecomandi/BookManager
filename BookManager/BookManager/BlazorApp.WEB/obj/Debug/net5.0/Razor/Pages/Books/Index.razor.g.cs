#pragma checksum "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d05a8be2cb8703aee18b7d5bb88371124861d75"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.WEB.Pages.Books
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using BlazorApp.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using BlazorApp.WEB.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/books")]
    public partial class Index : IndexBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "style", "text-align:center");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "input-group input-group-lg");
                __builder2.OpenElement(6, "input");
                __builder2.AddAttribute(7, "type", "email");
                __builder2.AddAttribute(8, "class", "form-control");
                __builder2.AddAttribute(9, "id", "exampleFormControlInput1");
                __builder2.AddAttribute(10, "placeholder", "Titolo/Autore");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor"
                                                                                              SearchedText

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchedText = __value, SearchedText));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.AddMarkupContent(14, "<button class=\"btn-primary\">Cerca</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row row-cols-1 row-cols-md-2");
                __builder2.AddAttribute(18, "style", "margin-top: 6rem;");
#nullable restore
#line 16 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor"
             foreach (var Item in EleItem)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<BlazorApp.WEB.Pages.Components.ItemCard>(19);
                __builder2.AddAttribute(20, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BookManager.WEB.Models.DTOS.Responses.ItemResponse>(
#nullable restore
#line 18 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor"
                                                               Item

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ShowReview", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BookManager.WEB.Models.DTOS.Responses.ItemResponse>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BookManager.WEB.Models.DTOS.Responses.ItemResponse>(this, 
#nullable restore
#line 18 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor"
                                                                                 ()=>ShowReviewClick(Item)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 19 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(22, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, "<h2>Login Richiesto</h2>\r\n        ");
                __builder2.AddMarkupContent(24, "<a href=\"/Identity/Account/Login\">Loggati</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
