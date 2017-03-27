using Komis_motocykli.DAL;
using Komis_motocykli.Models;
using Komis_motocykli.ViewModels;
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
            var kategorie = db.Kategorie.ToList();

            var nowe = db.Motocykle.Where(a => !a.Uzywany).OrderByDescending(a => a.RokProdukcji).Take(3);

            var uzywane = db.Motocykle.Where(a => a.Uzywany);

            var vm = new HomeViewModel()
            {
                Kategorie = kategorie,
               Nowe = nowe,
                Uzywane = uzywane


            };

            
            return View(vm);
        }

        public ActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }
    }
}