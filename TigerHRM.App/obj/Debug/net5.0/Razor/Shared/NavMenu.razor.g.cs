#pragma checksum "C:\Users\hil_w\source\repos\TigerHRM.App\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "081e9f77e2b98ccf2de69c9a77b1296a843171b3"
// <auto-generated/>
#pragma warning disable 1591
namespace TigerHRM.App.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using TigerHRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using TigerHRM.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using TigerHRM.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hil_w\source\repos\TigerHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light");
            __builder.AddAttribute(2, "id", "sidebar-wrapper");
            __builder.AddMarkupContent(3, "<div class=\"sidebar-logo\"><img class=\"img-responsive\" id=\"logo\" src=\"images/Cazzlogo3.jpg\"></div>\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"profile\"><div class=\"profile-bg\"><img class=\"img-responsive\" src=\"images/profilePicture.jpg\"></div>\r\n        <div class=\"profile-picture\"><img class=\"img-responsive circle account-photo\" src=\"images/profilePicture.jpg\"></div></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "menu list-group list-group-flush");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(9, "href", "/");
            __builder.AddAttribute(10, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\Users\hil_w\source\repos\TigerHRM.App\Shared\NavMenu.razor"
                                                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(16, "href", "/employeeoverview");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Employees\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(22, "href", "/employeeedit");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Add new employee\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
