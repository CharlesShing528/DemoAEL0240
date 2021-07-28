using DemoEL0240.Models;
using DemoEL0240.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoEL0240.Controllers
{
    public class RazorController:Controller
    {
        //C# 6.0 - Auto Property Initializer
        public List<Card> cards { get; } = new List<Card>
        {
            new Card { Name = "Elon Musk", Brief="特斯拉創辦人 伊隆·馬斯克", Photo="ElonMusk.jpg", WikiUrl="https://goo.gl/46xeXx" },
            new Card { Name = "Mark Zuckerberg", Brief="Facebook創辦人 馬克·祖伯克", Photo="MarkZuckerberg.jpg", WikiUrl="https://goo.gl/BktGGA" },
            new Card { Name = "Steve Jobs", Brief="蘋果創辦人 史提夫·賈伯斯", Photo="SteveJobs.jpg", WikiUrl="https://goo.gl/nAiX0y" },
            new Card { Name = "Vader", Brief="帝國元帥  維達", Photo="Vader.jpg", WikiUrl="https://en.wikipedia.org/wiki/Darth_Vader" },
            new Card { Name = "Darth Mual", Brief="星際大戰 達斯摩", Photo="DarthMual.jpg", WikiUrl="https://goo.gl/5obLhX"},
            new Card { Name = "White Twilek", Brief="星際大戰 女絕地武士Twilek", Photo="WhiteTwilek.jpg", WikiUrl="https://goo.gl/reKzAu" },
            new Card { Name = "Obiwan", Brief="星際大戰 歐比旺Obiwan", Photo="Obiwan.jpg", WikiUrl="http://bit.ly/33gxdgt" },
            new Card { Name = "Merkel", Brief="德國總理 梅克爾", Photo="Merkel.jpg", WikiUrl="http://bit.ly/33huSlv" }
        };

        private readonly IWebHostEnvironment _hostingEnvironment;
        public RazorController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Razor規則
        public IActionResult RazorRules()
        {
            return View();
        }

        //Razor陳述式
        public IActionResult RazorStatement()
        {
            return View();
        }

        /*
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
         */

        public IActionResult RazorFunctions()
        {
            return View();
        }

        /// <summary>
        /// View 以 @Inherits 繼承自訂 RazorPage類別
        /// 1.自訂 RazorPage<dynamic> 類別，新增屬性與方法 RazorPage/CustomRazorPage.cs
        /// 2.View 以@inherits 繼承自訂RazorPage類別。 View/Razor/InheritsRazorPage.cshtml
        /// 3. Controller 傳遞 ViewModel 資料給 View 檢視。Controllers/RazorController.cs
        /// </summary>
        /// <returns></returns>
        public IActionResult InheritsRazorPage()
        {
            AuthorViewModel author = new AuthorViewModel { Name = "星際大戰" };
            return View(author);
        }

        public IActionResult RazorTemplated()
        {
            return View();
        }


        public async Task<IActionResult> MakeRequest()
        {
            HttpClient client = new HttpClient();

            try
            {
                //string dataUrl = "https://raw.githubusercontent.com/apprunner/FileStorage/master/Temperature.json";
                string dataUrl = "https://www.tenlong.com.tw/zh_tw/recent_bestselling?range=7";
                HttpResponseMessage response = await client.GetAsync(dataUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                string responseContent = await client.GetStringAsync(dataUrl);

                ViewData["responseText"] = responseBody;

                return View();
            }
            catch (Exception ex)
            {
                return Content("Error Message :" + ex);
            }

            //return Content("Nothing");
        }

        public IActionResult DemoCheckBox()
        {
            List<SelectListItem> items = PopulateFruits();
            return View(items);
        }

        [HttpPost]
        public IActionResult DemoCheckBox(string[] fruit)
        {
            ViewBag.Message = "Selected Items:\\n";
            List<SelectListItem> items = PopulateFruits();
            foreach (SelectListItem item in items)
            {
                if (fruit.Contains(item.Value))
                {
                    item.Selected = true;
                    ViewBag.Message += string.Format("{0}\\n", item.Text);
                }
            }

            return View(items);
        }

        private static List<SelectListItem> PopulateFruits()
        {
            string constr = @"Data Source=.\;Initial Catalog=FruitsDB;User Id=sa;Password=p@ssw0rd;";
            List<SelectListItem> items = new List<SelectListItem>();
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = " SELECT FruitName, FruitId FROM Fruits";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr["FruitName"].ToString(),
                                Value = sdr["FruitId"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return items;
        }
    }
}
