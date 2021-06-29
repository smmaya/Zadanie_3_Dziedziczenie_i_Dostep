using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    public class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia { get; set; }
        private double wynagrodzenie { get; set; }

        public string DataZatrudnienia { get => dataZatrudnienia; }
        public double Wynagrodzenie { get => wynagrodzenie; }

        public Bibliotekarz()
        {
        }

        public Bibliotekarz(string imie_, string nazwisko_, string datazatrudnienia_, double wynagrodzenie_)
        {
            this.imie = imie_;
            this.nazwisko = nazwisko_;
            this.dataZatrudnienia = datazatrudnienia_;
            this.wynagrodzenie = wynagrodzenie_;
        }
    }
}
