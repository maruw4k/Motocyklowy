using Komis_motocykli.DAL;
using Komis_motocykli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Komis_motocykli.Controllers
{
    public class HomeController : Controller
    {

        private KomisContext db = new KomisContext();

        public ActionResult Index()
        {
            Kategoria kategoria = new Kategoria { NazwaKategorii = "Enduro", NazwaPlikuIkony="enduro.png", OpisKategorii= "rodzaj sportu motorowego polegający" };
            db.Kategorie.Add(kategoria);
            db.SaveChanges();
            return View();
        }
    }
}