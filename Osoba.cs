using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    public class Osoba
    {
        protected string imie { get; set; }
        protected string nazwisko { get; set; }

        public string Imie { get => imie; }
        public string Nazwisko { get => nazwisko; }

        public Osoba()
        {
        }

        public Osoba(string imie_, string nazwisko_)
        {
            this.imie = imie_;
            this.nazwisko = nazwisko_;
        }
    }
}
