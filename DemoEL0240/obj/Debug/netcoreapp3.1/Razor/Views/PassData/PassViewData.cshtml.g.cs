#pragma checksum "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d70724545cd1f2a8c12167a45ebf340fc965e5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PassData_PassViewData), @"mvc.1.0.view", @"/Views/PassData/PassViewData.cshtml")]
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
#nullable restore
#line 1 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\_ViewImports.cshtml"
using DemoEL0240;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\_ViewImports.cshtml"
using DemoEL0240.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d70724545cd1f2a8c12167a45ebf340fc965e5b", @"/Views/PassData/PassViewData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2e47e54936a1be45ed518a9dbd57b6d37cba00", @"/Views/_ViewImports.cshtml")]
    public class Views_PassData_PassViewData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
  
    ViewData["Title"] = "PassViewData";

    var emps = (List<Employee>)ViewData["Employees"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron alert-success\">\r\n    <h2>以ViewData傳遞資料</h2>\r\n</div>\r\n\r\n\r\n<ul>\r\n    <li>Name : ");
#nullable restore
#line 13 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
          Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Age : ");
#nullable restore
#line 14 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
          Write((int)ViewData["Age"] + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
            WriteLiteral("\r\n    <li>Single : ");
#nullable restore
#line 15 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
            Write(ViewData["Single"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n\r\n<hr />\r\n<ul>\r\n");
#nullable restore
#line 21 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
     foreach (var item in ViewData)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 23 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
       Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 23 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
                  Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 24 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<hr />\r\n<ul>\r\n");
#nullable restore
#line 29 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
     foreach (Employee emp in emps)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 31 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
       Write(emp.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 31 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
                Write(emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 31 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
                           Write(emp.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 31 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
                                       Write(emp.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\PassData\PassViewData.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591