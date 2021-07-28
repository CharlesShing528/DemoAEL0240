using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEL0240.Controllers
{
    public class LabsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RazorToCSharp()
        {
            return View();
        }
    }
}
