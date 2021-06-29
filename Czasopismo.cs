using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    class Czasopismo : Pozycja
    {
        private int numer { get; set; }

        public int Numer { get => numer; }

        public Czasopismo()
        {
        }

        public Czasopismo(string tytul_, string wydawnictwo_, int id_, int rokWydania_, int numer_)
        {
            this.tytul = tytul_;
            this.wydawnictwo = wydawnictwo_;
            this.id = id_;
            this.rokWydania = rokWydania_;
            this.numer = numer_;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: " + tytul + " ID: " + id + " Wydawnictwo: " + wydawnictwo + " Rok wydania: " + rokWydania + " Numer: " + numer);
        }
    }
}
