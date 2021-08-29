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
        Giai_Phuong_trinh gpt = new Giai_Phuong_trinh();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hello()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double heSoA, double heSoB)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(heSoA, heSoB);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}