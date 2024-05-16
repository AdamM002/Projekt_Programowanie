using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekt_Programowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Wyszukaj_Click(object sender, EventArgs e)
        {
            if (Wyszukiwarka_rozwijana.Text=="Mundo")
            {
                FileStream stream = new FileStream("C:\\Users\\verma\\OneDrive\\Pulpit\\moneyman.jpg", FileMode.Open, FileAccess.Read);
                Obraz.Image = Image.FromStream(stream);
                stream.Close();
                textBox1.Text = "MoneyMan";
                
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
    }
}
