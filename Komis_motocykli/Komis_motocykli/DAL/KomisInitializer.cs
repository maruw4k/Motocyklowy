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

            };

            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();

            var motory = new List<Motocykl>
            {
                new Motocykl() { CenaMotoru=4400, KategoriaID = 2, NazwaMotoru = "Suzuki", MotocyklId = 1, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = false, NazwaPlikuObrazka="motor.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 1, NazwaMotoru = "Kawasaki", MotocyklId = 2, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor1.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 1, NazwaMotoru = "Yamaha", MotocyklId = 3, RokProdukcji = 1998, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor2.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 2, NazwaMotoru = "WSK", MotocyklId = 4, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = false, NazwaPlikuObrazka="motor3.jpg", OpisSkrocony = "ogfy", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 1, NazwaMotoru = "Subzero", MotocyklId = 5, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor4.jpg", OpisSkrocony = "fdfdy", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 1, NazwaMotoru = "Honda", MotocyklId = 6, RokProdukcji = 1958, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor5.jpg", OpisSkrocony = "gf", Pojemnosc = 1300},

                new Motocykl() { CenaMotoru=4400, KategoriaID = 2, NazwaMotoru = "BMW", MotocyklId = 7, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = false, NazwaPlikuObrazka="motor6.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 1, NazwaMotoru = "Kawasaki", MotocyklId = 8, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor7.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 4, NazwaMotoru = "Yamaha", MotocyklId = 9, RokProdukcji = 1998, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor8.jpg", OpisSkrocony = "opis skrocony", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 4, NazwaMotoru = "Audi", MotocyklId = 10, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = false, NazwaPlikuObrazka="motor.jpg", OpisSkrocony = "ogfy", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 3, NazwaMotoru = "Subzero", MotocyklId = 11, RokProdukcji = 1994, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor.jpg", OpisSkrocony = "fdfdy", Pojemnosc = 1300},
                new Motocykl() { CenaMotoru=4400, KategoriaID = 3, NazwaMotoru = "Suzuki", MotocyklId = 12, RokProdukcji = 1958, OpisMotoru = "szybki", Uzywany = true,  NazwaPlikuObrazka="motor.jpg", OpisSkrocony = "gf", Pojemnosc = 1300},

            };

            motory.ForEach(k => context.Motocykle.AddOrUpdate(k));
            context.SaveChanges();


            //update - database - targetmigration:"0" - force - verbose
            //    add-migrations


        }
    }
}