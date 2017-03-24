using System.Collections;
using System.Collections.Generic;

namespace Komis_motocykli.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string NazwaKategorii { get; set; }
        public string  OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Motocykl> Motocykle { get; set }
    }
}