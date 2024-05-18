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
            this.label1 = new System.Windows.Forms.Label();
            this.Wyszukaj = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Obraz = new System.Windows.Forms.PictureBox();
            this.Wyszukiwarka_rozwijana = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Wyszukaj_opis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Obraz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wyszukaj:";
            // 
            // Wyszukaj
            // 
            this.Wyszukaj.Location = new System.Drawing.Point(142, 56);
            this.Wyszukaj.Name = "Wyszukaj";
            this.Wyszukaj.Size = new System.Drawing.Size(75, 23);
            this.Wyszukaj.TabIndex = 3;
            this.Wyszukaj.Text = "Wyszukaj";
            this.Wyszukaj.UseVisualStyleBackColor = true;
            this.Wyszukaj.Click += new System.EventHandler(this.Wyszukaj_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(201, 84);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 4;
            this.Dodaj.Text = "Dodaj Nowy";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Obraz
            // 
            this.Obraz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Obraz.ErrorImage = global::Projekt_Programowanie.Properties.Resources.zadanie;
            this.Obraz.Image = global::Projekt_Programowanie.Properties.Resources.zadanie;
            this.Obraz.InitialImage = global::Projekt_Programowanie.Properties.Resources.moneyman;
            this.Obraz.Location = new System.Drawing.Point(427, 29);
            this.Obraz.Name = "Obraz";
            this.Obraz.Size = new System.Drawing.Size(321, 204);
            this.Obraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Obraz.TabIndex = 2;
            this.Obraz.TabStop = false;
            this.Obraz.Click += new System.EventHandler(this.Obraz_Click);
            // 
            // Wyszukiwarka_rozwijana
            // 
            this.Wyszukiwarka_rozwijana.FormattingEnabled = true;
            this.Wyszukiwarka_rozwijana.Items.AddRange(new object[] {
            "Test",
            "Mundo",
            "Meh"});
            this.Wyszukiwarka_rozwijana.Location = new System.Drawing.Point(101, 29);
            this.Wyszukiwarka_rozwijana.Name = "Wyszukiwarka_rozwijana";
            this.Wyszukiwarka_rozwijana.Size = new System.Drawing.Size(275, 21);
            this.Wyszukiwarka_rozwijana.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(321, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Wyszukaj_opis
            // 
            this.Wyszukaj_opis.Location = new System.Drawing.Point(256, 56);
            this.Wyszukaj_opis.Name = "Wyszukaj_opis";
            this.Wyszukaj_opis.Size = new System.Drawing.Size(75, 23);
            this.Wyszukaj_opis.TabIndex = 7;
            this.Wyszukaj_opis.Text = "Opis";
            this.Wyszukaj_opis.UseVisualStyleBackColor = true;
            this.Wyszukaj_opis.Click += new System.EventHandler(this.Wyszukaj_opis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Wyszukaj_opis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Wyszukiwarka_rozwijana);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Wyszukaj);
            this.Controls.Add(this.Obraz);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Obraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Obraz;
        private System.Windows.Forms.Button Wyszukaj;
        private System.Windows.Forms.Button Dodaj;
        public System.Windows.Forms.ComboBox Wyszukiwarka_rozwijana;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Wyszukaj_opis;
    }
}

