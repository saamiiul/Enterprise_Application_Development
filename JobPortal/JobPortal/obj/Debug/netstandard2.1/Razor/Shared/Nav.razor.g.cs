#pragma checksum "C:\Users\Usama\Desktop\JobPortal\JobPortal\Shared\Nav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea226c26afa42c6fe52a976e615b4ff1a6ec0fd3"
// <auto-generated/>
#pragma warning disable 1591
namespace JobPortal.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Usama\Desktop\JobPortal\JobPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usama\Desktop\JobPortal\JobPortal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usama\Desktop\JobPortal\JobPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usama\Desktop\JobPortal\JobPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Usama\Desktop\JobPortal\JobPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Usama\Desktop\JobPortal\JobPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Usama\Desktop\JobPortal\JobPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Usama\Desktop\JobPortal\JobPortal\_Imports.razor"
using JobPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Usama\Desktop\JobPortal\JobPortal\_Imports.razor"
using JobPortal.Shared;

#line default
#line hidden
#nullable disable
    public partial class Nav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>hhhhhhhhhhhhhhhhhhdsdjkaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaacbjkkkkkkkkkkkkkkkkkkkkkkkkkkueeeeeeeeeeeeeeebcn\r\n    jsbadhhssjdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsdijdiiiiiiiiiwdnwnd</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"modal fade\" id=\"exampleModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n\r\n\r\n            <div class=\"modal-body\">\r\n                <div class=\"wrapper\">\r\n\r\n                    <div class=\"form-container\">\r\n                        <div class=\"slide-controls\">\r\n                            <input type=\"radio\" name=\"slide\" id=\"login\" checked>\r\n                            <input type=\"radio\" name=\"slide\" id=\"signup\">\r\n                            <label for=\"login\" class=\"slide login\">Candidate</label>\r\n                            <label for=\"signup\" class=\"slide signup\">Company</label>\r\n                            <div class=\"slider-tab\"></div>\r\n                        </div>\r\n                        <div class=\"form-inner\">\r\n                            <form action=\"#\" class=\"login\">\r\n                                <div class=\"field\">\r\n                                    <input type=\"text\" placeholder=\"Name\" required>\r\n                                </div>\r\n                                <div class=\"field\">\r\n                                    <input type=\"email\" placeholder=\"Email Address\" required>\r\n                                </div>\r\n                                <div class=\"field\">\r\n                                    <input type=\"password\" placeholder=\"Password\" required>\r\n                                </div>\r\n                                <div class=\"field\">\r\n                                    <input type=\"password\" placeholder=\"Confirm Password\" required>\r\n                                </div>\r\n\r\n                                <div class=\"field btn\">\r\n                                    <div class=\"btn-layer\"></div>\r\n                                    <input type=\"submit\" value=\"SignUp\">\r\n                                </div>\r\n\r\n                            </form>\r\n                            <form action=\"#\" class=\"signup\">\r\n                                <div class=\"field\">\r\n                                    <input type=\"text\" placeholder=\"Company Name\" required>\r\n                                </div>\r\n                                <div class=\"field\">\r\n                                    <input type=\"email\" placeholder=\"Email\" required>\r\n                                </div>\r\n                                <div class=\"field\">\r\n                                    <input type=\"password\" placeholder=\"Password\" required>\r\n                                </div>\r\n                                <div class=\"field\">\r\n                                    <input type=\"password\" placeholder=\"Confirm password\" required>\r\n                                </div>\r\n                                <div class=\"field btn\">\r\n                                    <div class=\"btn-layer\"></div>\r\n                                    <input type=\"submit\" value=\"Signup\">\r\n                                </div>\r\n                            </form>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"modal fade\" id=\"loginModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n\r\n\r\n            <div class=\"modal-body\">\r\n                <div class=\"container\">\r\n                    <div class=\"togglebtns text-center mb-5\">\r\n                        <button id=\"candidatebtn\">Candidate</button>\r\n                        <button id=\"companybtn\">Company</button>\r\n                    </div>\r\n                    <div id=\"candidateloginform\">\r\n                        <form action method=\"POST\">\r\n                            <h2 class=\"text-center \" style=\"color: white;\">Candidate Login</h2>\r\n                            <input class=\"form-control \" type=\"email\" placeholder=\"Email\"><br>\r\n                            <input class=\"form-control \" type=\"password\" placeholder=\"Password\"><br>\r\n                            <div class=\"formfooter text-right\">\r\n                                <input class=\"btn btn-primary\" type=\"submit\" value=\"Login\">\r\n                            </div>\r\n\r\n                        </form>\r\n                    </div>\r\n                    <div id=\"companyloginform\">\r\n                        <form action method=\"POST\">\r\n                            <h2 class=\"text-center\" style=\"color: white;\">Company Login</h2>\r\n                            <input class=\"form-control \" type=\"email\" placeholder=\"Name\"><br>\r\n                            <input class=\"form-control \" type=\"password\" placeholder=\"Password\"><br>\r\n                            <div class=\"formfooter text-right\">\r\n                                <input class=\"btn btn-primary\" type=\"submit\" value=\"Login\">\r\n                            </div>\r\n                        </form>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __builder.AddMarkupContent(3, "<style>\r\n    body {\r\n        background-color: black;\r\n    }\r\n\r\n\r\n\r\n    .row {\r\n        margin-left: 10px;\r\n        margin-right: 15px;\r\n    }\r\n\r\n    .top-bar {\r\n        background-color: rgba(255, 255, 255, 0.2);\r\n        padding-bottom: 15px;\r\n    }\r\n\r\n    .top-bar-left {\r\n        margin-top: 10px;\r\n    }\r\n\r\n    span {\r\n        color: #fff;\r\n        font-family: sans-serif;\r\n        font-size: 14px;\r\n    }\r\n\r\n    .mainspan {\r\n        margin-left: 20px;\r\n    }\r\n\r\n    i {\r\n        color: white;\r\n    }\r\n\r\n    .signupbtn {\r\n        background: #1AAB8A;\r\n        color: #fff;\r\n        border: none;\r\n        padding: 5px 10px;\r\n        cursor: pointer;\r\n        transition: 800ms ease all;\r\n        outline: none;\r\n        margin-top: 15px;\r\n        float: right;\r\n        transform: translate(-50%,-20%);\r\n        border-radius: 5px;\r\n    }\r\n\r\n        .signupbtn:hover {\r\n            background: #fff;\r\n            color: #1AAB8A;\r\n        }\r\n\r\n    .loginbtn {\r\n        background: #2980b9;\r\n        color: #fff;\r\n        border: none;\r\n        padding: 5px 10px;\r\n        cursor: pointer;\r\n        transition: 800ms ease all;\r\n        outline: none;\r\n        margin-top: 15px;\r\n        float: right;\r\n        transform: translate(-50%,-20%);\r\n        border-radius: 5px;\r\n    }\r\n\r\n        .loginbtn:hover {\r\n            background: white;\r\n            color: #2980b9;\r\n        }\r\n\r\n    .modal-content {\r\n        background-color: rgba(255, 255, 255, 0.03);\r\n        backdrop-filter: blur(5px);\r\n    }\r\n\r\n    .modal {\r\n        background-color: rgba(100, 100, 100, 0);\r\n    }\r\n\r\n    .modal-header {\r\n        border: none;\r\n    }\r\n\r\n    .modal-footer {\r\n        border: none;\r\n    }\r\n\r\n    .modal-title {\r\n        color: white;\r\n        font-family: sans-serif;\r\n    }\r\n\r\n    .form-control {\r\n        opacity: 0.6;\r\n        max-width: 50%;\r\n        margin-left: 25%;\r\n        border-radius: 25px;\r\n    }\r\n\r\n    .modal-body form label {\r\n        color: white;\r\n        font-family: sans-serif\r\n    }\r\n\r\n    .form-control::placeholder {\r\n        color: black;\r\n        opacity: 1; /* Firefox */\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
