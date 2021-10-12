// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LoginExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class People : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
       
    private IList<Adult> allAdults;
    private IList<Adult> adultsToShow;
    
    private int? filterById;
    private string? filterByGender;

    protected override async Task OnInitializedAsync()
    {
        allAdults = Data.GetAdults();
        adultsToShow = allAdults;
    }
    

    private void RemoveAdult(int adultId)
    {
        Adult adultToRemove = allAdults.First(t => t.Id == adultId);
        Data.RemovePerson(adultId);
        allAdults.Remove(adultToRemove);
        adultsToShow.Remove(adultToRemove);
    }

    private void FilterByAdultId(ChangeEventArgs args)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(args.Value.ToString());
        }
        catch (Exception ignored)
        {
        }
        ExecuteFilter();
    }


    private void FilterByGender(ChangeEventArgs args)
    {
        filterByGender = null;
        Console.WriteLine(args.Value.ToString());
        try
        {
            switch (args.Value.ToString())
            {
                case "Male":
                {
                    filterByGender = "M";
                    break;
                }
                case "Female":
                {
                    filterByGender = "F";
                    break;
                }
                case "Non-binary":
                {
                    filterByGender = "N";
                    break;
                }
                default:
                {
                    filterByGender = null;
                    break;
                }
            }
        }
        catch (Exception ignored)
        {
        }
        ExecuteFilter();
    }
    
    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(t => 
            (filterById != null && t.Id == filterById || filterById == null)
            && (filterByGender!=null && (filterByGender.Equals(t.Sex)) || filterByGender==null))
            .ToList();
    }

    private void Edit(int itemAdultId)
    {
        NavigationManager.NavigateTo($"EditAdult/{(itemAdultId)}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService Data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
