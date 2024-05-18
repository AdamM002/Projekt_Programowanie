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
            this.ZmienNazwe = new System.Windows.Forms.TextBox();
            this.akceptuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZmienNazwe
            // 
            this.ZmienNazwe.Location = new System.Drawing.Point(207, 12);
            this.ZmienNazwe.Name = "ZmienNazwe";
            this.ZmienNazwe.Size = new System.Drawing.Size(362, 20);
            this.ZmienNazwe.TabIndex = 0;
            // 
            // akceptuj
            // 
            this.akceptuj.Location = new System.Drawing.Point(350, 38);
            this.akceptuj.Name = "akceptuj";
            this.akceptuj.Size = new System.Drawing.Size(75, 23);
            this.akceptuj.TabIndex = 1;
            this.akceptuj.Text = "button1";
            this.akceptuj.UseVisualStyleBackColor = true;
            this.akceptuj.Click += new System.EventHandler(this.akceptuj_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.akceptuj);
            this.Controls.Add(this.ZmienNazwe);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ZmienNazwe;
        private System.Windows.Forms.Button akceptuj;
    }
}