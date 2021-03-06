﻿using Komis_motocykli.Models;
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
        public string userId{ get; set; }
        public virtual ApplicationUser User { get; set; }

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
        public StanZamowienia StanZamowienia { get; set; }

        public decimal WartoscZamowienia { get; set; }

        public List<PozycjaZamowienia> PozycjeZamowienia { get; set; }
    }

        public enum StanZamowienia
        {
            Nowe,
            Zrealizowane
        }
    }
