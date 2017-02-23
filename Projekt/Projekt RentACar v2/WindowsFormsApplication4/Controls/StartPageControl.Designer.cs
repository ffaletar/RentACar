namespace WindowsFormsApplication4.Controls
{
    partial class StartPageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPageControl));
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistracija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistracija.FlatAppearance.BorderSize = 0;
            this.btnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistracija.Font = new System.Drawing.Font("Copperplate Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.ForeColor = System.Drawing.Color.Black;
            this.btnRegistracija.Location = new System.Drawing.Point(103, 185);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(393, 100);
            this.btnRegistracija.TabIndex = 6;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.Transparent;
            this.btnPrijava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijava.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrijava.FlatAppearance.BorderSize = 0;
            this.btnPrijava.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrijava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Copperplate Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.Color.Black;
            this.btnPrijava.Location = new System.Drawing.Point(144, 79);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(288, 100);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 257);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // StartPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartPageControl";
            this.Size = new System.Drawing.Size(577, 546);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
