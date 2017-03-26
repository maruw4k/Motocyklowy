using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Komis_motocykli.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kategorii")]
        public string NazwaKategorii { get; set; }
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
        [StringLength(200)]
        public string  OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Motocykl> Motocykle { get; set; }
    }
}