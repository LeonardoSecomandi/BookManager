// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.WEB.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using BlazorApp.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\_Imports.razor"
using BlazorApp.WEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
using BookManager.WEB.Models.DTOS.Responses;

#line default
#line hidden
#nullable disable
    public partial class ItemCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\secomandi.17131\Documents\GitHub\BookManager\BookManager\BookManager\BlazorApp.WEB\Pages\Components\ItemCard.razor"
       

    [Parameter]
    public ItemResponse Item { get; set; }

    [Inject]
    protected NavigationManager nv { get; set; }

    protected void VisitBookDetail()
    {
        nv.NavigateTo($"/book/{Item.ItemId}/detail");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
