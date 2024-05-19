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
            this.Label1 = new System.Windows.Forms.Label();
            this.rodzajPrzedmiotu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nazwa
            // 
            this.Nazwa.Location = new System.Drawing.Point(207, 50);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(350, 20);
            this.Nazwa.TabIndex = 0;
            // 
            // akceptuj
            // 
            this.akceptuj.Location = new System.Drawing.Point(360, 326);
            this.akceptuj.Name = "akceptuj";
            this.akceptuj.Size = new System.Drawing.Size(75, 23);
            this.akceptuj.TabIndex = 1;
            this.akceptuj.Text = "button1";
            this.akceptuj.UseVisualStyleBackColor = true;
            this.akceptuj.Click += new System.EventHandler(this.akceptuj_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(106, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Rodzaj Przedmiotu";
            // 
            // rodzajPrzedmiotu
            // 
            this.rodzajPrzedmiotu.FormattingEnabled = true;
            this.rodzajPrzedmiotu.Items.AddRange(new object[] {
            "Skin",
            "Grafiti",
            "Naklejki",
            "Zetony"});
            this.rodzajPrzedmiotu.Location = new System.Drawing.Point(207, 12);
            this.rodzajPrzedmiotu.Name = "rodzajPrzedmiotu";
            this.rodzajPrzedmiotu.Size = new System.Drawing.Size(350, 21);
            this.rodzajPrzedmiotu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa Przedmiotu";
            // 
            // comboBox1
            // 
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
            this.comboBox1.Location = new System.Drawing.Point(207, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rzadkość";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rodzajPrzedmiotu);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.akceptuj);
            this.Controls.Add(this.Nazwa);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nazwa;
        private System.Windows.Forms.Button akceptuj;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox rodzajPrzedmiotu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}