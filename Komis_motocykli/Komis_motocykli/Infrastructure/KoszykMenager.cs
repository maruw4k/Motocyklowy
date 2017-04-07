using Komis_motocykli.DAL;
using Komis_motocykli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komis_motocykli.Infrastructure
{
    public class KoszykMenager
    {
        private KomisContext db;
        ISessionMenager session;

        public KoszykMenager(ISessionMenager session, KomisContext db)
        {
            this.session = session;
            this.db = db;
        }

        public List<PozycjaKoszyka> PobierzKoszyk()
        {
            List<PozycjaKoszyka> koszyk;

            if (session.Get<List<PozycjaKoszyka>>(Consts.KoszykSessionKlucz) == null)
            {
                koszyk = new List<PozycjaKoszyka>();
            }
            else
            {
                koszyk = session.Get<List<PozycjaKoszyka>>(Consts.KoszykSessionKlucz) as List<PozycjaKoszyka>;
            }
            return koszyk;
        }

        public void DodajDoKoszyka(int motocyklId)
        {
            var koszyk = PobierzKoszyk();
            var pozycjaKoszyka = koszyk.Find(k => k.Motocykl.MotocyklId == motocyklId);

            if (pozycjaKoszyka != null)
                pozycjaKoszyka.Ilosc++;
            else
            {
                var motocyklDoDodania = db.Motocykle.Where(k => k.MotocyklId == motocyklId).SingleOrDefault();

                if (motocyklDoDodania != null)
                {
                    var nowaPozycjaKoszyka = new PozycjaKoszyka()
                    {
                        Motocykl = motocyklDoDodania,
                        Ilosc = 1,
                        Wartosc = motocyklDoDodania.CenaMotoru
                    };
                    koszyk.Add(nowaPozycjaKoszyka);


                }
            }
            session.Set(Consts.KoszykSessionKlucz, koszyk);
        }


        public int UsunZKoszyka(int motocyklId)
        {
            var koszyk = PobierzKoszyk();
            var pozycjaKoszyka = koszyk.Find(k => k.Motocykl.MotocyklId == motocyklId);

            if (pozycjaKoszyka != null)
            {
                if (pozycjaKoszyka.Ilosc > 1)
                {
                    pozycjaKoszyka.Ilosc--;
                    return pozycjaKoszyka.Ilosc;
                }
                else
                {
                    koszyk.Remove(pozycjaKoszyka);
                }
            }

            return 0;
        }


        public decimal PobierzWartoscKoszyka()
        {
            var koszyk = PobierzKoszyk();
            return koszyk.Sum(k => (k.Ilosc * k.Motocykl.CenaMotoru));
        }


        public int PobierzIloscPozycjiKoszyka()
        {
            var koszyk = PobierzKoszyk();
            int ilosc = koszyk.Sum(k => k.Ilosc);
            return ilosc;
        }


        public Zamowienie UtworzZamowienie(Zamowienie noweZamowienie, string userId)
        {
            var koszyk = PobierzKoszyk();
            noweZamowienie.DataDodania = DateTime.Now;
            noweZamowienie.userId = userId;

            db.Zamowienia.Add(noweZamowienie);

            if (noweZamowienie.PozycjeZamowienia == null)
                noweZamowienie.PozycjeZamowienia = new List<PozycjaZamowienia>();
            decimal koszykWartosc = 0;

            foreach (var koszykElement in koszyk)
            {
                var nowaPozycjaZamowienia = new PozycjaZamowienia()
                {
                    MotocyklId = koszykElement.Motocykl.MotocyklId,
                    Ilosc = koszykElement.Ilosc,
                    CenaZakupu = koszykElement.Motocykl.CenaMotoru
                };

                koszykWartosc += (koszykElement.Ilosc * koszykElement.Motocykl.CenaMotoru);
                noweZamowienie.PozycjeZamowienia.Add(nowaPozycjaZamowienia);

            }

            noweZamowienie.WartoscZamowienia = koszykWartosc;
            db.SaveChanges();

            return noweZamowienie;

            }

        public void PustyKoszyk()
        {
            session.Set<List<PozycjaKoszyka>>(Consts.KoszykSessionKlucz, null);
        }

        }

    }
