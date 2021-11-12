using HomeCooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

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
            if(HttpContext.Request.Cookies["KhachHangIdKH"] != null && HttpContext.Request.Cookies["KhachHangName"] != null)
            {
                HttpContext.Session.SetString("KhachHangName", HttpContext.Request.Cookies["KhachHangIdKH"].ToString());
                HttpContext.Session.SetString("KhachHangIdKH", HttpContext.Request.Cookies["KhachHangName"].ToString());
                
            }
            
            HomeCooking0Context context = new HomeCooking0Context();

            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.KhuyenMais = context.KhuyenMais.ToList();
            var list = context.ThucPhams.ToList().Take(6);
            
            return View(list);
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
