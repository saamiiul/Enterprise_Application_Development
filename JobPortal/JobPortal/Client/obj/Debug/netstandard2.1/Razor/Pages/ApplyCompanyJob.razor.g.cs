#pragma checksum "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2509803f30d1b82ed018a21d47a8d846c8fec54f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/applyCompany/{Company}")]
    public partial class ApplyCompanyJob : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "style", "color:white");
            __builder.AddContent(2, " ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                          msg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 6 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
 if (showCompany)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-4");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<h2 class=\"text-center mt-3\" style=\"color: white;\">Apply For Job </h2>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                              editPost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                                                        applyCompanyJob

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "readonly", true);
                __builder2.AddAttribute(22, "class", "form-control  mt-3");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "placeholder", "Company Name");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                                              editPost.CompanyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => editPost.CompanyName = __value, editPost.CompanyName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "<br>\r\n                ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "class", "form-control mt-3");
                __builder2.AddAttribute(30, "type", "text");
                __builder2.AddAttribute(31, "placeholder", "Job Title");
                __builder2.AddAttribute(32, "required", true);
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                                     getJob

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => getJob = __value, getJob));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n                ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "class", "form-control mt-3");
                __builder2.AddAttribute(38, "type", "text");
                __builder2.AddAttribute(39, "placeholder", "Candidate Name");
                __builder2.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                                     Model.MyCandidateState.CandidateName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.MyCandidateState.CandidateName = __value, Model.MyCandidateState.CandidateName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "style", "color:red");
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __Blazor.JobPortal.Client.Pages.ApplyCompanyJob.TypeInference.CreateValidationMessage_0(__builder2, 46, 47, 
#nullable restore
#line 18 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                                              ()=>Model.MyCandidateState.CandidateName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(48, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "<br>\r\n                ");
                __builder2.OpenElement(50, "input");
                __builder2.AddAttribute(51, "class", "form-control mt-3");
                __builder2.AddAttribute(52, "type", "text");
                __builder2.AddAttribute(53, "placeholder", "Candidate Email");
                __builder2.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                                     Model.MyCandidateState.CandidateEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.MyCandidateState.CandidateEmail = __value, Model.MyCandidateState.CandidateEmail));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "style", "color:red");
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __Blazor.JobPortal.Client.Pages.ApplyCompanyJob.TypeInference.CreateValidationMessage_1(__builder2, 60, 61, 
#nullable restore
#line 22 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                                              ()=>Model.MyCandidateState.CandidateEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "<br>\r\n                ");
                __builder2.OpenElement(64, "input");
                __builder2.AddAttribute(65, "readonly", true);
                __builder2.AddAttribute(66, "class", "form-control mt-3");
                __builder2.AddAttribute(67, "type", "text");
                __builder2.AddAttribute(68, "placeholder", "Job Location");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
                                              editPost.CompanyLocation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => editPost.CompanyLocation = __value, editPost.CompanyLocation));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "<br>\r\n                ");
                __builder2.AddMarkupContent(72, "<div class=\"formfooter text-right\">\r\n                    <input class=\"btn btn-primary\" type=\"submit\" value=\"Apply\">\r\n                </div>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 32 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyCompanyJob.razor"
       
    [Parameter]
    public string Company { get; set; }
    string getJob = "";
    Company editPost = new Company();

    bool showCompany = false;
    string msg = "";
    string result = "";
    protected override async Task OnInitializedAsync()
    {
        List<Company> posts;


        result = await Http.GetStringAsync("odata/companies");
        posts = Newtonsoft.Json.JsonConvert.DeserializeObject<ODataCandidate<Company>>(result).Value;
        foreach (Company post in posts)
        {
            if (post.CompanyId.ToString() == Company.ToString())
            {
                editPost = post;
            }
        }
        showCompany = true;


    }
    public void applyCompanyJob()
    {
        ApplyJob apply = new ApplyJob();
        apply.CandidateName = Model.MyCandidateState.CandidateName;
        apply.CompanyName = editPost.CompanyName;
        apply.JobLocation = editPost.CompanyLocation;
        apply.JobTitle = getJob;
        apply.CandidateEmail = Model.MyCandidateState.CandidateEmail;
        Http.PostAsJsonAsync<ApplyJob>("api/applyjobCrud", apply);
        showCompany = false;
        msg = "Successfully Applied.";

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CandidateStateService Model { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.JobPortal.Client.Pages.ApplyCompanyJob
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
