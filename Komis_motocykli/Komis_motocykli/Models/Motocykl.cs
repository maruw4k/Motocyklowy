using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komis_motocykli.Models
{
    public class Motocykl
    {
        public int MotocyklId { get; set; }
        public int KategoriaID { get; set; }
        public string NazwaMotoru { get; set; }
        public int Pojemnosc { get; set; }
        public DateTime DataDodania { get; set; }
        public DateTime RokProdukcji { get; set; }
        public string NazwaPlikuObrazka { get; set; }
        public string OpisMotoru{ get; set; }
        public decimal CenaMotoru { get; set; }
        public bool Ukryty { get; set; }


        public virtual Kategoria Kategoria { get; set; }
    }
}