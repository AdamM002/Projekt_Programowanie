using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Projekt;

namespace Projekt_Programowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Przedmiot[] przedmioty;

        public void Form1_Load(object sender, EventArgs e)
        {
            string[] baza;
            baza = Przedmiot.Odczyt();
            przedmioty = new Przedmiot[baza.Length];
            for (int i = 0; i < baza.Length; i++)
            {
                string[] pozycje = baza[i].Split('|');
                
                if (pozycje[0] == "0") przedmioty[i]=new Skin(Convert.ToInt32(pozycje[0]), pozycje[1], pozycje[2], pozycje[3], pozycje[4], pozycje[5], pozycje[6], pozycje[7], Convert.ToDouble(pozycje[8]));
                else if (pozycje[0] == "1") przedmioty[i] = new Grafiti(Convert.ToInt32(pozycje[0]), pozycje[1], pozycje[2], pozycje[3], pozycje[4], pozycje[5], Convert.ToInt32(pozycje[9]));
                else if (pozycje[0] == "2") przedmioty[i] = new Żetony(Convert.ToInt32(pozycje[0]), pozycje[1], pozycje[2], pozycje[3], pozycje[4], pozycje[5], pozycje[10]);
                else if (pozycje[0] == "3") przedmioty[i] = new Naklejki(Convert.ToInt32(pozycje[0]), pozycje[1], pozycje[2], pozycje[3], pozycje[4], pozycje[5], pozycje[10]);
                Wyszukiwarka_rozwijana.Items.Add(przedmioty[i].ReturnNazwa());
            }
        }

        private void Wyszukaj_Click(object sender, EventArgs e)
        {
            if (Wyszukiwarka_rozwijana.Text != "")
            {
                string tekst = Wyszukiwarka_rozwijana.Text;
                int index = Wyszukiwarka_rozwijana.SelectedIndex;
                string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
                FileStream stream = new FileStream(parentDirectory + przedmioty[index].ReturnIMG(), FileMode.Open, FileAccess.Read);
                Obraz.Image = Image.FromStream(stream);
                stream.Close();
                nazwa_TextBox.Text = przedmioty[index].ReturnNazwa();
                
            }
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            Form3 okno = new Form3();
            okno.Show();
            this.Close();
        }

        private void Obraz_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        private void Wyszukaj_opis_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wyszukiwarka_rozwijana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
