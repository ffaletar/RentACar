namespace WindowsFormsApplication4.Controls
{
    partial class RezervacijeControl
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
            this.btnNovaRezervacija = new System.Windows.Forms.Button();
            this.btnMojeRezervacije = new System.Windows.Forms.Button();
            this.btnPopisRezervacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaRezervacija
            // 
            this.btnNovaRezervacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaRezervacija.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaRezervacija.Location = new System.Drawing.Point(541, 124);
            this.btnNovaRezervacija.Name = "btnNovaRezervacija";
            this.btnNovaRezervacija.Size = new System.Drawing.Size(239, 151);
            this.btnNovaRezervacija.TabIndex = 7;
            this.btnNovaRezervacija.Text = "Nova rezervacija";
            this.btnNovaRezervacija.UseVisualStyleBackColor = true;
            this.btnNovaRezervacija.Click += new System.EventHandler(this.btnNovaRezervacija_Click);
            // 
            // btnMojeRezervacije
            // 
            this.btnMojeRezervacije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMojeRezervacije.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMojeRezervacije.Location = new System.Drawing.Point(169, 124);
            this.btnMojeRezervacije.Name = "btnMojeRezervacije";
            this.btnMojeRezervacije.Size = new System.Drawing.Size(239, 151);
            this.btnMojeRezervacije.TabIndex = 6;
            this.btnMojeRezervacije.Text = "Moje rezervacije";
            this.btnMojeRezervacije.UseVisualStyleBackColor = true;
            this.btnMojeRezervacije.Click += new System.EventHandler(this.btnMojeRezervacije_Click);
            // 
            // btnPopisRezervacija
            // 
            this.btnPopisRezervacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPopisRezervacija.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopisRezervacija.Location = new System.Drawing.Point(356, 307);
            this.btnPopisRezervacija.Name = "btnPopisRezervacija";
            this.btnPopisRezervacija.Size = new System.Drawing.Size(239, 151);
            this.btnPopisRezervacija.TabIndex = 5;
            this.btnPopisRezervacija.Text = "Popis rezervacija";
            this.btnPopisRezervacija.UseVisualStyleBackColor = true;
            this.btnPopisRezervacija.Click += new System.EventHandler(this.btnPopisRezervacija_Click);
            // 
            // RezervacijeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNovaRezervacija);
            this.Controls.Add(this.btnMojeRezervacije);
            this.Controls.Add(this.btnPopisRezervacija);
            this.Name = "RezervacijeControl";
            this.Size = new System.Drawing.Size(953, 535);
            this.Load += new System.EventHandler(this.RezervacijeControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaRezervacija;
        private System.Windows.Forms.Button btnMojeRezervacije;
        private System.Windows.Forms.Button btnPopisRezervacija;

    }
}
