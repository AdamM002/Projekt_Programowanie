using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projekt
{

    public abstract class Przedmiot
    {
        public enum RodzajPrzedmiotu { Skin, Grafiti, naklejki, zetony}
        protected RodzajPrzedmiotu rodzajPrzedmiotu { set; get; }
        protected string img;
        protected string Nazwa { get; set; }
        public enum RzadkoscPrzedmiotu { konsumenckiej_jakości, wojskowej_jakości, przemysłowej_jakości, spoza_obiegu, klasy_poufne, klasy_tajne, standardowej_jakości, wyjątkowej_jakości, o_wybitnych_zdolnościach, naczelny, wysokiej_jakości, wyjątkowy_w_swojej_klasie, o_mistrzowskiej_wprawie, nadzwyczajnej_rzadkości, egzotycznego_pochodzenia, z_kontrabandy }
        protected RzadkoscPrzedmiotu Rzadkosc { set; get; }
        protected string Kolekcja { get; set; }
        protected string opis;


        protected Przedmiot(RodzajPrzedmiotu rodzajPrzedmiotu, string img, string nazwa, RzadkoscPrzedmiotu rzadkosc, string kolekcja, string opis)
        {
            this.rodzajPrzedmiotu = rodzajPrzedmiotu;
            this.img = img;
            Nazwa = nazwa;
            Rzadkosc = rzadkosc;
            Kolekcja = kolekcja;
            this.opis = opis;
        }

        public virtual string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|-|-|-|-|-", rodzajPrzedmiotu, img, Nazwa, Rzadkosc, Kolekcja, opis);
        }

        public static string[] Odczyt()
        {
            string[] baza = new string[500];
            int count = 0;
            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            StreamReader stream = new StreamReader(parentDirectory + "\\Zapis_danych.txt");
            string linia = stream.ReadLine();
            while (linia != null)
            {
                baza[count] = linia;
                count++;
                linia = stream.ReadLine();
            }
            string[] baza2 = new string[count];
            for (int i = 0; i < count; i++)
            {
                baza2[i] = baza[i];
            }
            stream.Close();
            return baza2;
        }

        public static void Zapis(string przedmiot)
        {
            string[] baza;
            baza = Odczyt();
            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            StreamWriter stream = new StreamWriter(parentDirectory + "\\Zapis_danych.txt");
            for (int i = 0; i < baza.Length; i++)
            {
                stream.WriteLine(baza[i]);
            }
            stream.WriteLine(przedmiot.ToString());
            stream.Close();

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
                if (value >= 0 && value <= 1000)
                {
                    pattern = value;
                }

                else if (value < 0)
                {
                    pattern = 0;
                }

                else if (value > 1000)
                {
                    pattern = 1000;
                }
            }
        }

        public Skin(RodzajPrzedmiotu rodzajPrzedmiotu, string img, string nazwa, RzadkoscPrzedmiotu rzadkosc, string kolekcja, string opis, string bron, string zuzycie, double pattern) : base(rodzajPrzedmiotu, img, nazwa, rzadkosc, kolekcja, opis)
        {
            this.bron = bron;
            this.zuzycie = zuzycie;
            Pattern = pattern;


        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|-|-", rodzajPrzedmiotu, img, Nazwa, Rzadkosc, Kolekcja, opis, bron, zuzycie, Pattern);
        }

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

        public Grafiti(RodzajPrzedmiotu rodzajPrzedmiotu, string img, string nazwa, RzadkoscPrzedmiotu rzadkosc, string kolekcja, string opis, int liczbaUzyc) : base(rodzajPrzedmiotu, img, nazwa, rzadkosc, kolekcja, opis)
        {
            LiczbaUzyc = liczbaUzyc;
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|-|-|-|{6}|-", rodzajPrzedmiotu, img, Nazwa, Rzadkosc, Kolekcja, opis, LiczbaUzyc);
        }
    }

    public class Naklejki : Przedmiot
    {
        protected string rodzaj;

        public Naklejki(RodzajPrzedmiotu rodzajPrzedmiotu, string img, string nazwa, RzadkoscPrzedmiotu rzadkosc, string kolekcja, string opis, string rodzaj) : base(rodzajPrzedmiotu, img, nazwa, rzadkosc, kolekcja, opis)
        {
            this.rodzaj = rodzaj;
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|-|-|-|-|{6}", rodzajPrzedmiotu, img, Nazwa, Rzadkosc, Kolekcja, opis, rodzaj);
        }
    }

    public class Żetony : Przedmiot
    {
        protected string rodzaj;

        public Żetony(RodzajPrzedmiotu rodzajPrzedmiotu, string img, string nazwa, RzadkoscPrzedmiotu rzadkosc, string kolekcja, string opis, string rodzaj) : base(rodzajPrzedmiotu, img, nazwa, rzadkosc, kolekcja, opis)
        {
            this.rodzaj = rodzaj;
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|-|-|-|-|{6}", rodzajPrzedmiotu, img, Nazwa, Rzadkosc, Kolekcja, opis, rodzaj);
        }

    }
}