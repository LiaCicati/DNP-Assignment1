// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Family.Pages.Statistics
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
#line 2 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Statistics\Statistics.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Statistics\Statistics.razor"
using Family.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Statistics\Statistics.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Statistics\Statistics.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statistics")]
    public partial class Statistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Loredana Cicati\DNP-Assignment1\Blazor\Family\Pages\Statistics\Statistics.razor"
      
    private IList<Adult> adults;
    private static IList<Adult> adultsData;


    public class PieChart
    {
        public string xValue { get; set; }
        public double yValue { get; set; }
        public string total { get; set; }
    }

    private List<PieChart> data = new List<PieChart>();
    private List<PieChart> dataSource = new List<PieChart>();


    protected override async Task OnInitializedAsync()
    {
        adults = AdultService.GetAdults();
        adultsData = adults;
        data.Add(new PieChart {xValue = "Grey", yValue = GetPersonsWithEyeColor("Grey")});
        data.Add(new PieChart {xValue = "Brown", yValue = GetPersonsWithEyeColor("Brown")});
        data.Add(new PieChart {xValue = "Blue", yValue = GetPersonsWithEyeColor("Blue")});
        data.Add(new PieChart {xValue = "Green", yValue = GetPersonsWithEyeColor("Green")});
        data.Add(new PieChart {xValue = "Amber", yValue = GetPersonsWithEyeColor("Amber")});
        dataSource.Add(new PieChart {xValue = "Brown", yValue = GetPersonWithHairColor("Brown")});
        dataSource.Add(new PieChart {xValue = "Black", yValue = GetPersonWithHairColor("Black")});
        dataSource.Add(new PieChart {xValue = "White", yValue = GetPersonWithHairColor("White")});
    }

    int GetPersonWithHairColor(string hairColor)
    {
        int p = 0;
        foreach (var adult in adultsData)
        {
            if (String.Equals(hairColor, adult.HairColor, StringComparison.CurrentCultureIgnoreCase))
            {
                p++;
            }
        }
        return p;
    }


    int GetPersonsWithEyeColor(string eyeColor)
    {
        int p = 0;
        foreach (var adult in adultsData)
        {
            if (String.Equals(eyeColor, adult.EyeColor, StringComparison.CurrentCultureIgnoreCase))
            {
                p++;
            }
        }
        return p;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
