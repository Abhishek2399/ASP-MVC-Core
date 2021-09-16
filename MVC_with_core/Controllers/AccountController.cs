using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_with_core.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Validate(string uName, string pwd)
        {
            if (uName.ToLower() == "admin")
            {
                return View("Valid");
            }
            else
            {
                return View("Invalid");
            }
        }
    }
}
