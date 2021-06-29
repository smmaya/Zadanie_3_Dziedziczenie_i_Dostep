using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    class Program
    {
        static void LosowaOdpowiedz()
        {
            Random losowa = new Random();
            int random_result = losowa.Next(1, 6);
            switch (random_result)
            {
                case 1:
                    Console.WriteLine("Niestety...");
                    break;
                case 2:
                    Console.WriteLine("Nie ma czegoś takiego.");
                    break;
                case 3:
                    Console.WriteLine("Znowu nie trafiony!");
                    break;
                case 4:
                    Console.WriteLine("Próbuj dalej.");
                    break;
                case 5:
                    Console.WriteLine("Brak danych...");
                    break;
            }
        }

        static void Testowanie(Pozycja testowanie_)
        {
            if (testowanie_ != null)
            {
                Console.WriteLine("Tytuł: " + testowanie_.Tytul + " ID: " + testowanie_.ID + " Wydawnictwo: " + testowanie_.Wydawnictwo + " Rok wydania: " + testowanie_.RokWydania);
            }
            else
            {
                LosowaOdpowiedz();
            }
        }

        static void Main(string[] args)
        {
            Biblioteka gdanska = new Biblioteka("Gdańska");

            Bibliotekarz bib1 = new Bibliotekarz("Adam", "Adamski", "20/01/1999", 2000 );
            Bibliotekarz bib2 = new Bibliotekarz("Darek", "Darski", "20/01/1960", 15000);
            gdanska.DodajBibliotekarza(bib1);
            gdanska.DodajBibliotekarza(bib2);

            Katalog kat1 = new Katalog("Poezja");
            Katalog kat2 = new Katalog("Romantyzm");
            Katalog kat3 = new Katalog("Pozytywizm");
            gdanska.DodajKatalog(kat1);
            gdanska.DodajKatalog(kat2);
            gdanska.DodajKatalog(kat3);

            Ksiazka ks1 = new Ksiazka("Pan Tadeusz", "Młoda Polska", 1, 2005, 300);
            Ksiazka ks2 = new Ksiazka("Pan Wołodyjowski", "Młoda Polska", 2, 1970, 100);
            Ksiazka ks3 = new Ksiazka("Ballady i Romanse", "Xerion", 3, 1986, 200);

            Autor au1 = new Autor("Adam", "Mickiewicz", "Litwa");
            Autor au2 = new Autor("Bolesław", "Prus", "Niemcy");

            ks1.DodajAutora(au1);
            ks3.DodajAutora(au1);
            ks2.DodajAutora(au2);

            Czasopismo czas1 = new Czasopismo("Playboy", "Hugh Heffner", 4, 1965, 34);
            Czasopismo czas2 = new Czasopismo("Modelarz", "Xerion", 5, 1985, 12);

            Pozycja poz1 = ks1;
            Pozycja poz2 = ks2;
            Pozycja poz3 = ks3;
            Pozycja poz4 = czas1;
            Pozycja poz5 = czas2;

            gdanska.DodajPozycje(poz1, "Poezja");
            gdanska.DodajPozycje(poz2, "Romantyzm");
            gdanska.DodajPozycje(poz3, "Pozytywizm");
            gdanska.DodajPozycje(poz4, "Poezja");
            gdanska.DodajPozycje(poz5, "Pozytywizm");

            //Wypisywanie elementów
            ks1.WypiszInfo();
            ks2.WypiszInfo();
            ks3.WypiszInfo();
            czas1.WypiszInfo();
            czas2.WypiszInfo();

            Console.WriteLine();

            gdanska.WypiszBibliotekarzy();
            gdanska.WypiszWszystkiePozycje();

            Console.WriteLine();

            Pozycja testowanie;
            testowanie = gdanska.SzukajPoTytule("Playboy");
            Testowanie(testowanie);
            testowanie = gdanska.SzukajPoID(1);
            Testowanie(testowanie);
            testowanie = gdanska.SzukajPoTytule("Bravo");
            Testowanie(testowanie);

            Console.WriteLine();

            kat1.WypiszWszystkiePozycje();
            kat2.WypiszWszystkiePozycje();
            kat3.WypiszWszystkiePozycje();

            Console.WriteLine();

            testowanie = kat1.SzukajPoTytule("Pan Tadeusz");
            Testowanie(testowanie);
            testowanie = kat1.SzukajPoID(5);
            Testowanie(testowanie);

            Console.WriteLine();

            testowanie = kat2.SzukajPoTytule("Pan Tadeusz");
            Testowanie(testowanie);
            testowanie = kat2.SzukajPoID(2);
            Testowanie(testowanie);

            Console.WriteLine();

            testowanie = kat3.SzukajPoTytule("Ballady i Romanse");
            Testowanie(testowanie);
            testowanie = kat3.SzukajPoID(5);
            Testowanie(testowanie);

            Console.WriteLine();

            Console.WriteLine("Jakiego tytułu szukasz?");
            testowanie = gdanska.SzukajPoTytule(Console.ReadLine());
            Testowanie(testowanie);
        }
    }
}
