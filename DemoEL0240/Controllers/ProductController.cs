using DemoEL0240.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEL0240.Controllers
{
    public class ProductController:Controller
    {
        List<Product> products { get; } = new List<Product>
        {
            new Product { ProductId = 1, Name="Mobile Phone" , Price = 8000 },
            new Product { ProductId = 2, Name="PC Computer", Price = 25000 },
            new Product { ProductId = 3, Name="NB" , Price = 35000 }
        };
        [Route("Product/{id:int}")]
        public IActionResult Details(int id)
        {
            return View(products.FirstOrDefault(p => p.ProductId == id));
        }

        [Route("Product/Eval", Name = "ProductEvals")]
        public IActionResult Evaluations(int id) => View();

        [Route("Product/Avail", Name = "ProductAvailable")]
        public IActionResult Available(int productId, bool available) => View();

        public IActionResult Index() => View(products);
    }
}
