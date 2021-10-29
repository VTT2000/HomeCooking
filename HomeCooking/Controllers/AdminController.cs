using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult admin()
        {
            return View();
        }
    }
}
