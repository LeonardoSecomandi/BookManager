#pragma checksum "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ebc401c895d8dee63ef1210c00bfe1905bfc1b7"
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
                __builder2.AddMarkupContent(2, "<div style=\"text-align:center\"><h3><label for=\"exampleFormControlInput1\" sty class=\"form-label\">Cerca Libro</label></h3>\r\n            <input type=\"email\" class=\"form-control\" id=\"exampleFormControlInput1\" placeholder=\"Titolo/Autore\"></div> \r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row row-cols-1 row-cols-md-2");
                __builder2.AddAttribute(5, "style", "margin-top: 6rem;");
#nullable restore
#line 12 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor"
             foreach (var Item in EleItem)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<BlazorApp.WEB.Pages.Components.ItemCard>(6);
                __builder2.AddAttribute(7, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BookManager.WEB.Models.DTOS.Responses.ItemResponse>(
#nullable restore
#line 14 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor"
                                                               Item

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 15 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\Index.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "<h2>Login Richiesto</h2>\r\n        ");
                __builder2.AddMarkupContent(10, "<a href=\"/Identity/Account/Login\">Loggati</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
