using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Komis_motocykli.Infrastructure
{
    public static class UrlHelpers
    {
        public static string IkonyKategoriiSciezka(this UrlHelper helper, string nazwakonyKategorii)
        {
            var ikonyKategoriFolder = AppConfig.IkonyKategoriiFolderWzgledny;
            var sciezka = Path.Combine(ikonyKategoriFolder, nazwakonyKategorii);
            var sciezkaBezwzgledna = helper.Content(sciezka);


            return sciezkaBezwzgledna;
        }

        public static string ObrazkiSciezka(this UrlHelper helper, string nazwaObrazka)
        {
            var ObrazkiFolder = AppConfig.ObrazkiFolderWzgledny;
            var sciezka = Path.Combine(ObrazkiFolder, nazwaObrazka);
            var sciezkaBezwzgledna = helper.Content(sciezka);


            return sciezkaBezwzgledna;
        }
    }
}