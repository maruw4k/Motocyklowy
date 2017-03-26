using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Komis_motocykli.Models
{
    public class Motocykl
    {
        public int MotocyklId { get; set; }
        public int KategoriaID { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe motocyklu")]
        [StringLength(50)]
        public string NazwaMotoru { get; set; }
        public int Pojemnosc { get; set; }
        public int RokProdukcji { get; set; }
        public string NazwaPlikuObrazka { get; set; }
        public string OpisMotoru{ get; set; }
        [Required(ErrorMessage = "Wprowadz cene motocyklu")]
        public decimal CenaMotoru { get; set; }
        public bool Uzywany { get; set; }
        public string OpisSkrocony { get; set; }
  


        public virtual Kategoria Kategoria { get; set; }
    }
}