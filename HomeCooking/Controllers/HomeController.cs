using HomeCooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeCooking0Context context = new HomeCooking0Context();

            ViewBag.a = context.ThucPhams.FirstOrDefault(p => p.IdFood == "TP000001").NameFood;

            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string pass)
        {
            // true
            HomeCooking0Context context = new HomeCooking0Context();
            KhachHang kh = context.KhachHangs.ToList().FirstOrDefault(p => p.Email == email);
            if(kh == null)
            {
                return View("Tai khoan ko ton tai");
            }
            else
            {
                if(kh.Password.CompareTo(pass) == 0)
                {
                    return View("Dang nhap thanh cong");
                }
                else
                {
                    return View("Sai mat khau");
                }
            }

            //return RedirectToAction("Index","Home");
        }
        
        [HttpPost]
        public IActionResult Register(string ten, string email, string pass)
        {
            // true
            HomeCooking0Context context = new HomeCooking0Context();
            // xet 3 thuoc tinh do roi hay kiem tra csdl
            KhachHang kh = context.KhachHangs.ToList().FirstOrDefault(p => p.Email == email);
            if(kh == null)
            {
                kh = new KhachHang();
                kh.Name = ten;
                kh.Email = email;
                kh.Password = pass;
                kh.DateCreated = DateTime.Now;

                context.KhachHangs.Add(kh);
                context.SaveChanges();

                return View("Dang ky thanh cong");
            }
            else
            {
                return View("Email da dang ky");
            }

            //return RedirectToAction("Index","Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
