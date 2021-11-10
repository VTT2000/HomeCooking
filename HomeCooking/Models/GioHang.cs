using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Models
{
    public class GioHang
    {
        HomeCooking0Context context = new HomeCooking0Context();
        public string zIdFood { set; get; }

        public string zNameFood { set; get; }

        public string zLinkHinhAnh { set; get; }

        public Double? zDonGia { set; get; }

        public int? zSoLuong { set; get; }

        public Double? zThanhTien { get { return zSoLuong * zDonGia; } }

        public GioHang(string IdFood)
        {
            zIdFood = IdFood;
            ThucPham x = context.ThucPhams.ToList().FirstOrDefault(p => p.IdFood == zIdFood);
            if (x.IdKhuyenMai.ToString().Length == 0 || x.IdKhuyenMai == null)
            {
                zDonGia = double.Parse(x.Price.ToString());
            }
            else
            {
                zDonGia = double.Parse(x.Price.ToString()) * (100-x.IdKhuyenMaiNavigation.PhanTramKhuyenMai) / 100;
            }
            zNameFood = x.NameFood;
            zLinkHinhAnh = x.LinkHinhAnh;
            zSoLuong = 1;
        }

    }
}
