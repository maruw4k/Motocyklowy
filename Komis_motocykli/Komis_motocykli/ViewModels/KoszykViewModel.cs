using Komis_motocykli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komis_motocykli.ViewModels
{
    public class KoszykViewModel
    {
        public List<PozycjaKoszyka> PozycjeKoszyka { get; set; }
        public decimal CenaCalkowita { get; set; }
    }
}