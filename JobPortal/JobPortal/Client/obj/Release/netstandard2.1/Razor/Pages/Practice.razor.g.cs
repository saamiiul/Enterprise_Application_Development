#pragma checksum "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Practice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e4a0f44d7665169c7137df0b507331d85ec022"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/practice/{id}")]
    public partial class Practice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "background-color:white; color:black");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 3 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Practice.razor"
     foreach (var check in CheckBoxList())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "class", "custom-checkbox");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Practice.razor"
                                                                  eventArgs => { CheckboxClicked(check, eventArgs.Value); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.AddContent(9, 
#nullable restore
#line 6 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Practice.razor"
         check

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "        <br>\r\n");
#nullable restore
#line 8 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Practice.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\samiu\OneDrive\Desktop\Enterprise_Application_Development\JobPortal\JobPortal\Client\Pages\Practice.razor"
       
    [Parameter]
    public string id { get; set; }
    public List<string> CheckBox { get; set; } = new List<string>();
    void CheckboxClicked(string CheckID, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            if (!CheckBox.Contains(CheckID))
            {
                CheckBox.Add(CheckID);
            }
        }
        else
        {
            if (CheckBox.Contains(CheckID))
            {
                CheckBox.Remove(CheckID);
            }
        }
    }

    public List<String> CheckBoxList()
    {
        List<String> checkBox = new List<String>();
        checkBox.Add("CheckBox 1");
        checkBox.Add("CheckBox 2");
        return checkBox;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591