using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using HomeCooking.Models;

namespace HomeCooking.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class apiThucPhamController : ControllerBase
    {
        IEnumerable<string> _presidents = new List<string> {
            "Biden", "Trump", "Bush", "Clinton"
        };
        [HttpGet]
        public IEnumerable<string> Index()
        {
            return _presidents;
        }


        [HttpGet]
        public string get(string IdFood)
        {
            if(IdFood == null)
            {
                return "";
            }
            else
            {
                HomeCooking0Context context = new HomeCooking0Context();
                ThucPham TP = context.ThucPhams.ToList().FirstOrDefault(p=>p.IdFood == IdFood);
                string respone = JsonConvert.SerializeObject(TP);
                return respone;
            }
            
        }
        
        [HttpGet]
        public string getList()
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<ThucPham> listTP = context.ThucPhams.ToList();
            string respone = JsonConvert.SerializeObject(listTP);
            return respone;
        }

        [HttpGet]
        public string getListpage(int page, int sltt)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<ThucPham> listTP = context.ThucPhams.ToList();
            
            if (sltt == null || sltt <= 0)
            {
                sltt = 3;
            }

            if (page == null||page <=0)
            {
                page = 1;
            }
            int index = (page * sltt - sltt);
            
            if (index >= listTP.Count)
            {
                return "";
            }

            if((index+sltt) >= listTP.Count)
            {
                sltt = sltt - ((index + sltt) - listTP.Count + 1);
            }

            List<ThucPham> listKQ = listTP.GetRange(index,sltt);
            
            string respone = JsonConvert.SerializeObject(listKQ);
            return respone;
        }

    }
}

