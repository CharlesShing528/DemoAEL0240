using DemoEL0240.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEL0240.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///  範例 5-2 製作員工通訊錄列表
        /// </summary>
        /// <returns></returns>
        public IActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 10001, Name = "David", Phone = "0933154228", Email ="david@gmail.com" },
                new Employee { Id = 10002, Name = "Mary", Phone = "0925157886", Email ="mary@gmail.com" },
                new Employee { Id = 10003, Name = "John", Phone = "0921335884", Email ="john@gmail.com" },
                new Employee { Id = 10004, Name = "Cindy", Phone = "0971628322", Email ="cindy@gmail.com" },
                new Employee { Id = 10005, Name = "Rose", Phone = "0933154228",  Email ="rose@gmail.com" }
            };

            return View(employees);
        }
    }
}
