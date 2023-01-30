using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,Employee")]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Home
        public ActionResult Index()
        {
            ViewBag.doanhthu = Thongkedoanhthu();
            ViewBag.dh = Donhang();
            ViewBag.sp = SoluongSP();
            return View();
        }

        public ActionResult Refresh1()
        {
            var item = new ThongKeModel();
            ViewBag.Visitors_online = HttpContext.Application["visitors_online"];
            item.HomNay = HttpContext.Application["HomNay"].ToString();
            item.HomQua = HttpContext.Application["HomQua"].ToString();
            item.TuanNay = HttpContext.Application["TuanNay"].ToString();
            item.TuanTruoc = HttpContext.Application["TuanTruoc"].ToString();
            item.ThangNay = HttpContext.Application["ThangNay"].ToString();
            item.ThangTruoc = HttpContext.Application["ThangTruoc"].ToString();
            item.TatCa = HttpContext.Application["TatCa"].ToString();
            return PartialView(item);
        }
        public decimal Thongkedoanhthu()
        {
            decimal doanhthu = db.Orders.Sum(x => x.TotalAmount);
            return doanhthu;
        }
        public double Donhang()
        {
            double dh = db.Orders.Count();
            return dh;
        }
        public double SoluongSP()
        {
            double sp = db.Products.Count();
            return sp;
        }
    }
}