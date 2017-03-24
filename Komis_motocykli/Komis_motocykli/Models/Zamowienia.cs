using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komis_motocykli.Models
{
    public class Zamowienie
    {
        public int ZamowienieID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime DataDodania { get; set; }
        public StanZamowienia StanTranzakcji { get; set; }

        public enum StanZamowienia
        {
            Nowe,
            Zrealizowane
        }
    }
}