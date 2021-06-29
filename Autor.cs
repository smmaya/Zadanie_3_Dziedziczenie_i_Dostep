using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    public class Autor : Osoba
    {
        private string narodowosc { get; set; }

        public string Narodowosc { get => narodowosc; }

        public Autor()
        {
        }

        public Autor(string imie_, string nazwisko_, string narodowosc_)
        {
            this.imie = imie_;
            this.nazwisko = nazwisko_;
            this.narodowosc = narodowosc_;
        }
    }
}
