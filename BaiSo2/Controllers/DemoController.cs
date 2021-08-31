using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiSo2.Models;

namespace BaiSo2.Controllers
{
    
    public class DemoController : Controller
    {
        GiaiPT gpt = new GiaiPT();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TinhTong(string soA, string soB)
        {
            int SoThuNhat = Convert.ToInt32(soA);
            int SoThuHai = Convert.ToInt32(soB);
            int TongHaiSo = gpt.TinhTong(SoThuNhat,SoThuHai);
            ViewBag.Tong = TongHaiSo;
            return View();
        }
    }
}