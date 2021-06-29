using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    class Biblioteka : IZarzPoz
    {
        public Pozycja SzukajPoTytule(string tytul)
        {
            Pozycja wynikpotytule = null;
            foreach (Katalog katalog_ in katalogi)
            {
                wynikpotytule = katalog_.SzukajPoTytule(tytul);

                if (wynikpotytule != null)
                {
                    break;
                }
            }

            if (wynikpotytule != null)
            {
                return wynikpotytule;
            }
            else
            {
                return null;
            }
        }

        public Pozycja SzukajPoID(int id)
        {
            Pozycja wynikpoID = null;
            foreach (Katalog katalog_ in katalogi)
            {
                wynikpoID = katalog_.SzukajPoID(id);

                if (wynikpoID != null)
                {
                    break;
                }
            }

            if (wynikpoID != null)
            {
                return wynikpoID;
            }
            else
            {
                return null;
            }
        }

        public void WypiszWszystkiePozycje()
        {
            foreach (Katalog katalog_ in katalogi)
            {
                katalog_.WypiszWszystkiePozycje();
            }
        }

        private string adres { get; set; }

        public string Adres { get => adres; }

        public List<Bibliotekarz> bibliotekarze = new List<Bibliotekarz>();
        public List<Katalog> katalogi = new List<Katalog>();

        public Biblioteka()
        {
        }

        public Biblioteka(string adres_)
        {
            this.adres = adres_;
        }

        public void DodajBibliotekarza(Bibliotekarz bibliotekarz_)
        {
            bibliotekarze.Add(bibliotekarz_);
        }

        public void WypiszBibliotekarzy()
        {
            foreach (Bibliotekarz bibliotekarz_ in bibliotekarze)
            {
                Console.WriteLine("Imię: " + bibliotekarz_.Imie + " Nazwisko: " + bibliotekarz_.Nazwisko + " Data zatrudnienia: " + bibliotekarz_.DataZatrudnienia + " Wyngrodzenie: " + bibliotekarz_.Wynagrodzenie);
            }
        }

        public void DodajKatalog(Katalog katalog_)
        {
            katalogi.Add(katalog_);
        }

        public void DodajPozycje(Pozycja p, string dzialTematyczny_)
        {
            foreach (Katalog wkatalogu in katalogi)
            {
                if (wkatalogu.DzialTematyczny == dzialTematyczny_)
                {
                    wkatalogu.DodajPozycje(p);
                }
            }
        }
    }
}
