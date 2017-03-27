using Komis_motocykli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komis_motocykli.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Kategoria> Kategorie { get; set; }
        public IEnumerable<Motocykl> Nowe { get; set; }
        public IEnumerable<Motocykl> Uzywane { get; set; }
    }
}