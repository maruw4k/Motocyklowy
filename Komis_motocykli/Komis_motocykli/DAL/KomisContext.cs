using Komis_motocykli.Models;
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

        public DbSet<Motocykl> Motocykle { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }
        public DbSet<Zamowienie> Zamowienie { get; set; }

       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // zmiana konwencji nazywania (bez koncowek s)
            // zamiast Kategorie zostałaby stworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}