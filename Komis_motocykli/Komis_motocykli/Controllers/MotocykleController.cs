using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Komis_motocykli.Controllers
{
    public class MotocykleController : Controller
    {
        // GET: Motocykle
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista()
        {
            return View();
        }


    }
}