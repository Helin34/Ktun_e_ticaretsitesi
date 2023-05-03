using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_TicaretSitesi.Models.Siniflar;


namespace E_TicaretSitesi.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();

        public ActionResult Index()
        {
            var urunler = c.Urunlers.ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urunler p)
        {
            c.Urunlers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}