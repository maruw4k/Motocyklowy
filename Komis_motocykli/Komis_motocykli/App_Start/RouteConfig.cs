using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Komis_motocykli
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            routes.MapRoute(
                name: "MotocykleList",
                url: "Kategoria/{nazwaKategori}.html",
                defaults: new { controller = "Motocykle", action = "Lista" }
                );


            routes.MapRoute(
                name: "Szczegoly",
                url: "Szczegoly/{id}.html",
                defaults: new { controller = "Motocykle", action = "Szczegoly" }
                );


            routes.MapRoute(
                name: "StronyStatyczne",
                url: "strony/{nazwa}.html",
                defaults: new { controller = "Home", action = "StronyStatyczne" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
