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
            this.Nazwa_Przedmiotu = new System.Windows.Forms.TextBox();
            this.Wyszukaj_opis = new System.Windows.Forms.Button();
            this.Obraz = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Obraz)).BeginInit();
            this.panel1.SuspendLayout();
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
            // Nazwa_Przedmiotu
            // 
            this.Nazwa_Przedmiotu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nazwa_Przedmiotu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Nazwa_Przedmiotu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nazwa_Przedmiotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nazwa_Przedmiotu.ForeColor = System.Drawing.Color.Silver;
            this.Nazwa_Przedmiotu.Location = new System.Drawing.Point(20, 358);
            this.Nazwa_Przedmiotu.Name = "Nazwa_Przedmiotu";
            this.Nazwa_Przedmiotu.ReadOnly = true;
            this.Nazwa_Przedmiotu.Size = new System.Drawing.Size(321, 24);
            this.Nazwa_Przedmiotu.TabIndex = 6;
            this.Nazwa_Przedmiotu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nazwa_Przedmiotu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.Obraz.Image = global::Projekt_Programowanie.Properties.Resources.zadanie;
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
            this.panel1.Controls.Add(this.Nazwa_Przedmiotu);
            this.panel1.Location = new System.Drawing.Point(42, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 397);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Wyszukaj;
        private System.Windows.Forms.Button Dodaj;
        public System.Windows.Forms.ComboBox Wyszukiwarka_rozwijana;
        private System.Windows.Forms.TextBox Nazwa_Przedmiotu;
        private System.Windows.Forms.Button Wyszukaj_opis;
        private System.Windows.Forms.PictureBox Obraz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

