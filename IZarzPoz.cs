using System;
using System.Collections.Generic;

namespace Zadanie_3
{
     interface IZarzPoz
    {
        public Pozycja SzukajPoTytule(string tytul);

        public Pozycja SzukajPoID(int id);

        public void WypiszWszystkiePozycje();

    }
}
