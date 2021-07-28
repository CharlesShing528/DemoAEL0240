#pragma checksum "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Fundamentals\InjectEnvironment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "877da60cfa615d2658f7ae3a52a055cc9f768b22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fundamentals_InjectEnvironment), @"mvc.1.0.view", @"/Views/Fundamentals/InjectEnvironment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877da60cfa615d2658f7ae3a52a055cc9f768b22", @"/Views/Fundamentals/InjectEnvironment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2e47e54936a1be45ed518a9dbd57b6d37cba00", @"/Views/_ViewImports.cshtml")]
    public class Views_Fundamentals_InjectEnvironment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Fundamentals\InjectEnvironment.cshtml"
  
    ViewData["Title"] = "InjectEnvironment";

    string DisplayEnvironment(string envName) =>
        envName switch
        {
            "Development" => "開發環境",
            "Staging" => "預備環境",
            "Production" => "生產環境",
            _ => "其他環境"
        };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>在View中注入IHostEnvironment</h1>\r\n\r\n<p>目前環境是: ");
#nullable restore
#line 17 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Fundamentals\InjectEnvironment.cshtml"
     Write(DisplayEnvironment(env.EnvironmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment env { get; private set; }
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