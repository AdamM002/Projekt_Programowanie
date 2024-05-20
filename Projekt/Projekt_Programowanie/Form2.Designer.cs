namespace Projekt_Programowanie
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nazwa = new System.Windows.Forms.TextBox();
            this.akceptuj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UploadImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Kolekcja = new System.Windows.Forms.TextBox();
            this.Opis = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LiczbaUzyc = new System.Windows.Forms.NumericUpDown();
            this.Pattern = new System.Windows.Forms.TextBox();
            this.Zuzycie = new System.Windows.Forms.TextBox();
            this.Rodzaj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LiczbaUzyc)).BeginInit();
            this.SuspendLayout();
            // 
            // Nazwa
            // 
            this.Nazwa.Location = new System.Drawing.Point(109, 45);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(350, 20);
            this.Nazwa.TabIndex = 0;
            // 
            // akceptuj
            // 
            this.akceptuj.Location = new System.Drawing.Point(232, 416);
            this.akceptuj.Name = "akceptuj";
            this.akceptuj.Size = new System.Drawing.Size(75, 23);
            this.akceptuj.TabIndex = 1;
            this.akceptuj.Text = "button1";
            this.akceptuj.UseVisualStyleBackColor = true;
            this.akceptuj.Click += new System.EventHandler(this.akceptuj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa Przedmiotu";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "konsumenckiej jakości",
            "wojskowej jakości",
            "przemysłowej jakości",
            "spoza obiegu",
            "klasy poufne",
            "klasy tajne",
            "standardowej jakości",
            "wyjątkowej jakości",
            "o wybitnych zdolnościach",
            "naczelny",
            "wysokiej jakości",
            "wyjątkowy w swojej klasie",
            "o mistrzowskiej wprawie",
            "nadzwyczajnej rzadkości",
            "egzotycznego pochodzenia",
            "z kontrabandy"});
            this.comboBox1.Location = new System.Drawing.Point(109, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rzadkość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dodaj obraz";
            // 
            // UploadImage
            // 
            this.UploadImage.Location = new System.Drawing.Point(109, 4);
            this.UploadImage.Name = "UploadImage";
            this.UploadImage.Size = new System.Drawing.Size(350, 23);
            this.UploadImage.TabIndex = 8;
            this.UploadImage.Text = "Upload";
            this.UploadImage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kolekcja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Opis";
            // 
            // Kolekcja
            // 
            this.Kolekcja.Location = new System.Drawing.Point(109, 118);
            this.Kolekcja.Name = "Kolekcja";
            this.Kolekcja.Size = new System.Drawing.Size(350, 20);
            this.Kolekcja.TabIndex = 11;
            // 
            // Opis
            // 
            this.Opis.Location = new System.Drawing.Point(109, 149);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(350, 100);
            this.Opis.TabIndex = 13;
            this.Opis.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Broń";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "228 compact",
            "Ak-47",
            "Aug",
            "AWP",
            "Desert Eagle",
            "Dual Berettas",
            "FAMAS",
            "Five-Seven",
            "G3SG1",
            "Galil AR",
            "Glock-18",
            "K&M",
            "Knife",
            "M249",
            "M4A4",
            "M60",
            "MAC-10",
            "MAG-7",
            "MP5-SD",
            "MP7",
            "MP9",
            "Negev",
            "Nova",
            "P2000",
            "P90",
            "PP-Bizon",
            "R8 Revolver",
            "Sawed-Off",
            "Scar029",
            "SG 553",
            "UMP-45",
            "XM1014"});
            this.comboBox2.Location = new System.Drawing.Point(109, 260);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(350, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Zużycie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pattern";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "LiczbaUzyc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Rodzaj";
            // 
            // LiczbaUzyc
            // 
            this.LiczbaUzyc.Location = new System.Drawing.Point(110, 348);
            this.LiczbaUzyc.Name = "LiczbaUzyc";
            this.LiczbaUzyc.Size = new System.Drawing.Size(349, 20);
            this.LiczbaUzyc.TabIndex = 20;
            // 
            // Pattern
            // 
            this.Pattern.Location = new System.Drawing.Point(110, 320);
            this.Pattern.Name = "Pattern";
            this.Pattern.Size = new System.Drawing.Size(349, 20);
            this.Pattern.TabIndex = 21;
            // 
            // Zuzycie
            // 
            this.Zuzycie.Location = new System.Drawing.Point(109, 293);
            this.Zuzycie.Name = "Zuzycie";
            this.Zuzycie.Size = new System.Drawing.Size(350, 20);
            this.Zuzycie.TabIndex = 22;
            // 
            // Rodzaj
            // 
            this.Rodzaj.Location = new System.Drawing.Point(109, 378);
            this.Rodzaj.Name = "Rodzaj";
            this.Rodzaj.Size = new System.Drawing.Size(351, 20);
            this.Rodzaj.TabIndex = 23;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 456);
            this.Controls.Add(this.Rodzaj);
            this.Controls.Add(this.Zuzycie);
            this.Controls.Add(this.Pattern);
            this.Controls.Add(this.LiczbaUzyc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.Kolekcja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UploadImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.akceptuj);
            this.Controls.Add(this.Nazwa);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LiczbaUzyc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nazwa;
        private System.Windows.Forms.Button akceptuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UploadImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Kolekcja;
        private System.Windows.Forms.RichTextBox Opis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown LiczbaUzyc;
        private System.Windows.Forms.TextBox Pattern;
        private System.Windows.Forms.TextBox Zuzycie;
        private System.Windows.Forms.TextBox Rodzaj;
    }
}