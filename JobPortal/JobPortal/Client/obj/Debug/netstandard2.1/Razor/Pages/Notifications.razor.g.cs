#pragma checksum "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a15212246b77e9b30abe7d5317a05a86f30e44ce"
// <auto-generated/>
#pragma warning disable 1591
namespace JobPortal.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using JobPortal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using JobPortal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using JobPortal.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using JobPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using JobPortal.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/notifications")]
    public partial class Notifications : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "style", "color:white");
            __builder.AddContent(2, "Notifications ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor"
                                       msg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 5 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor"
 if(show)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-dark");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<thead>\r\n        <tr>\r\n            \r\n            <th scope=\"col\">Name</th>\r\n            <th scope=\"col\">Email</th>\r\n            <th scope=\"col\">Job Title</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 17 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor"
         foreach (ApplyJob job in findApplications)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 20 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor"
                     job.CandidateName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 21 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor"
                     job.CandidateEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 22 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor"
                     job.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 24 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 29 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Notifications.razor"
       
    string result = "";
    ApplyJob[] jobs;
    bool show = false;
    string msg = "";
    List<ApplyJob> findApplications=new List<ApplyJob>();
    protected override async Task OnInitializedAsync()
    {
        result = await Http.GetStringAsync("odata/applyJob");
        jobs = Newtonsoft.Json.JsonConvert.DeserializeObject<ODataCandidate<ApplyJob>>(result).Value.ToArray();

        foreach(ApplyJob job in jobs)
        {
            if(Model.MyCompanyState.CompanyName==job.CompanyName)
            {
                findApplications.Add(job);
            }
        }
        if(findApplications.Count!=0)
        {
            show = true;
        }
        else
        {
            msg = "No Apply Job is find";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyStateService Model { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
