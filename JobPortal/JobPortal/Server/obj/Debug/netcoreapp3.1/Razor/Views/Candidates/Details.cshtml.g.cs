#pragma checksum "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Server\Views\Candidates\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cab71466c0a37f8843a579b23417e4dc33d342af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_Details), @"mvc.1.0.view", @"/Views/Candidates/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cab71466c0a37f8843a579b23417e4dc33d342af", @"/Views/Candidates/Details.cshtml")]
    public class Views_Candidates_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobPortal.Server.Models.Candidate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Server\Views\Candidates\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Candidate</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Server\Views\Candidates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CandidateName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Server\Views\Candidates\Details.cshtml"
       Write(Html.DisplayFor(model => model.CandidateName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Server\Views\Candidates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CandidateEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Server\Views\Candidates\Details.cshtml"
       Write(Html.DisplayFor(model => model.CandidateEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Server\Views\Candidates\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CandidatePassord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Server\Views\Candidates\Details.cshtml"
       Write(Html.DisplayFor(model => model.CandidatePassord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 895, "\"", 928, 1);
#nullable restore
#line 34 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Server\Views\Candidates\Details.cshtml"
WriteAttributeValue("", 910, Model.CandidateId, 910, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobPortal.Server.Models.Candidate> Html { get; private set; }
    }
}
#pragma warning restore 1591