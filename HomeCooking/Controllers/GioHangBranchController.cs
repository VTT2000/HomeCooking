using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeCooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GioHangBranchController : ControllerBase
    {
        // POST api/<GioHangBranchController>
        [HttpPost]
        public void Post([FromBody] string idFood, int soLuong)
        {
            List<GioHang> listGioHang = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            for(int i = 0; i < listGioHang.Count; i++)
            {
                if(listGioHang[i].zIdFood == idFood)
                {
                    listGioHang[i].zSoLuong = soLuong;
                }
            }
            HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGioHang));
        }

        // DELETE api/<GioHangBranchController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            List<GioHang> listGioHang = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            GioHang deleted = listGioHang.FirstOrDefault(p=>p.zIdFood == id);
            listGioHang.Remove(deleted);
            HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGioHang));
        }
    }
}
