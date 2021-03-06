#pragma checksum "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bcdd2bbf4c60c93be25c9fdef52cfd106d24cc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Razor_RazorRules), @"mvc.1.0.view", @"/Views/Razor/RazorRules.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcdd2bbf4c60c93be25c9fdef52cfd106d24cc3", @"/Views/Razor/RazorRules.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2e47e54936a1be45ed518a9dbd57b6d37cba00", @"/Views/_ViewImports.cshtml")]
    public class Views_Razor_RazorRules : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/SteveJobs.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
  
    ViewData["Title"] = "Razor Rules";
    var num = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"jumbotron alert-success\"><h2>Razor語法規則</h2></div>\r\n<div class=\"content\">\r\n    <!--Razor = HTML + C#-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 13 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"：Razor語法包含：(1) HTML語法 (2) C#語法兩部分</div>
    <p>
        <article>
            遇到HTML的Markup,就解析為HTML (HTML Parser)， <br />
            遇到單一@符號開頭,就解析為C#語法 (C# Parser)。<br />
        </article>
    </p>

    <!--2.Single statement blocks-->
    <div class=""alert alert-info"">規則");
#nullable restore
#line 22 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：單行C#程式區塊</div>\r\n");
#nullable restore
#line 23 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
       var City = "Taipei"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
       var PostalCode = 110; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <p>\r\n        <del>Code Block中的C#變數或程式不做HTML輸出</del>\r\n    </p>\r\n\r\n");
#nullable restore
#line 31 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
       string city = "Taoyuan"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
       int postalCode = 334; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!--3.Multi statement blocks-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 35 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：多行C#程式區塊</div>\r\n");
#nullable restore
#line 36 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
      
        var Name = "Kevin";
        var Height = 180;
        var Weight = 75;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <del>Code Block中的C#變數或程式不做HTML輸出</del>\r\n    </p>\r\n\r\n    <!--4.Inline Expression-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 46 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：Inline表達式</div>\r\n    <p>我的名字: ");
