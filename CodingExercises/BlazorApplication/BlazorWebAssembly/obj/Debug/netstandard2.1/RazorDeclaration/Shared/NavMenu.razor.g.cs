#pragma checksum "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eceedc6f7d2b20a84cf2bf72da78691f33d1af24"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebAssembly.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\_Imports.razor"
using BlazorWebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\_Imports.razor"
using BlazorWebAssembly.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\harry\Documents\SoftwareDeveloper\DevJourney\CodingExercises\BlazorApplication\BlazorWebAssembly\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
