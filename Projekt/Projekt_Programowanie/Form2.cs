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
using Projekt;

namespace Projekt_Programowanie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string przedmiotRodzaj;
        Bitmap bmp;
        //sprawdza który rodzaj przedmiotu wybrałeś i uniedostępnia niepotrzebne pola
        private void Form2_Load(object sender, EventArgs e)
        {
            bron.SelectedItem = bron.Items[0];
            Rzadkosc.SelectedItem = Rzadkosc.Items[0];
            if (przedmiotRodzaj == "Skin")
            {
                LiczbaUzyc.Enabled = false;
                Rodzaj.Enabled = false;
                Rodzaj.Text = "-";
            }
            else if (przedmiotRodzaj == "Grafiti")
            {
                bron.Enabled = false;
                Zuzycie.Enabled = false;
                Zuzycie.Text = "-";
                Pattern.Enabled = false;
                Pattern.Text = "-";
                Rodzaj.Enabled = false;
                Rodzaj.Text = "-";
            }
            else if (przedmiotRodzaj == "Naklejki")
            {
                bron.Enabled = false;
                Zuzycie.Enabled = false;
                Zuzycie.Text = "-";
                Pattern.Enabled = false;
                Pattern.Text = "-";
                LiczbaUzyc.Enabled = false;
            }
            else
            {
                bron.Enabled = false;
                Zuzycie.Enabled = false;
                Zuzycie.Text = "-";
                Pattern.Enabled = false;
                Pattern.Text = "-";
                LiczbaUzyc.Enabled = false;
            }
        }

        //dodawanie nowego przedmiotu do listy
        //potem zmienie to na dodawanie do bazy przedmiotów
        //poza tym otwiera pierwsze okno i zamyka to
        private void akceptuj_Click(object sender, EventArgs e)
        {
            //sprawdza czy wszystkie pola wypełnione
            bool ok = true;
            foreach (Control child in this.Controls)
            {
                TextBox textBox = child as TextBox;
                if (textBox != null)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        ok = false;
                        MessageBox.Show("Uzupełnij wszystkie dane");
                        break;
                    }
                }
            }
            if (Rzadkosc.Text == "" || Opis.Text == "" || bron.Text == ""||bmp==null)
            {
                ok = false;
                MessageBox.Show("Uzupełnij wszystkie dane");
            }
            if (ok)
            {
                //zapis do pliku
                string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
                string url = "\\\\obrazy\\\\" + Nazwa.Text + ".png";
                bmp.Save(parentDirectory + url, ImageFormat.Png);
                if (przedmiotRodzaj == "Skin")
                {
                    Skin skin = new Skin(0, url, Nazwa.Text, Rzadkosc.Text, Kolekcja.Text, Opis.Text, bron.Text, Zuzycie.Text, Convert.ToDouble(Pattern.Text));
                    skin.Zapis();
                }
                else if (przedmiotRodzaj == "Grafiti")
                {
                    Grafiti skin = new Grafiti(1, url, Nazwa.Text, Rzadkosc.Text, Kolekcja.Text, Opis.Text, Convert.ToInt32(LiczbaUzyc.Value));
                    skin.Zapis();
                }
                else if (przedmiotRodzaj == "Naklejki")
                {
                    Naklejki skin = new Naklejki(2, url, Nazwa.Text, Rzadkosc.Text, Kolekcja.Text, Opis.Text, Rodzaj.Text);
                    skin.Zapis();
                }
                else
                {
                    Żetony skin = new Żetony(3, url, Nazwa.Text, Rzadkosc.Text, Kolekcja.Text, Opis.Text, Rodzaj.Text);
                    skin.Zapis();
                }
                //wracamy do formularza 1
                Form1 Formularz = new Form1();
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

        private void rodzajPrzedmiotu_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Bitmap bmp = new Bitmap("C:\\Users\\verma\\OneDrive\\Pulpit\\plan.png");
            Obraz.Image = bmp;
            string parentDirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            bmp.Save(parentDirectory + "\\obrazy\\test1.png", ImageFormat.Png);*/
        }

        private void UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                obraz.Image = Image.FromFile(fileOpen.FileName);
                bmp = new Bitmap(obraz.Image);
            }
            fileOpen.Dispose();
        }
    }
}
