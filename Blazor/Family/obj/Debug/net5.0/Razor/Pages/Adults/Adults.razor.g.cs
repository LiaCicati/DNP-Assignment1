#pragma checksum "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a3433238fb4084da9aaf20af83954b7bed11718"
// <auto-generated/>
#pragma warning disable 1591
namespace Family.Pages.Adults
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Family;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\_Imports.razor"
using Family.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
using Family.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
using Family.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-dtrmj6eo6u>Adult data</h3>");
#nullable restore
#line 14 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
 if (AdultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p b-dtrmj6eo6u>\r\n        Loading...\r\n    </p>");
#nullable restore
#line 19 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddAttribute(4, "b-dtrmj6eo6u");
            __builder.AddMarkupContent(5, @"<thead b-dtrmj6eo6u><tr b-dtrmj6eo6u><th b-dtrmj6eo6u>Job title</th>
            <th b-dtrmj6eo6u>User ID</th>
            <th b-dtrmj6eo6u>First Name</th>
            <th b-dtrmj6eo6u>Last Name</th>
             <th b-dtrmj6eo6u>Salary</th>
            <th b-dtrmj6eo6u>Hair colour?</th>
            <th b-dtrmj6eo6u>Eye colour</th>
            <th b-dtrmj6eo6u>Age</th>
            <th b-dtrmj6eo6u>Weight</th>
            <th b-dtrmj6eo6u>Height</th>
            <th b-dtrmj6eo6u>Sex</th></tr></thead>
        ");
            __builder.OpenElement(6, "tbody");
            __builder.AddAttribute(7, "b-dtrmj6eo6u");
#nullable restore
#line 39 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
         foreach (var item in AdultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.AddAttribute(9, "b-dtrmj6eo6u");
            __builder.OpenElement(10, "td");
            __builder.AddAttribute(11, "b-dtrmj6eo6u");
            __builder.AddContent(12, 
#nullable restore
#line 42 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "b-dtrmj6eo6u");
            __builder.AddContent(16, 
#nullable restore
#line 43 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "b-dtrmj6eo6u");
            __builder.AddContent(20, 
#nullable restore
#line 44 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "b-dtrmj6eo6u");
            __builder.AddContent(24, 
#nullable restore
#line 45 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                   ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "b-dtrmj6eo6u");
            __builder.AddContent(28, 
#nullable restore
#line 46 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                        item.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "b-dtrmj6eo6u");
            __builder.AddContent(32, 
#nullable restore
#line 47 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "b-dtrmj6eo6u");
            __builder.AddContent(36, 
#nullable restore
#line 48 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "b-dtrmj6eo6u");
            __builder.AddContent(40, 
#nullable restore
#line 49 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "b-dtrmj6eo6u");
            __builder.AddContent(44, 
#nullable restore
#line 50 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "b-dtrmj6eo6u");
            __builder.AddContent(48, 
#nullable restore
#line 51 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "b-dtrmj6eo6u");
            __builder.AddContent(52, 
#nullable restore
#line 52 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Lia Cicati\DNP-Assignment1\Blazor\Family\Pages\Adults\Adults.razor"
       
    private IList<Adult> AdultsToShow;
    private IList<Adult> AllAdults;


    protected override async Task OnInitializedAsync()
    {
        AllAdults = AdultService.GetAdults();
        AdultsToShow = AllAdults;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
