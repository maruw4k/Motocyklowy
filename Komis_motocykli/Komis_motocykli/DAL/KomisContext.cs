using Komis_motocykli.Models;
using PraktyczneKursy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Komis_motocykli.DAL
{
    public class KomisContext : DbContext
    {
        public KomisContext() : base("KomisContext")
        {
             
        }

        static KomisContext()
        {
            Database.SetInitializer<KomisContext>(new KomisInitializer());
        }

       
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Motocykl> Motocykle { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // zmiana konwencji nazywania (bez koncowek s)
            // zamiast Kategorie zostałaby stworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}