namespace Projekt_Programowanie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Wyszukaj = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Wyszukiwarka_rozwijana = new System.Windows.Forms.ComboBox();
            this.nazwa_TextBox = new System.Windows.Forms.TextBox();
            this.Wyszukaj_opis = new System.Windows.Forms.Button();
            this.Obraz = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.opis_TextBox = new System.Windows.Forms.TextBox();
            this.rodzaj_TextBox = new System.Windows.Forms.TextBox();
            this.uzycia_TextBox = new System.Windows.Forms.TextBox();
            this.pattern_TextBox = new System.Windows.Forms.TextBox();
            this.zuzycie_TextBox = new System.Windows.Forms.TextBox();
            this.bron_TextBox = new System.Windows.Forms.TextBox();
            this.rzadkość_TextBox = new System.Windows.Forms.TextBox();
            this.kolekcja_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Obraz)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wyszukaj
            // 
            this.Wyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wyszukaj.Location = new System.Drawing.Point(478, 30);
            this.Wyszukaj.Name = "Wyszukaj";
            this.Wyszukaj.Size = new System.Drawing.Size(90, 32);
            this.Wyszukaj.TabIndex = 3;
            this.Wyszukaj.Text = "Wyszukaj";
            this.Wyszukaj.UseVisualStyleBackColor = true;
            this.Wyszukaj.Click += new System.EventHandler(this.Wyszukaj_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodaj.Location = new System.Drawing.Point(574, 30);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(86, 32);
            this.Dodaj.TabIndex = 4;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Wyszukiwarka_rozwijana
            // 
            this.Wyszukiwarka_rozwijana.BackColor = System.Drawing.Color.White;
            this.Wyszukiwarka_rozwijana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Wyszukiwarka_rozwijana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wyszukiwarka_rozwijana.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Wyszukiwarka_rozwijana.FormattingEnabled = true;
            this.Wyszukiwarka_rozwijana.Location = new System.Drawing.Point(151, 30);
            this.Wyszukiwarka_rozwijana.Name = "Wyszukiwarka_rozwijana";
            this.Wyszukiwarka_rozwijana.Size = new System.Drawing.Size(321, 33);
            this.Wyszukiwarka_rozwijana.TabIndex = 5;
            this.Wyszukiwarka_rozwijana.SelectedIndexChanged += new System.EventHandler(this.Wyszukiwarka_rozwijana_SelectedIndexChanged);
            // 
            // nazwa_TextBox
            // 
            this.nazwa_TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nazwa_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.nazwa_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazwa_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazwa_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.nazwa_TextBox.Location = new System.Drawing.Point(20, 360);
            this.nazwa_TextBox.Name = "nazwa_TextBox";
            this.nazwa_TextBox.ReadOnly = true;
            this.nazwa_TextBox.Size = new System.Drawing.Size(321, 24);
            this.nazwa_TextBox.TabIndex = 6;
            this.nazwa_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nazwa_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Wyszukaj_opis
            // 
            this.Wyszukaj_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wyszukaj_opis.Location = new System.Drawing.Point(666, 30);
            this.Wyszukaj_opis.Name = "Wyszukaj_opis";
            this.Wyszukaj_opis.Size = new System.Drawing.Size(88, 32);
            this.Wyszukaj_opis.TabIndex = 7;
            this.Wyszukaj_opis.Text = "Opis";
            this.Wyszukaj_opis.UseVisualStyleBackColor = true;
            this.Wyszukaj_opis.Click += new System.EventHandler(this.Wyszukaj_opis_Click);
            // 
            // Obraz
            // 
            this.Obraz.BackColor = System.Drawing.SystemColors.Control;
            this.Obraz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Obraz.ErrorImage = global::Projekt_Programowanie.Properties.Resources.zadanie;
            this.Obraz.InitialImage = global::Projekt_Programowanie.Properties.Resources.moneyman;
            this.Obraz.Location = new System.Drawing.Point(20, 18);
            this.Obraz.Name = "Obraz";
            this.Obraz.Size = new System.Drawing.Size(321, 334);
            this.Obraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Obraz.TabIndex = 2;
            this.Obraz.TabStop = false;
            this.Obraz.Click += new System.EventHandler(this.Obraz_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Obraz);
            this.panel1.Controls.Add(this.nazwa_TextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(42, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 401);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(358, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.opis_TextBox);
            this.panel2.Controls.Add(this.rodzaj_TextBox);
            this.panel2.Controls.Add(this.uzycia_TextBox);
            this.panel2.Controls.Add(this.pattern_TextBox);
            this.panel2.Controls.Add(this.zuzycie_TextBox);
            this.panel2.Controls.Add(this.bron_TextBox);
            this.panel2.Controls.Add(this.rzadkość_TextBox);
            this.panel2.Controls.Add(this.kolekcja_TextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(347, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 364);
            this.panel2.TabIndex = 16;
            // 
            // opis_TextBox
            // 
            this.opis_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.opis_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.opis_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opis_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.opis_TextBox.Location = new System.Drawing.Point(65, 234);
            this.opis_TextBox.Multiline = true;
            this.opis_TextBox.Name = "opis_TextBox";
            this.opis_TextBox.ReadOnly = true;
            this.opis_TextBox.Size = new System.Drawing.Size(373, 116);
            this.opis_TextBox.TabIndex = 23;
            // 
            // rodzaj_TextBox
            // 
            this.rodzaj_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.rodzaj_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rodzaj_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rodzaj_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.rodzaj_TextBox.Location = new System.Drawing.Point(84, 202);
            this.rodzaj_TextBox.Name = "rodzaj_TextBox";
            this.rodzaj_TextBox.ReadOnly = true;
            this.rodzaj_TextBox.Size = new System.Drawing.Size(354, 19);
            this.rodzaj_TextBox.TabIndex = 22;
            // 
            // uzycia_TextBox
            // 
            this.uzycia_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.uzycia_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uzycia_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uzycia_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.uzycia_TextBox.Location = new System.Drawing.Point(124, 170);
            this.uzycia_TextBox.Name = "uzycia_TextBox";
            this.uzycia_TextBox.ReadOnly = true;
            this.uzycia_TextBox.Size = new System.Drawing.Size(314, 19);
            this.uzycia_TextBox.TabIndex = 21;
            // 
            // pattern_TextBox
            // 
            this.pattern_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pattern_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pattern_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pattern_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.pattern_TextBox.Location = new System.Drawing.Point(89, 138);
            this.pattern_TextBox.Name = "pattern_TextBox";
            this.pattern_TextBox.ReadOnly = true;
            this.pattern_TextBox.Size = new System.Drawing.Size(349, 19);
            this.pattern_TextBox.TabIndex = 20;
            // 
            // zuzycie_TextBox
            // 
            this.zuzycie_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.zuzycie_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zuzycie_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zuzycie_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.zuzycie_TextBox.Location = new System.Drawing.Point(89, 106);
            this.zuzycie_TextBox.Name = "zuzycie_TextBox";
            this.zuzycie_TextBox.ReadOnly = true;
            this.zuzycie_TextBox.Size = new System.Drawing.Size(349, 19);
            this.zuzycie_TextBox.TabIndex = 19;
            // 
            // bron_TextBox
            // 
            this.bron_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.bron_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bron_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bron_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.bron_TextBox.Location = new System.Drawing.Point(67, 74);
            this.bron_TextBox.Name = "bron_TextBox";
            this.bron_TextBox.ReadOnly = true;
            this.bron_TextBox.Size = new System.Drawing.Size(371, 19);
            this.bron_TextBox.TabIndex = 18;
            // 
            // rzadkość_TextBox
            // 
            this.rzadkość_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.rzadkość_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rzadkość_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rzadkość_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.rzadkość_TextBox.Location = new System.Drawing.Point(108, 42);
            this.rzadkość_TextBox.Name = "rzadkość_TextBox";
            this.rzadkość_TextBox.ReadOnly = true;
            this.rzadkość_TextBox.Size = new System.Drawing.Size(330, 19);
            this.rzadkość_TextBox.TabIndex = 17;
            // 
            // kolekcja_TextBox
            // 
            this.kolekcja_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.kolekcja_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kolekcja_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolekcja_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.kolekcja_TextBox.Location = new System.Drawing.Point(98, 10);
            this.kolekcja_TextBox.Name = "kolekcja_TextBox";
            this.kolekcja_TextBox.ReadOnly = true;
            this.kolekcja_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kolekcja_TextBox.Size = new System.Drawing.Size(340, 19);
            this.kolekcja_TextBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(12, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rodzaj: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(12, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Liczba Użyć: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Opis: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(12, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pattern: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Zużycie: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Broń: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rzadkość: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kolekcja: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(901, 528);
            this.Controls.Add(this.Wyszukaj_opis);
            this.Controls.Add(this.Wyszukiwarka_rozwijana);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Wyszukaj);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(917, 567);
            this.MinimumSize = new System.Drawing.Size(917, 567);
            this.Name = "Form1";
            this.Text = "CS2 Items";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Obraz)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Wyszukaj;
        private System.Windows.Forms.Button Dodaj;
        public System.Windows.Forms.ComboBox Wyszukiwarka_rozwijana;
        private System.Windows.Forms.TextBox nazwa_TextBox;
        private System.Windows.Forms.Button Wyszukaj_opis;
        private System.Windows.Forms.PictureBox Obraz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rodzaj_TextBox;
        private System.Windows.Forms.TextBox uzycia_TextBox;
        private System.Windows.Forms.TextBox pattern_TextBox;
        private System.Windows.Forms.TextBox zuzycie_TextBox;
        private System.Windows.Forms.TextBox bron_TextBox;
        private System.Windows.Forms.TextBox rzadkość_TextBox;
        private System.Windows.Forms.TextBox kolekcja_TextBox;
        private System.Windows.Forms.TextBox opis_TextBox;
    }
}

