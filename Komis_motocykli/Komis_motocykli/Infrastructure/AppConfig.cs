using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Komis_motocykli.Infrastructure
{
    public class AppConfig
    {
        private static string _ikonyKategoriFolderWzgledny = ConfigurationManager.AppSettings["IkonyKategoriiFolder"];

        public static string IkonyKategoriiFolderWzgledny
        {
            get
            {
                return _ikonyKategoriFolderWzgledny;
            }
        }

        private static string _ObrazkiFolderWzgledny = ConfigurationManager.AppSettings["ObrazkiFolder"];

        public static string ObrazkiFolderWzgledny
        {
            get
            {
                return _ObrazkiFolderWzgledny;
            }
        } 
    }
}