using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEL0240.RazorPage
{  
    /// <summary>
    /// 7-7 View 以@inherits 繼承自訂 RazorPage 類別
    /// Step 1 CustomRazorPage<dynamic> 可將所有<dynamic> 換成 <TModel>
    /// </summary>
    /// <typeparam name="dynamic"></typeparam>
    public abstract class CustomRazorPage<dynamic> :RazorPage<dynamic>
    {
        public string AppVersion { get; } = "ASP.NET Core 3.1";

        public string GetBookName()
        {
            return "ASP.NET Core 3.1 MVC範例教學實戰";
        }
    }
}
