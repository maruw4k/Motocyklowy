using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Komis_motocykli.Models
{
    public class Zamowienie
    {
        public int ZamowienieID { get; set; }
        [Required(ErrorMessage = "Wprowadz imie")]
        [StringLength(50)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwisko")]
        [StringLength(50)]
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Wprowadz email")]
        [StringLength(50)]
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