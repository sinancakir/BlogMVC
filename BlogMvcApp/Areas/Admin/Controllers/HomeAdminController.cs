using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogMvcApp.Models;


namespace BlogMvcApp.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        private BlogContext db = new BlogContext();

        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login");
            }

            //var bloglar = db.Bloglar.Include(b => b.Category);
            var bloglar = db.Bloglar.OrderByDescending(i => i.EklenmeTarihi);
            return View(bloglar.ToList());
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string kullaniciAdi, string sifre)
        {
            if(kullaniciAdi=="sinan" && sifre=="12345")
            {
                Session["user"] = kullaniciAdi;
                return RedirectToAction("Index");
            }
            else
            {
                Session["user"] = null;
                return View();
            }           
        }
    }
}