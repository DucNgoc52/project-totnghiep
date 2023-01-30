using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.Controllers
{
    public class NewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: New
        public ActionResult Index()
        {
            var items = db.News.ToList();
            return View(items);
        }

        public ActionResult Partial_News_Home()
        {
            var items = db.News.Take(3).ToList();
            return PartialView(items);
        }
        public ActionResult Newdetail(int id)
        {
            var item = db.News.Find(id);
            return View(item);
        }
    }
}