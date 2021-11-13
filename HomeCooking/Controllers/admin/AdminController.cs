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
        
        public IActionResult admin()
        {
            HttpContext.Session.SetString("IdQuanLy","");// cai dat vao dang nhap Khi dang nhap = quyen admin

            if (String.IsNullOrEmpty(HttpContext.Session.GetString("IdQuanLy")))
            {
                HttpContext.Response.Redirect("../Admin/Login");
            }

            return View();
        }
        public IActionResult Login()
        {
            
            return NotFound("ok");
        }


    }
}