#nullable restore
#line 47 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
        Write(Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>我的身高: ");
#nullable restore
#line 48 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
        Write(Height);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>我的體重: ");
#nullable restore
#line 49 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
        Write(Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p>居住城市: ");
#nullable restore
#line 50 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
        Write(City);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n    <p>郵遞區號: ");
#nullable restore
#line 51 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
        Write(PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n    <!--5.Implicit transitions-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 54 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：Code Block中的HTML與C#隱式切換</div>\r\n");
#nullable restore
#line 55 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
      
        var LeapYear = DateTime.IsLeapYear(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>今年是否為閏年：");
#nullable restore
#line 57 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
              Write(LeapYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
            WriteLiteral("\r\n    <!--6.C#關鍵字區分大小寫-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 61 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：Razor語法中的C#關鍵字區分大小寫</div>\r\n");
#nullable restore
#line 62 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
      
        var MyName = "聖殿祭司";
        var myName = "奚江華";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        筆名: ");
#nullable restore
#line 67 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
       Write(MyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        姓名: ");
#nullable restore
#line 68 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
       Write(myName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    </p>\r\n\r\n    <!--7.單行註解-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 72 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：單行註解表示法");
            WriteLiteral("@*...*");
            WriteLiteral("@</div>\r\n    <p>\r\n        ");
            WriteLiteral("@*這是單行註解*");
            WriteLiteral("@\r\n    </p>\r\n\r\n    <!--8.多行註解-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 78 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：多行註解表示法");
            WriteLiteral("@*...*");
            WriteLiteral("@</div>\r\n    <article>\r\n");
            WriteLiteral("        <p>");
            WriteLiteral("@*多行註解</p>\r\n        <p>也有支援*");
            WriteLiteral("@</p>\r\n    </article>\r\n\r\n    <!--9.Implicit Razor expressions-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 87 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：隱性Razor表達式是由@符號開頭，系統會將它解析為C#語法</div>\r\n    <p>現在的時間是：");
#nullable restore
#line 88 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
         Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong> -- ");
            WriteLiteral("@DateTime.Now </strong></p>\r\n\r\n    <!--10.Explicit Razor expressions-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 91 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：明確Razor表達式是由");
            WriteLiteral("@(...)前後帶括號組成</div>\r\n    <p>兩週前我出國去玩，出發日期是：");
#nullable restore
#line 92 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                  Write((DateTime.Now - TimeSpan.FromDays(14)).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong>  -- ");
            WriteLiteral("@((DateTime.Now - TimeSpan.FromDays(14)).ToShortDateString()) </strong></p>\r\n    <p>3+7的結果是: ");
#nullable restore
#line 93 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
            Write(3 + 7);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n    <!--11.");
            WriteLiteral("@跳脫符號-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 96 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：需要顯示");
            WriteLiteral("@符號時，是用兩個");
            WriteLiteral("@");
            WriteLiteral("@小老鼠符號來表示，才不會和Razor的@符號混淆</div>\r\n    <p>\r\n        ");
            WriteLiteral("@_");
            WriteLiteral("@ <br />\r\n    <p>\r\n    <p>\r\n        但Email和超連結例外<br />\r\n        我的電子郵件: dotnetcool@gmail.com <br />\r\n        <a href=\"mailto:service@domain.com\">Service@domain.com</a>\r\n    </p>\r\n\r\n    <!--12.\"\"雙引號-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 107 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：如果變數字串想顯示雙引號, 就用連續兩個\"\"雙引號表示</div>\r\n");
#nullable restore
#line 108 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
       var word = @"子曰："" 三人行，必有我師焉 ""...";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 109 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
  Write(word);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <!--13.用將HTML或JS編碼成純文字-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 112 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：用");
            WriteLiteral("@(...)將HTML或JS編碼成純文字</div>\r\n");
#nullable restore
#line 113 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
       var msg = @"<button type='button' onclick='alert(""Hi JavaScript"")'> Raw原始字串, 不做HTML編碼</button>"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <p>");
#nullable restore
#line 115 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
   Write(msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    ");
#nullable restore
#line 116 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
Write("<span>Hello MVC!</span>");

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n    <!--14：用");
            WriteLiteral("@Html.Raw()顯示原始字串-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 119 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：用");
            WriteLiteral("@Html.Raw()顯示原始字串, 不做HTML編碼</div>\r\n    <p>");
#nullable restore
#line 120 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
  Write(Html.Raw(msg));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <p>使用");
            WriteLiteral("@Html.Raw()顯示原始字串, 不做HTML編碼. JavaScript也可以隱藏其中, 會有安全上的考量</p>\r\n\r\n    <!--15.磁碟路徑表示法-->\r\n    <div class=\"alert alert-info\">規則");
#nullable restore
#line 125 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                                Write(num++);

#line default
#line hidden
#nullable disable
            WriteLiteral("：磁碟路徑表示法</div>\r\n\r\n");
#nullable restore
#line 127 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
       var filePath = @"c:\CoreMvc3Examples\CoreMvc3_Razor\CoreMvc3_Razor"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>磁碟路徑: ");
#nullable restore
#line 128 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
        Write(filePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <p>ContentRootPath路徑: ");
#nullable restore
#line 130 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                     Write(_env.ContentRootPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>WebRootPath路徑: ");
#nullable restore
#line 131 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                 Write(_env.WebRootPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 133 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
      
        string imageVirtualPath = @"/images/SteveJobs.jpg";
        string imagePhysicalPath = System.IO.Path.Combine(_env.WebRootPath, @"images\SteveJobs.jpg");
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <p>Virtual Path虛擬路徑: ");
#nullable restore
#line 138 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                    Write(imageVirtualPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Physical path實際路徑: ");
#nullable restore
#line 139 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
                     Write(imagePhysicalPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 4251, "\"", 4274, 1);
#nullable restore
#line 140 "D:\07_DemoCode\DemoEL0240\DemoEL0240\Views\Razor\RazorRules.cshtml"
WriteAttributeValue("", 4257, imageVirtualPath, 4257, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9bcdd2bbf4c60c93be25c9fdef52cfd106d24cc318126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("topCSS", async() => {
                WriteLiteral(@"
    <style>
        div.alert {
            background-color: #d9edfd;
            font-size: larger;
            font-weight: 900;
            border: 2px dashed black;
        }

        body {
            /*background-color: orange;*/
            height: 100vh;
        }

        .container.body-content {
            /*height: 100%;*/
        }

        .content {
            /*height: 90%;*/
            background-color: #f3eded;
            border-radius: 10px;
            padding: 15px;
        }

        h5 {
            color: white;
            background-color: slateblue;
            border-radius: 5px;
            padding: 5px;
            display: inline-block;
            width: 768px;
        }

        strong {
            color: blue;
        }

        img {
            width: auto;
            height: 170px;
        }
    </style>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment _env { get; private set; }
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
