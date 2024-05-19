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
        //metoda pobierania z pliku
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
        //metoda zapisu do pliku
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
            stream.WriteLine(przedmiot);
            stream.Close();

        }
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
            baza = Odczyt();
            for (int i = 0; i < baza.Length; i++)
            {
                myForm.Wyszukiwarka_rozwijana.Items.Add(baza[i]);
            }
            myForm.Show();
            Application.Run();

        }
    }
}
