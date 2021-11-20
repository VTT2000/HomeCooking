using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCooking.Models;

namespace HomeCooking.Controllers
{
    public class NhanVienController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("nhanvien","Admin");
        }
        public NhanVienController(IHttpContextAccessor httpContextAccessor)
        {
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdNhanVien")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }
        public IActionResult ConfirmInvoice()
        {
            string idnv = HttpContext.Session.GetString("IdNhanVien");
            string namenv = HttpContext.Session.GetString("NameNhanVien");
            HomeCooking0Context context = new HomeCooking0Context();
            List<HoaDonKhachHang> list = context.HoaDonKhachHangs.Where(p=>p.Status == "Chưa giao").ToList();

            return View(list);
        }
        public IActionResult CTInvoice(string id)
        {
            string idnv = HttpContext.Session.GetString("IdNhanVien");
            string namenv = HttpContext.Session.GetString("NameNhanVien");
            HomeCooking0Context context = new HomeCooking0Context();
            
            List<ChiTietHoaDonKhachHang> list = context.ChiTietHoaDonKhachHangs.Where(p => p.IdInvoice == id).ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.ThucPham = context.ThucPhams.ToList();

            string idkh = context.HoaDonKhachHangs.FirstOrDefault(p => p.IdInvoice == id).IdKh;
            KhachHang a = context.KhachHangs.FirstOrDefault(p=>p.IdKh == idkh);
            ViewBag.KhachHang = a;
            return View(list);
        }
        public IActionResult ConfirmedInvoice(string id)
        {
            string idnv = HttpContext.Session.GetString("IdNhanVien");
            string namenv = HttpContext.Session.GetString("NameNhanVien");
            HomeCooking0Context context = new HomeCooking0Context();

            HoaDonKhachHang a = context.HoaDonKhachHangs.FirstOrDefault(p => p.IdInvoice == id);
            a.Status = "Đã giao";
            a.IdNv = idnv;
            context.Update(a);
            context.SaveChanges();

            string idBep = context.KhoBepOnlines.FirstOrDefault(p => p.IdKh == a.IdKh).IdKhobep;
            for(int i= 0;i<context.ChiTietHoaDonKhachHangs.Where(p=>p.IdInvoice == a.IdInvoice).Count(); i++)
            {
                ChiTietKhoBep z = new ChiTietKhoBep();
                z.IdKhoBep = idBep;
                z.IdInvoice = a.IdInvoice;
                z.IdLoHang = context.ChiTietHoaDonKhachHangs.Where(p => p.IdInvoice == a.IdInvoice).ToList()[i].IdLoHang;
                z.Status = "Chưa hỏng";
                string zidfood = context.LoHangs.FirstOrDefault(p => p.IdLoHang == z.IdLoHang).IdFood;
                z.SoLuongTrongChiTietHoDonKhachHang = (context.ChiTietHoaDonKhachHangs.Where(p => p.IdInvoice == a.IdInvoice).ToList()[i].SoLuong) 
                    * (context.ThucPhams.FirstOrDefault(p=>p.IdFood == zidfood).SoLuong);

                context.ChiTietKhoBeps.Add(z);
                context.SaveChanges();
            }

            return RedirectToAction("ListConfirmedInvoice", "NhanVien");
        }
        public IActionResult ListConfirmedInvoice()
        {
            string idnv = HttpContext.Session.GetString("IdNhanVien");
            string namenv = HttpContext.Session.GetString("NameNhanVien");
            HomeCooking0Context context = new HomeCooking0Context();
            List<HoaDonKhachHang> list = context.HoaDonKhachHangs.Where(p => p.IdNv == idnv).ToList();

            return View(list);
        }
    }
}
