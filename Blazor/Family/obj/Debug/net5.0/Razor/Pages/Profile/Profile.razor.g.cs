#pragma checksum "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdb43ad554c28ad7cf18ba7734f97068accf6d0a"
// <auto-generated/>
#pragma warning disable 1591
namespace Family.Pages.Profile
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Family;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Family.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
using Family.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "profile");
            __builder.AddAttribute(2, "b-j15f2hbp8y");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "profile-info");
            __builder.AddAttribute(5, "b-j15f2hbp8y");
            __builder.OpenElement(6, "h2");
            __builder.AddAttribute(7, "b-j15f2hbp8y");
            __builder.AddContent(8, "Hello, ");
            __builder.AddContent(9, 
#nullable restore
#line 8 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                    username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "form");
            __builder.AddAttribute(12, "name", "profile");
            __builder.AddAttribute(13, "class", "form");
            __builder.AddAttribute(14, "b-j15f2hbp8y");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-data__group");
            __builder.AddAttribute(17, "b-j15f2hbp8y");
            __builder.AddMarkupContent(18, "<label b-j15f2hbp8y>Username:</label>\r\n                ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "class", "input");
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 14 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                            username

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "disabled", "disabled");
            __builder.AddAttribute(23, "b-j15f2hbp8y");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-data__group");
            __builder.AddAttribute(27, "b-j15f2hbp8y");
            __builder.AddMarkupContent(28, "<label b-j15f2hbp8y>Role:</label>\r\n                ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "class", "input");
            __builder.AddAttribute(31, "value", 
#nullable restore
#line 21 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                            role

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "disabled", "disabled");
            __builder.AddAttribute(33, "b-j15f2hbp8y");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-data__group");
            __builder.AddAttribute(37, "b-j15f2hbp8y");
            __builder.AddMarkupContent(38, "<label b-j15f2hbp8y>City:</label>\r\n                ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "class", "input");
            __builder.AddAttribute(41, "disabled", "disabled");
            __builder.AddAttribute(42, "value", 
#nullable restore
#line 29 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                            city

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "b-j15f2hbp8y");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "button-wrapper");
            __builder.AddAttribute(47, "b-j15f2hbp8y");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "logout-button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
                                                                  Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "b-j15f2hbp8y");
            __builder.AddContent(53, "Log Out");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Profile\Profile.razor"
      
    private string username;
    private string city;
    private string role;


    protected override void OnInitialized()
    {
        base.OnInitialized();
        username = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser().UserName;
        city = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser().City;
        role = ((CustomAuthenticationStateProvider) AuthenticationStateProvider).GetCachedUser().Role;
    }

    public void Logout()
    {
        ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
        NavigationManager.NavigateTo("/login");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
