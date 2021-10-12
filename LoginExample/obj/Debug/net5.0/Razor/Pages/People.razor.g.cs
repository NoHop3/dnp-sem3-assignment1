#pragma checksum "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfca1a553ef2e56e0cecd5fd896d85ea88b400c5"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>List of Adults</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Filter by ID: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                                                  (args) => FilterByAdultId(args)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "Filter by Gender: <br>\n    ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control selectpicker");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                                                           (args) => FilterByGender(args)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width: 100px");
            __builder.OpenElement(14, "option");
            __builder.AddContent(15, "Both");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "option");
            __builder.AddContent(18, "Male");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n        ");
            __builder.OpenElement(20, "option");
            __builder.AddContent(21, "Female");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p><em>Loading...</em></p>");
#nullable restore
#line 24 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p><em>No items exist. Please add some.</em></p>");
#nullable restore
#line 30 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table");
            __builder.AddMarkupContent(26, @"<thead><tr><th>ID</th> 
            <th>First name</th> 
            <th>Last name </th> 
            <th>Hair color</th>
            <th>Eye Color</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Gender</th>
            <th>Remove</th>
            <th>Edit</th></tr></thead>
        ");
            __builder.OpenElement(27, "tbody");
#nullable restore
#line 50 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
         foreach (var item in adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 53 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, " \n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 54 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, " \n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 55 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, " \n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 56 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, " \n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 57 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, " \n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 58 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, " \n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 59 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, " \n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 60 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, " \n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 61 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                ");
            __builder.OpenElement(56, "td");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
                                        () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\bird\RiderProjects\Razor_intro_ex1\LoginExample\Pages\People.razor"
}

#line default
#line hidden
#nullable disable
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
