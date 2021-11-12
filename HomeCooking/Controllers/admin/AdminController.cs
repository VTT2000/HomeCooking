using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
            
            //if (true)
            //{
            //    Response.Redirect("/Home/Index");
            //}
        }

        public IActionResult admin()
        {
            
            return View();
        }

        

    }
}
