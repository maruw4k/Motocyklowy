using Komis_motocykli.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Komis_motocykli.Controllers
{


    public class MotocykleController : Controller
    {

        private KomisContext db = new KomisContext();

        // GET: Motocykle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista(string nazwaKategori)
        {
            var kategoria = db.Kategorie.Include("Motocykle").Where(k => k.NazwaKategorii.ToUpper() == nazwaKategori.ToUpper()).Single();
            var motocykle = kategoria.Motocykle.ToList();
            return View(motocykle);
        }

        public ActionResult Szczegoly(string id)
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult KategorieMenu()
        {
            var kategorie = db.Kategorie.ToList();
            return PartialView("_KategorieMenu", kategorie);
        }



    }
}