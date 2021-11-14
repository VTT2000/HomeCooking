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
            HttpContext.Session.SetString("IdQuanLy","111");// cai dat vao dang nhap Khi dang nhap = quyen admin
            HttpContext.Session.SetString("NameQuanLy", "111");
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("IdQuanLy")))
            {
                HttpContext.Response.Redirect("../Admin/Login");
            }

            return View();
        }
        public IActionResult nhanvien()
        {
            HttpContext.Session.SetString("IdNhanVien", "111");// cai dat vao dang nhap Khi dang nhap = quyen admin
            HttpContext.Session.SetString("NameNhanVien", "111");
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("IdQuanLy")) || String.IsNullOrEmpty(HttpContext.Session.GetString("IdNhanVien")))
            {
                HttpContext.Response.Redirect("../Admin/Login");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            
            return NotFound("ok");
        }
        [HttpPost,ActionName("Login")]
        public IActionResult ok()
        {

            return View();
        }
        public IActionResult LoOut()
        {
            HttpContext.Session.SetString("IdQuanLy", "");
            HttpContext.Session.SetString("NameQuanLy", "");
            HttpContext.Session.SetString("IdNhanVien", "");
            HttpContext.Session.SetString("NameNhanVien", "");
            
            return RedirectToAction("Login","Admin");
        }
    }
}
