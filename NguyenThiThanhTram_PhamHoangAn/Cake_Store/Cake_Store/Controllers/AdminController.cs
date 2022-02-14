using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cake_Store.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.Keys.Contains("AccountUsername"))
            {
                ViewBag.AccountUsername = HttpContext.Session.GetString("AccountUsername");
            }
            return View();
        }
    }
}
