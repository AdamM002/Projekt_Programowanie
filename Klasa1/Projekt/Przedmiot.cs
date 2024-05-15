using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Przedmiot
    {
        protected string nazwa;
        protected string rzadkosc;
        protected string kolekcja;
        protected string img;

        public Przedmiot (string nazwa, string rzadkosc, string kolekcja, string img) 
        {
            this.nazwa = nazwa;
            this.rzadkosc = rzadkosc;
            this.kolekcja = kolekcja;
            this.img = img;
        }
        
    }
}
