using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    abstract class Pozycja
    {
        protected string tytul { get; set; }
        protected string wydawnictwo { get; set; }
        protected int id { get; set; }
        protected int rokWydania { get; set; }

        public string Tytul { get => tytul; }
        public string Wydawnictwo { get => wydawnictwo; }
        public int ID { get => id; }
        public int RokWydania { get => rokWydania; }

        public Pozycja()
        {
        }

        public Pozycja(string tytul_, string wydawnictwo_, int id_, int rokWydania_)
        {
            this.tytul = tytul_;
            this.wydawnictwo = wydawnictwo_;
            this.id = id_;
            this.rokWydania = rokWydania_;
        }

        public abstract void WypiszInfo();
    }
}
