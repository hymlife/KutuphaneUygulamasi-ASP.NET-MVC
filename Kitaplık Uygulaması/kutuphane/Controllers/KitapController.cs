using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kutuphane.Models;

namespace kutuphane.Controllers
{
    public class KitapController : Controller
    {
        DbHalilTestEntities db = new DbHalilTestEntities();
        // GET: Kitap
        public ActionResult Index()
        {
            var kitaplar = db.TBLKITAP.ToList();
            return View(kitaplar);
        }

        [HttpGet]
        public ActionResult KitapEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KitapEkle(TBLKITAP ktb)
        {
            
            db.TBLKITAP.Add(ktb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KitapSil(int id)
        {
            var kitap = db.TBLKITAP.Find(id);
            db.TBLKITAP.Remove(kitap);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult KitapGetir(int id)
        {
            var ktp = db.TBLKITAP.Find(id);
            return View("KitapGetir", ktp);
        }
        public ActionResult KitapGuncelle(TBLKITAP t)
        {
            var kitap = db.TBLKITAP.Find(t.KITAPID);
            kitap.AD = t.AD;
            kitap.YAZAR = t.YAZAR;
            kitap.SAYFA = t.SAYFA;
            kitap.KATEGORI = t.KATEGORI;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}