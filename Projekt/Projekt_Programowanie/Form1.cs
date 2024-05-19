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

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Wyszukaj_Click(object sender, EventArgs e)
        {
            if (Wyszukiwarka_rozwijana.Text != "")
            {
                string tekst = Wyszukiwarka_rozwijana.Text;
                int index = Wyszukiwarka_rozwijana.SelectedIndex;
                string[] baza;
                baza = Przedmiot.Odczyt();
                string[] pozycje = baza[index].Split('|');
                string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
                FileStream stream = new FileStream(parentDirectory + pozycje[1], FileMode.Open, FileAccess.Read);
                Obraz.Image = Image.FromStream(stream);
                stream.Close();
                textBox1.Text = pozycje[2];
            }
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
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
            //test
            Bitmap bmp = new Bitmap("C:\\Users\\verma\\OneDrive\\Pulpit\\plan.png");
            Obraz.Image = bmp;
            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            bmp.Save(parentDirectory + "\\obrazy\\test1.png", ImageFormat.Png);
        }

    }
}
