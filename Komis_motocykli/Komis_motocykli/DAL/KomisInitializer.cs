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
                new Kategoria() { KategoriaId=4, NazwaKategorii = "sportowy", NazwaPlikuIkony="kategoria.png", OpisKategorii="do sportu"  },
                new Kategoria() { KategoriaId=5, NazwaKategorii = "chopper", NazwaPlikuIkony="kategoria.png", OpisKategorii="na dugie trasy"  },

            };

            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var motory = new List<Motocykl>
            {
                new Motocykl() { CenaMotoru=4500, KategoriaID = 2, NazwaMotoru = "Suzuki L5", MotocyklId = 1, RokProdukcji = 1968, OpisMotoru = "szybki", Uzywany = false, NazwaPlikuObrazka="motor31.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=3200, KategoriaID = 1, NazwaMotoru = "Kawasaki Z900", MotocyklId = 2, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor1.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 1, NazwaMotoru = "Yamaha V56", MotocyklId = 3, RokProdukcji = 1998, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor2.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=32600, KategoriaID = 2, NazwaMotoru = "Romet 658", MotocyklId = 4, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = false, NazwaPlikuObrazka="motor30.jpg", OpisSkrocony = "ogfy", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=5689, KategoriaID = 1, NazwaMotoru = "Subzero LO", MotocyklId = 5, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor4.jpg", OpisSkrocony = "fdfdy", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=768, KategoriaID = 1, NazwaMotoru = "Honda XC", MotocyklId = 6, RokProdukcji = 1958, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor5.jpg", OpisSkrocony = "gf", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=768, KategoriaID = 1, NazwaMotoru = "Honda M45", MotocyklId = 11, RokProdukcji = 1958, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor5.jpg", OpisSkrocony = "gf", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 2, NazwaMotoru = "BMW ZX3", MotocyklId = 7, RokProdukcji = 1234, OpisMotoru = "szybki", Uzywany = false, NazwaPlikuObrazka="motor32.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=5400, KategoriaID = 1, NazwaMotoru = "Kawasaki Viar", MotocyklId = 8, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor7.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=8600, KategoriaID = 4, NazwaMotoru = "Yamaha 76", MotocyklId = 9, RokProdukcji = 1898, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor8.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=6400, KategoriaID = 4, NazwaMotoru = "KTM SR", MotocyklId = 10, RokProdukcji = 1986, OpisMotoru = "szybki", Uzywany = false, NazwaPlikuObrazka="motor.jpg", OpisSkrocony = "ogfy", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4100, KategoriaID = 3, NazwaMotoru = "Suzuki GTE", MotocyklId = 12, RokProdukcji = 1958, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor.jpg", OpisSkrocony = "gf", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=22400, KategoriaID = 5, NazwaMotoru = "Daelim VC", MotocyklId = 13, RokProdukcji = 1958, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor14.jpg", OpisSkrocony = "gf", Pojemnosc = 1800},
                new Motocykl() { CenaMotoru=4578, KategoriaID = 5, NazwaMotoru = "Junak M11", MotocyklId = 14, RokProdukcji = 1958, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor13.jpg", OpisSkrocony = "gf", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=123, KategoriaID = 5, NazwaMotoru = "Suzuki MI3", MotocyklId = 15, RokProdukcji = 1958, OpisMotoru = "szybki", Uzywany = false,  NazwaPlikuObrazka="motor12.jpg", OpisSkrocony = "gf", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=456, KategoriaID = 5, NazwaMotoru = "Honda VT", MotocyklId = 16, RokProdukcji = 1958, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor11.jpg", OpisSkrocony = "gf", Pojemnosc = 1300},

            };

            motory.ForEach(k => context.Motocykle.AddOrUpdate(k));
            context.SaveChanges();


            //Update-Database- targetmigration:"0" - force - verbose
            //    add-migration


        }
    }
}