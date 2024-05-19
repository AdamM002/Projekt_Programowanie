using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt;

namespace Projekt_Programowanie
{
    public static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var myForm = new Form1();
            string[] baza;
            baza = Przedmiot.Odczyt();
            for (int i = 0; i < baza.Length; i++)
            {
                string[] pozycje = baza[i].Split('|');
                myForm.Wyszukiwarka_rozwijana.Items.Add(pozycje[2]);
            }
            myForm.Show();
            Application.Run();

        }
    }
}
