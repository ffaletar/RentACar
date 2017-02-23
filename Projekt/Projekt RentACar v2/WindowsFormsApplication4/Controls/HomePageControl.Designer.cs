namespace WindowsFormsApplication4.Controls
{
    partial class HomePageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnAutomobili = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKorisnici.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F);
            this.btnKorisnici.Location = new System.Drawing.Point(320, 282);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(230, 163);
            this.btnKorisnici.TabIndex = 6;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervacije.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F);
            this.btnRezervacije.Location = new System.Drawing.Point(468, 77);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(230, 163);
            this.btnRezervacije.TabIndex = 5;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnAutomobili
            // 
            this.btnAutomobili.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutomobili.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F);
            this.btnAutomobili.Location = new System.Drawing.Point(167, 77);
            this.btnAutomobili.Name = "btnAutomobili";
            this.btnAutomobili.Size = new System.Drawing.Size(230, 163);
            this.btnAutomobili.TabIndex = 4;
            this.btnAutomobili.Text = "Automobili";
            this.btnAutomobili.UseVisualStyleBackColor = true;
            this.btnAutomobili.Click += new System.EventHandler(this.btnAutomobili_Click);
            // 
            // HomePageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.btnAutomobili);
            this.Name = "HomePageControl";
            this.Size = new System.Drawing.Size(898, 506);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnAutomobili;
    }
}
