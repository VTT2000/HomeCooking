using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeCooking.Controllers
{
    public class CongThucNauAnController : Controller
    {
        public IActionResult Index()
        {
            HomeCooking0Context context = new HomeCooking0Context();

            var List = context.CongThucNauAns.ToList();

            return View(List);
        }
    }
}
