using System;
using System.Collections.Generic;

namespace Zadanie_3
{
     class Katalog : IZarzPoz
    {
        public Pozycja SzukajPoTytule(string tytul)
        {
            Pozycja wynikpotytule = null;
            foreach (Pozycja pozycja in pozycje)
            {
                if (pozycja.Tytul == tytul)
                {
                    wynikpotytule = pozycja;
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
            foreach (Pozycja pozycja in pozycje)
            {
                if (pozycja.ID == id)
                {
                    wynikpoID = pozycja;
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
            foreach (Pozycja pozycja in pozycje)
            {
                Console.WriteLine("Tytuł: " + pozycja.Tytul + " ID: " + pozycja.ID + " Wydawnictwo: " + pozycja.Wydawnictwo + " Rok wydania: " + pozycja.RokWydania);
            }
        }

        public string dzialTematyczny { get; set; }

        public string DzialTematyczny { get => dzialTematyczny; }

        public List<Pozycja> pozycje = new List<Pozycja>();

        public Katalog()
        {
        }

        public Katalog(string dzialTematyczny_)
        {
            this.dzialTematyczny = dzialTematyczny_;
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            pozycje.Add(pozycja);
        }

    }
}
