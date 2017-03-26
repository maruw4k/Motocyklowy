using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Komis_motocykli.Models;
using Komis_motocykli.Migrations;
using System.Data.Entity.Migrations;

namespace Komis_motocykli.DAL
{
    public class KomisInitializer : MigrateDatabaseToLatestVersion<KomisContext, Configuration>
    {
        

        public static void SeedKomisData(KomisContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria() { KategoriaId=1, NazwaKategorii = "wyścigowy", NazwaPlikuIkony="kategoria.png", OpisKategorii="do wyścigów"  },
                new Kategoria() { KategoriaId=2, NazwaKategorii = "cross", NazwaPlikuIkony="kategoria.png", OpisKategorii="do lasu"  },
                new Kategoria() { KategoriaId=3, NazwaKategorii = "turystyczny", NazwaPlikuIkony="kategoria.png", OpisKategorii="do turystyki"  },

            };

            kategorie.ForEach(k => context.Kategoria.AddOrUpdate(k));
            context.SaveChanges();

            

          

        }
    }
}