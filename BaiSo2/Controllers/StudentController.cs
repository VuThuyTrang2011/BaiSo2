using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiSo2.Models
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();

          }
        public ActionResult GetInfo()
        {
            return View();
        }
         [HttpPost]
        public ActionResult GetInfo(string HoTenSV, string Tuoi, string Lop)
        {
            ViewBag.HoTenSV = HoTenSV;
            ViewBag.Tuoi = Tuoi;
            ViewBag.Lop = Lop;
            return View();
        }
    }
}