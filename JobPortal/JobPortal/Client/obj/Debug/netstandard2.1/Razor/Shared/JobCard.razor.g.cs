#pragma checksum "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76adc4d53b1fec99d54d2ec02636a9e16b4b80f4"
// <auto-generated/>
#pragma warning disable 1591
namespace JobPortal.Client.Shared
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
    public partial class JobCard : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-8 col-sm-12  mx-auto jobcard mt-5");
            __builder.AddAttribute(2, "style", "max-height: 150px; background-color:black");
            __builder.AddMarkupContent(3, "\r\n    \r\n    \r\n     \r\n        \r\n            ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "job-name");
            __builder.AddMarkupContent(6, "\r\n                ");
            __builder.OpenElement(7, "a");
            __builder.AddAttribute(8, "href", true);
            __builder.AddContent(9, 
#nullable restore
#line 12 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                            post.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "span");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 14 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                     if (CandidateLoginServiceModel.MyCandidateLogin)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                        ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "class", "jobtimes");
            __builder.AddAttribute(16, "href", "/applyJob/" + (
#nullable restore
#line 16 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                                                             post.CompanyPostId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Apply Now");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 17 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "jobdetails");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "ul");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "li");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.AddMarkupContent(29, "<span><i class=\"bi bi-building\" style=\"color: #2980b9;\"></i></span>\r\n                        ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "style", "color: white;");
            __builder.AddContent(32, 
#nullable restore
#line 26 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                                                     post.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "li");
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.AddMarkupContent(37, "<span><i class=\"bi bi-book\" style=\"color: #2980b9;\"></i></span>\r\n                        ");
            __builder.OpenElement(38, "span");
            __builder.AddAttribute(39, "style", "color: white;");
            __builder.AddContent(40, 
#nullable restore
#line 30 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                                                     post.JobInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.AddMarkupContent(43, "<li>\r\n                        <span><i class=\"bi bi-calendar3\" style=\"color: #2980b9;\"></i></span>\r\n                        <span style=\"color: white;\">POSTED DATE</span>\r\n                    </li>\r\n                    ");
            __builder.OpenElement(44, "li");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.AddMarkupContent(46, "<span><i class=\"bi bi-geo-alt-fill\" style=\"color: #2980b9;\"></i></span>\r\n                        ");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "style", "color: white;");
            __builder.AddContent(49, 
#nullable restore
#line 38 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                                                     post.JobLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 42 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                 if (CompanyLoginServiceModel.MyCompanyLogin)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                     if (post.CompanyId == CompanyModel.MyCompanyState.CompanyId)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "                        ");
            __builder.OpenElement(54, "a");
            __builder.AddAttribute(55, "class", "btn btn-warning");
            __builder.AddAttribute(56, "href", "/updatePost/" + (
#nullable restore
#line 46 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                                                                      post.CompanyPostId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "class", "btn btn-danger");
            __builder.AddAttribute(61, "href", "/deletePost/" + (
#nullable restore
#line 47 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                                                                     post.CompanyPostId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 48 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    \r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(67, @"<div class=""modal fade"" id=""applyjob"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">


            <div class=""modal-body"">
                <div class=""container"">
                    <div class=""togglebtns text-center mb-5"">


                    </div>
                    <div class=""text-center"">
                        <form action method=""POST"">
                            <h2 class=""text-center "" style=""color: white;"">Apply For Job</h2>
                            <input class=""form-control  mt-3"" type=""email"" placeholder=""Email""><br>
                            <label class=""text-center"">Attatch Curriculum Vitae</label>
                            <input type=""file""><br>
                            <div class=""formfooter text-right"">
                                <input class=""btn btn-primary"" type=""submit"" value=""Send"">
                            </div>

                        </form>
                    </div>

                </div>
            </div>

        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Shared\JobCard.razor"
       
    [Parameter]
    public CompanyPost post { get; set; }
    protected override void OnInitialized()
    {
        CompanyModel.OnChange += StateHasChanged;
        CandidateLoginServiceModel.OnChange += StateHasChanged;
        CompanyLoginServiceModel.OnChange += StateHasChanged;
        base.OnInitialized();
    }
    public void Dispose()
    {
        CandidateLoginServiceModel.OnChange -= StateHasChanged;
        CompanyLoginServiceModel.OnChange -= StateHasChanged;
        CompanyModel.OnChange -= StateHasChanged;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyStateService CompanyModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CompanyLoginService CompanyLoginServiceModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CandidateLoginService CandidateLoginServiceModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
