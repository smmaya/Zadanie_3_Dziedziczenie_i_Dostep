using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron { get; set; }

        public int LiczbaStron { get => liczbaStron; }

        public List<Autor> autorzy = new List<Autor>();

        public Ksiazka()
        {
        }

        public Ksiazka(string tytul_, string wydawnictwo_, int id_, int rokWydania_, int liczbaStron_)
        {
            this.tytul = tytul_;
            this.wydawnictwo = wydawnictwo_;
            this.id = id_;
            this.rokWydania = rokWydania_;
            this.liczbaStron = liczbaStron_;
        }

        public void DodajAutora(Autor K_Autor)
        {
            autorzy.Add(K_Autor);
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: " + tytul + " ID: " + id + " Wydawnictwo: " + wydawnictwo + " Rok wydania: " + rokWydania + " Liczba stron: " + liczbaStron);
        }
    }
}
