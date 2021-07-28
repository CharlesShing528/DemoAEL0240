#pragma checksum "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Shared\_PortFunctionPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef77396691d1d0d7c5d9f6cd5fba6160b07b089"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PortFunctionPartial), @"mvc.1.0.view", @"/Views/Shared/_PortFunctionPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef77396691d1d0d7c5d9f6cd5fba6160b07b089", @"/Views/Shared/_PortFunctionPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2e47e54936a1be45ed518a9dbd57b6d37cba00", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PortFunctionPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Shared\_PortFunctionPartial.cshtml"
  
    var portNumber = (int)ViewData["PortNumber"];

    /*
    var result = "";

    switch (portNumber)
    {
        case 80:
            result = $"{portNumber}, 這是HTTP使用的Port號碼";
            break;
        case 110:
            result = $"{portNumber}, 這是POP3使用的Port號碼";
            break;
        case 143:
            result = $"{portNumber}, 這是IMAP使用的Port號碼";
            break;
        case 443:
            result = $"{portNumber}, 這是HTTPS使用的Port號碼";
            break;
        case 587:
            result = $"{portNumber}, 這是SMTP使用的Port號碼";
            break;
        default:
            result = $"{portNumber}, 這裡沒有記載這個Port號碼的用途";
            break;
    }
    */

    string PortFunction(int port) =>
        port switch
        {
            80 => $"{port}, 這是HTTP使用的Port號碼",
            110 => $"{port}, 這是POP3使用的Port號碼",
            143 => $"{port}, 這是IMAP使用的Port號碼",
            443 => $"{port}, 這是HTTPS使用的Port號碼",
            587 => $"{port}, 這是SMTP使用的Port號碼",
            _ => $"{port}, 這裡沒有記載這個Port號碼的用途"
        };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>");
#nullable restore
#line 44 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Shared\_PortFunctionPartial.cshtml"
Write(PortFunction(portNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n");
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