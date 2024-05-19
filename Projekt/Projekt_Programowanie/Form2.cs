﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt;

namespace Projekt_Programowanie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //dodawanie nowego przedmiotu do listy
        //potem zmienie to na dodawanie do bazy przedmiotów
        //poza tym otwiera pierwsze okno i zamyka to
        private void akceptuj_Click(object sender, EventArgs e)
        {
            if (Nazwa.Text != "")
            {
                Form1 Formularz = new Form1();
                string[] baza;
                baza = Przedmiot.Odczyt();
                for (int i = 0; i < baza.Length; i++)
                {
                    string[] pozycje = baza[i].Split('|');
                    Formularz.Wyszukiwarka_rozwijana.Items.Add(pozycje[2]);
                }
                Formularz.Show();
                this.Close();
            }
        }

        //to zapewnia że aplikacja zamknie się po zamknięciu wszystkich okien
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
