#pragma checksum "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d28d22b89e8629c70a46d0529a9ae4e1d4a0be56"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.WEB.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using BlazorApp.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using BlazorApp.WEB.Shared;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "a");
                __builder2.AddAttribute(3, "href", "#");
                __builder2.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\Shared\LoginDisplay.razor"
                              GoHome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(5, "Home");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, @"<a href=""/favourite""><span><svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-bookmark-heart"" viewBox=""0 0 16 16""><path fill-rule=""evenodd"" d=""M8 4.41c1.387-1.425 4.854 1.07 0 4.277C3.146 5.48 6.613 2.986 8 4.412z""></path>
                    <path d=""M2 2a2 2 0 0 1 2-2h8a2 2 0 0 1 2 2v13.5a.5.5 0 0 1-.777.416L8 13.101l-5.223 2.815A.5.5 0 0 1 2 15.5V2zm2-1a1 1 0 0 0-1 1v12.566l4.723-2.482a.5.5 0 0 1 .554 0L13 14.566V2a1 1 0 0 0-1-1H4z""></path></svg>
                Preferiti
            </span></a>
        ");
                __builder2.OpenElement(8, "a");
                __builder2.AddAttribute(9, "href", "Identity/Account/Manage");
                __builder2.AddContent(10, "Hello, ");
                __builder2.AddContent(11, 
#nullable restore
#line 15 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\Shared\LoginDisplay.razor"
                                                  context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(12, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.AddMarkupContent(14, "<form method=\"post\" action=\"Identity/Account/LogOut\"><button type=\"submit\" class=\"nav-link btn btn-link\">Log out</button></form>");
            }
            ));
            __builder.AddAttribute(15, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "<a href=\"Identity/Account/Register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(17, "<a href=\"Identity/Account/Login\">Log in</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\secomandi.17131\Documents\BookManager\BookManager\BookManager\BlazorApp.WEB\Shared\LoginDisplay.razor"
      



    protected void GoHome()
    {
        nv.NavigateTo("/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nv { get; set; }
    }
}
#pragma warning restore 1591
