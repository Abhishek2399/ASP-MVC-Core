using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_with_core.Model;


namespace MVC_with_core.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerData()
        {
            Customers abhi = new Customers(12, "Abhishek");
            ViewBag.cust = abhi;
            string name = "Abhishek";
            List<int> data = new List<int>() { 1, 2, 3 };
            ViewData["name"] = name; // for pssing data from action to view 
            ViewData["data"] = data; // this ViewData can be used in the html file as Razor Code 
            ViewBag.data = data;
            return View("CustomerView");
        }
    }
}


/* 
 * We have two ways of using razor code In_line Razor Code -> @<code> whenever any html tag is used we have to use the '@' prefix 
 * Block type razor code @{ Lines in the code  }
 */