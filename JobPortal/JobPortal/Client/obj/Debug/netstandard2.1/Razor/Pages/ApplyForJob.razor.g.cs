#pragma checksum "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b44b839938c07711acf45682f0fd7520d97964a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/applyJob/{Job}")]
    public partial class ApplyForJob : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "style", "color:white");
            __builder.AddContent(2, " ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
                          msg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 6 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
 if (showJob)
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
                              companyPost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
                                                           applyForJob

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.AddMarkupContent(19, "<h2 class=\"text-center mt-3\" style=\"color: white;\">Apply for Job </h2>\r\n                ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "readonly", true);
                __builder2.AddAttribute(22, "class", "form-control  mt-3");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "placeholder", "Company Name");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
                                              companyPost.CompanyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => companyPost.CompanyName = __value, companyPost.CompanyName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "<br>\r\n                ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "readonly", true);
                __builder2.AddAttribute(30, "class", "form-control mt-3");
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "placeholder", "Job Title");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
                                              companyPost.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => companyPost.JobTitle = __value, companyPost.JobTitle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "<br>\r\n                ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "class", "form-control mt-3");
                __builder2.AddAttribute(38, "type", "text");
                __builder2.AddAttribute(39, "placeholder", "Candidate Name");
                __builder2.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
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
                __Blazor.JobPortal.Client.Pages.ApplyForJob.TypeInference.CreateValidationMessage_0(__builder2, 46, 47, 
#nullable restore
#line 17 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
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
#line 19 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
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
                __Blazor.JobPortal.Client.Pages.ApplyForJob.TypeInference.CreateValidationMessage_1(__builder2, 60, 61, 
#nullable restore
#line 21 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
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
#line 23 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
                                              companyPost.JobLocation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => companyPost.JobLocation = __value, companyPost.JobLocation));
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
#line 31 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\ApplyForJob.razor"
       

    [Parameter]
    public string Job { get; set; }
    CompanyPost companyPost = new CompanyPost();
    bool showCompany = false;
    bool showJob = false;
    string result = "";
    string msg = "";
    protected override async Task OnInitializedAsync()
    {

        List<CompanyPost> companyPosts;

        if (Job.Length != 0)
        {
            result = await Http.GetStringAsync("odata/companypost");
            companyPosts = Newtonsoft.Json.JsonConvert.DeserializeObject<ODataCandidate<CompanyPost>>(result).Value;
            foreach (CompanyPost post in companyPosts)
            {
                if (post.CompanyPostId.ToString() == Job.ToString())
                {
                    companyPost = post;
                }
            }
            showJob = true;
        }

    }

    public void applyForJob()
    {
        ApplyJob apply = new ApplyJob();
        apply.CandidateName = Model.MyCandidateState.CandidateName;
        apply.CompanyName = companyPost.CompanyName;
        apply.JobLocation = companyPost.JobLocation;
        apply.JobTitle = companyPost.JobTitle;
        apply.CandidateEmail = Model.MyCandidateState.CandidateEmail;
        Http.PostAsJsonAsync<ApplyJob>("api/applyjobCrud", apply);
        msg = "Successfully Applied";
        showJob = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CandidateStateService Model { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.JobPortal.Client.Pages.ApplyForJob
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