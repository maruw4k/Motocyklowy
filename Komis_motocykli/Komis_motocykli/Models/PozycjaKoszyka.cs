using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komis_motocykli.Models
{
    public class PozycjaKoszyka
    {
        public Motocykl Motocykl { get; set; }
        public int Ilosc { get; set; }
        public decimal Wartosc { get; set; }
    }
}