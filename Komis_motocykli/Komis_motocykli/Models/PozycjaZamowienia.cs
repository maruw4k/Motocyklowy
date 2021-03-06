﻿using Komis_motocykli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komis_motocykli.Models
{
    public class PozycjaZamowienia
    {
        public int PozycjaZamowieniaId { get; set; }
        public int ZamowienieID { get; set; }
        public int MotocyklId { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupu { get; set; }

        public virtual Motocykl motocykl { get; set; }
        public virtual Zamowienie zamowienie { get; set; }
    }
}