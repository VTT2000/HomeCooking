using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class GioHangController : Controller
    {
        HomeCooking0Context context = new HomeCooking0Context();

        public List<GioHang> LayGioHang()
        {
            List<GioHang> listGioHang = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            if (listGioHang == null)
            {
                listGioHang = new List<GioHang>();
                HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGioHang));
            }
            return listGioHang;
        }


        public IActionResult ThemGioHang(string IdFood, string strURL)
        {
            List<GioHang> listGH = LayGioHang();

            GioHang sanPham = listGH.ToList().FirstOrDefault(p => p.zIdFood == IdFood);
            if(sanPham == null)
            {
                sanPham = new GioHang(IdFood);
                listGH.Add(sanPham);
                return Redirect(strURL);
            }
            else
            {
                sanPham.zSoLuong++;
                return Redirect(strURL);
            }
        }
        public IActionResult Index()
        {
            List<GioHang> listGH = LayGioHang();

            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();

            return View(listGH);
        }


        private int? TongSoLuong()
        {
            int? zTongSoLuong = 0;
            List<GioHang> listGH = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            if(listGH != null)
            {
                zTongSoLuong = listGH.Sum(p => p.zSoLuong);
            }
            return zTongSoLuong;
        }

        private double? TongTien()
        {
            double? zTongTien = 0;
            List<GioHang> listGH = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            if(listGH != null)
            {
                zTongTien = listGH.Sum(p => p.zThanhTien);
            }
            return zTongTien;
        }
    }
}
