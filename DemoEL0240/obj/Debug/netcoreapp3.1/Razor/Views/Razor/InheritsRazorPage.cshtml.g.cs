#pragma checksum "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\InheritsRazorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78676681ad9c8f00dfc433312de190bb2435d666"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Razor_InheritsRazorPage), @"mvc.1.0.view", @"/Views/Razor/InheritsRazorPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78676681ad9c8f00dfc433312de190bb2435d666", @"/Views/Razor/InheritsRazorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2e47e54936a1be45ed518a9dbd57b6d37cba00", @"/Views/_ViewImports.cshtml")]
    public class Views_Razor_InheritsRazorPage : DemoEL0240.RazorPage.CustomRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\InheritsRazorPage.cshtml"
  
    ViewData["Title"] = "InheritsRazorPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron bg-success\">\r\n    <h1>");
            WriteLiteral("@Inherits</h1>\r\n</div>\r\n\r\n<p>書籍名稱: ");
#nullable restore
#line 11 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\InheritsRazorPage.cshtml"
    Write(GetBookName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>ASP.NET Core版本 : ");
#nullable restore
#line 12 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\InheritsRazorPage.cshtml"
               Write(AppVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>作者: ");
#nullable restore
#line 13 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\InheritsRazorPage.cshtml"
  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
