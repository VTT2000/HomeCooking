using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            HomeCooking0Context context = new HomeCooking0Context();
            string idKH = HttpContext.Session.GetString("KhachHangIdKH"); 
            string namKH = HttpContext.Session.GetString("KhachHangName");

            KhachHang a = context.KhachHangs.FirstOrDefault(p => p.IdKh == idKH);
            return View(a);
        }
        [HttpPost]
        public IActionResult Index(string nameKH, string sdtKH, string diachiKH, string emailKH, string pwKH, string repwKH)
        {
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");
            KhachHang a = new KhachHang();
            a.IdKh = idKH;
            a.Name = nameKH;
            a.Sdt = sdtKH;
            a.DiaChi = diachiKH;
            a.Email = emailKH;
            a.Password = pwKH;
            if (String.IsNullOrEmpty(a.Name))
            {
                ViewBag.Error = "Họ và tên không được để trống";
                return View(a);
            }
            if (String.IsNullOrEmpty(a.Email))
            {
                ViewBag.Error = "Email không được để trống";
                return View(a);
            }
            if(String.IsNullOrEmpty(a.Password))
            {
                ViewBag.Error = "Password không được để trống";
                return View(a);
            }
            if(pwKH != repwKH)
            {
                ViewBag.Error = "Password và xác nhận lại password không đúng";
                return View(a);
            }

            HomeCooking0Context context = new HomeCooking0Context();
            context.Update(a);
            context.SaveChanges();

            HttpContext.Session.SetString("KhachHangName",a.Name);

            ViewBag.Error = "Cập nhật thông tin thành công";
            
            return View(a);
        }
        
        public IActionResult Invoice()
        {
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");

            HomeCooking0Context context = new HomeCooking0Context();
            List<HoaDonKhachHang> list = context.HoaDonKhachHangs.Where(p => p.IdKh == idKH).ToList();

            return View(list);
        }

        [HttpGet("{id}")]
        public IActionResult DetailInvoice(string id)
        {
            // id là id hóa đơn
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");
            HomeCooking0Context context = new HomeCooking0Context();

            List<ChiTietHoaDonKhachHang> list = context.ChiTietHoaDonKhachHangs.Where(p=>p.IdInvoice == id).ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.ThucPhams = context.ThucPhams.ToList();

            return View(list);
        }
        

    }
}
