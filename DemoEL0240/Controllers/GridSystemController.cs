using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEL0240.Controllers
{
    public class GridSystemController: Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //
        public ActionResult GridBasic()
        {
            return View();
        }

        //
        public ActionResult ColumnsMixed()
        {
            return View();
        }

        public ActionResult ColumnsExample()
        {
            return View();
        }

        public ActionResult ColumnsOffset()
        {
            return View();
        }


        public ActionResult GridExampleRazor()
        {
            return View();
        }





        public ActionResult TextAlignment()
        {
            return View();
        }
    }
}
