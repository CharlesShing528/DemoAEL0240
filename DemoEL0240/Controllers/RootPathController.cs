using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEL0240.Controllers
{
    public class RootPathController:Controller
    {
        private readonly IWebHostEnvironment _env;
        public RootPathController(IWebHostEnvironment env)//IWebHostEnvironment 環境變數
        {
            _env = env;
            string contentRoot = env.ContentRootPath;// 讀取 ContentRootPath 屬性
        }

        // Content Root Path
        public IActionResult ContentRootPath()
        {
            ViewData["ContentRootPath"] = _env.ContentRootPath;//讀取 ContentRootPath 屬性
            return View();
        }

        //Web Root Path
        public IActionResult WebRootPath()
        {
            ViewData["WebRootPath"] = _env.WebRootPath;

            return View();
        }
    }
}
