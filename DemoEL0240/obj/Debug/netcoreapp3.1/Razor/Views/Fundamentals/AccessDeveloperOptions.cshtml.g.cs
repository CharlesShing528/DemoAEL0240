#pragma checksum "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Fundamentals\AccessDeveloperOptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a0c18f41536b386fa3dca2a0a74fbf8d20b7d8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fundamentals_AccessDeveloperOptions), @"mvc.1.0.view", @"/Views/Fundamentals/AccessDeveloperOptions.cshtml")]
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
#nullable restore
#line 1 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Fundamentals\AccessDeveloperOptions.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a0c18f41536b386fa3dca2a0a74fbf8d20b7d8d", @"/Views/Fundamentals/AccessDeveloperOptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2e47e54936a1be45ed518a9dbd57b6d37cba00", @"/Views/_ViewImports.cshtml")]
    public class Views_Fundamentals_AccessDeveloperOptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Fundamentals\AccessDeveloperOptions.cshtml"
  
    ViewData["Title"] = "AccessDeveloperOptions";
    var devOptions = developerOptions.CurrentValue;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron bg-info\">\r\n    <h1>??????DeveloperOptions????????????</h1>\r\n</div>\r\n\r\n<ul>\r\n    <li>Name : ");
#nullable restore
#line 14 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Fundamentals\AccessDeveloperOptions.cshtml"
          Write(devOptions.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Email : ");
#nullable restore
#line 15 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Fundamentals\AccessDeveloperOptions.cshtml"
           Write(devOptions.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Website : ");
#nullable restore
#line 16 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Fundamentals\AccessDeveloperOptions.cshtml"
             Write(devOptions.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptionsMonitor<DemoEL0240.Options.DeveloperOptions> developerOptions { get; private set; }
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
