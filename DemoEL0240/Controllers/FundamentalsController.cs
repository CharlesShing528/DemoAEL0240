using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEL0240.Controllers
{
    public class FundamentalsController:Controller
    {
        private readonly IWebHostEnvironment _env;

        public FundamentalsController(IWebHostEnvironment env)
        {
            _env = env;
        }

        /// <summary>
        /// 顯示環境名稱
        /// </summary>
        /// <returns></returns>
        public IActionResult EnvironmentName()
        {
            ViewData["EnvName"] = _env.EnvironmentName;
            return View();
        }
        //在View中注入IHostEnvironment
        public IActionResult InjectEnvironment()
        {
            return View();
        }

        //Environment結合Environment Tag Helper
        public IActionResult EnvironmentTagHelper()
        {
            return View();
        }

        //讀取appsettings.json組態設定值
        public IActionResult ReadAppsettings()
        {
            return View();
        }

        //存取DeveloperOptions
        public IActionResult AccessDeveloperOptions()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
