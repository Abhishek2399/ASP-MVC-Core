using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_with_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Start()
        {
            return View();         }

        public IActionResult Add()
        {
            return View("AddView");// if view name different then action method we can specify the name in View func params
            // Prefered to use the view name same as the action method name 
        }

        public IActionResult Delete()
        {
            return Content("This is Delete");
        }
        
        public IActionResult ViewAll()
        {
            return Content("This is View all");
        }
    }
}
