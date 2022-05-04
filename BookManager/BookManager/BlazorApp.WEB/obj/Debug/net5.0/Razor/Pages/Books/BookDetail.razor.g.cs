#pragma checksum "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a028dd3b089618ee59a6c85d6e0a41f13bb3b2a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/book/{itemid}/detail")]
    public partial class BookDetail : BookDetailBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BookDetail</h3>");
#nullable restore
#line 7 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
 if (Book.Book != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card col-4");
            __builder.AddAttribute(5, "style", "width: 28rem; text-align:center");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 11 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
                   Book.Book.ImageLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "class", "card-img-top");
            __builder.AddAttribute(9, "alt", "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenElement(13, "h3");
            __builder.AddAttribute(14, "class", "card-title");
            __builder.AddContent(15, 
#nullable restore
#line 13 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
                                    Book.Book.Titolo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
             foreach (var author in Book.Book.Authors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "h4");
            __builder.AddContent(17, 
#nullable restore
#line 16 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
                     author.AuthorName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "h5");
            __builder.AddContent(19, 
#nullable restore
#line 18 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
                 Book.Book.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            <hr>\r\n            ");
            __builder.OpenElement(21, "h5");
            __builder.AddMarkupContent(22, "\r\n                Valutazioni:<br>\r\n                ");
            __builder.AddContent(23, 
#nullable restore
#line 22 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
                 Book.Book.RatingAverage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n                <br>\r\n                ");
            __builder.AddContent(25, 
#nullable restore
#line 24 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
                 Book.ItemReviewList.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, " Recensioni\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card col-4");
            __builder.AddMarkupContent(30, "<h3>Recensioni</h3>\r\n        <hr>");
#nullable restore
#line 31 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
         foreach(var Review in Book.ItemReviewList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "h6");
            __builder.AddContent(32, 
#nullable restore
#line 33 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
                 Review.ReviewPublishDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "<br>\r\n            ");
            __builder.OpenElement(34, "h4");
            __builder.AddContent(35, 
#nullable restore
#line 34 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
                 Review.ReviewStars

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "<br>\r\n            ");
            __builder.OpenElement(37, "h3");
            __builder.AddContent(38, 
#nullable restore
#line 35 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
                 Review.ReviewContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "<hr style=\"2px solid black\">");
#nullable restore
#line 38 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "card col-4");
            __builder.AddMarkupContent(43, "<h3>Lascia una recensione</h3>\r\n        <hr>\r\n        ");
            __builder.OpenElement(44, "form");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "mb-3");
            __builder.AddMarkupContent(47, "<label for=\"exampleInputEmail1\" class=\"form-label\">Numero Stelle</label>\r\n                ");
            __builder.OpenElement(48, "select");
            __builder.AddAttribute(49, "class", "form-select");
            __builder.AddAttribute(50, "aria-label", "Default select example");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "selected");
            __builder.AddContent(53, "Open this select menu");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "1");
            __builder.AddContent(57, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "2");
            __builder.AddContent(61, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "3");
            __builder.AddContent(65, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "option");
            __builder.AddAttribute(68, "value", "1");
            __builder.AddContent(69, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", "2");
            __builder.AddContent(73, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "option");
            __builder.AddAttribute(76, "value", "3");
            __builder.AddContent(77, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.OpenElement(79, "option");
            __builder.AddAttribute(80, "value", "1");
            __builder.AddContent(81, "7");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "value", "2");
            __builder.AddContent(85, "8");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "option");
            __builder.AddAttribute(88, "value", "3");
            __builder.AddContent(89, "9");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.OpenElement(91, "option");
            __builder.AddAttribute(92, "value", "1");
            __builder.AddContent(93, "10");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.AddMarkupContent(95, "<div class=\"mb-3\"><label for=\"exampleFormControlTextarea1\" class=\"form-label\">Commento</label>\r\n                <textarea class=\"form-control\" id=\"exampleFormControlTextarea1\" rows=\"3\"></textarea></div>\r\n            ");
            __builder.AddMarkupContent(96, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "D:\GitHub\repository1\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Books\BookDetail.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
