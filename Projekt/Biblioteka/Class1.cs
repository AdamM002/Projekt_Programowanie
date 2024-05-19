using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projekt
{

    public abstract class Przedmiot
    {
        protected string img;
        protected string Nazwa { get; set; }
        protected string Rzadkosc { get; set; }
        protected string Kolekcja { get; set; }
        protected string opis;


        protected Przedmiot(string img, string nazwa, string rzadkosc, string kolekcja, string opis)
        {
            this.img = img;
            Nazwa = nazwa;
            Rzadkosc = rzadkosc;
            Kolekcja = kolekcja;
            this.opis = opis;
        }




    }

    public class Skin : Przedmiot
    {
        protected string bron;
        protected string zuzycie;
        private double pattern;

        public double Pattern
        {
            get { return pattern; }
            set
            {
                if (value >= 0 && value <= 1)
                {
                    pattern = value;
                }

                else if (value < 0)
                {
                    pattern = 0;
                }

                else if (value > 1)
                {
                    pattern = 1;
                }
            }
        }

        public Skin(string img, string nazwa, string rzadkosc, string kolekcja, string opis, string bron, string zuzycie, double pattern) : base(img, nazwa, rzadkosc, kolekcja, opis)
        {
            this.bron = bron;
            this.zuzycie = zuzycie;
            Pattern = pattern;


        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", img, Nazwa, Rzadkosc, Kolekcja, bron, zuzycie, Pattern);
        }


    }

    public class Grafiti : Przedmiot
    {

        private int liczbaUzyc;
        public int LiczbaUzyc
        {
            get { return liczbaUzyc; }
            set
            {

                if (value >= 0 && value <= 50)
                {
                    liczbaUzyc = value;
                }

                else if (value > 50)
                {
                    liczbaUzyc = 50;
                }

                else if (value < 0)
                {
                    liczbaUzyc = 0;
                }

            }
        }

        public Grafiti(string img, string nazwa, string rzadkosc, string kolekcja, string opis, int liczbaUzyc) : base(img, nazwa, rzadkosc, kolekcja, opis)
        {
            LiczbaUzyc = liczbaUzyc;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", img, Nazwa, Rzadkosc, Kolekcja, LiczbaUzyc);
        }
    }

    public class Naklejki : Przedmiot
    {
        protected string rodzaj;

        public Naklejki(string img, string nazwa, string rzadkosc, string kolekcja, string opis, string rodzaj) : base(img, nazwa, rzadkosc, kolekcja, opis)
        {
            this.rodzaj = rodzaj;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", img, Nazwa, Rzadkosc, Kolekcja, rodzaj);
        }
    }

    public class Żetony : Przedmiot
    {
        protected string rodzaj;

        public Żetony(string img, string nazwa, string rzadkosc, string kolekcja, string opis, string rodzaj) : base(img, nazwa, rzadkosc, kolekcja, opis)
        {
            this.rodzaj = rodzaj;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", img, Nazwa, Rzadkosc, Kolekcja, rodzaj);
        }

    }
}