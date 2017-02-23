namespace WindowsFormsApplication4.Controls
{
    partial class RegisterControl
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
            this.labelLozinka = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelKorIme = new System.Windows.Forms.Label();
            this.buttonRegistracija = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbKorime = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLozinka.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLozinka.Location = new System.Drawing.Point(543, 256);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(0, 25);
            this.labelLozinka.TabIndex = 36;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEmail.Location = new System.Drawing.Point(543, 150);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 25);
            this.labelEmail.TabIndex = 35;
            // 
            // labelKorIme
            // 
            this.labelKorIme.AutoSize = true;
            this.labelKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKorIme.ForeColor = System.Drawing.Color.DarkRed;
            this.labelKorIme.Location = new System.Drawing.Point(543, 203);
            this.labelKorIme.Name = "labelKorIme";
            this.labelKorIme.Size = new System.Drawing.Size(0, 25);
            this.labelKorIme.TabIndex = 34;
            // 
            // buttonRegistracija
            // 
            this.buttonRegistracija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistracija.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistracija.Location = new System.Drawing.Point(261, 461);
            this.buttonRegistracija.Name = "buttonRegistracija";
            this.buttonRegistracija.Size = new System.Drawing.Size(276, 87);
            this.buttonRegistracija.TabIndex = 33;
            this.buttonRegistracija.Text = "Registriraj se";
            this.buttonRegistracija.UseVisualStyleBackColor = true;
            this.buttonRegistracija.Click += new System.EventHandler(this.buttonRegistracija_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(139, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 34);
            this.label9.TabIndex = 32;
            this.label9.Text = "Adresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(134, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 34);
            this.label8.TabIndex = 31;
            this.label8.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(68, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 34);
            this.label7.TabIndex = 30;
            this.label7.Text = "Email adresa";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdresa.Location = new System.Drawing.Point(261, 356);
            this.tbAdresa.Multiline = true;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(276, 38);
            this.tbAdresa.TabIndex = 29;
            this.tbAdresa.Leave += new System.EventHandler(this.tbAdresa_Leave);
            // 
            // tbTelefon
            // 
            this.tbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTelefon.Location = new System.Drawing.Point(261, 303);
            this.tbTelefon.Multiline = true;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(276, 38);
            this.tbTelefon.TabIndex = 28;
            this.tbTelefon.Leave += new System.EventHandler(this.tbTelefon_Leave);
            // 
            // tbLozinka
            // 
            this.tbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLozinka.Location = new System.Drawing.Point(261, 250);
            this.tbLozinka.Multiline = true;
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(276, 38);
            this.tbLozinka.TabIndex = 27;
            this.tbLozinka.TextChanged += new System.EventHandler(this.tbLozinka_TextChanged);
            this.tbLozinka.Leave += new System.EventHandler(this.tbLozinka_Leave);
            // 
            // tbKorime
            // 
            this.tbKorime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKorime.Location = new System.Drawing.Point(261, 197);
            this.tbKorime.Multiline = true;
            this.tbKorime.Name = "tbKorime";
            this.tbKorime.Size = new System.Drawing.Size(276, 38);
            this.tbKorime.TabIndex = 26;
            this.tbKorime.TextChanged += new System.EventHandler(this.tbKorime_TextChanged);
            this.tbKorime.Leave += new System.EventHandler(this.tbKorime_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.AccessibleName = "emailTB";
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(261, 144);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(276, 38);
            this.tbEmail.TabIndex = 25;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(126, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 34);
            this.label6.TabIndex = 24;
            this.label6.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 34);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(131, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Korisničko ime";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrezime.Location = new System.Drawing.Point(261, 94);
            this.tbPrezime.Multiline = true;
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(276, 38);
            this.tbPrezime.TabIndex = 20;
            this.tbPrezime.Leave += new System.EventHandler(this.tbPrezime_Leave);
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIme.Location = new System.Drawing.Point(261, 44);
            this.tbIme.Multiline = true;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(276, 38);
            this.tbIme.TabIndex = 19;
            this.tbIme.Leave += new System.EventHandler(this.tbIme_Leave);
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelKorIme);
            this.Controls.Add(this.buttonRegistracija);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorime);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(894, 587);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelKorIme;
        private System.Windows.Forms.Button buttonRegistracija;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbKorime;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
    }
}
