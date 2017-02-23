namespace WindowsFormsApplication4.Controls
{
    partial class LoginControl
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
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.tbLoz = new System.Windows.Forms.TextBox();
            this.tbNadimak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrijava.Font = new System.Drawing.Font("Copperplate Gothic Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrijava.Location = new System.Drawing.Point(365, 235);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(209, 87);
            this.buttonPrijava.TabIndex = 10;
            this.buttonPrijava.Text = "Prijavi se";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // tbLoz
            // 
            this.tbLoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLoz.Location = new System.Drawing.Point(303, 136);
            this.tbLoz.Multiline = true;
            this.tbLoz.Name = "tbLoz";
            this.tbLoz.Size = new System.Drawing.Size(271, 38);
            this.tbLoz.TabIndex = 9;
            this.tbLoz.TextChanged += new System.EventHandler(this.tbLoz_TextChanged);
            this.tbLoz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLoz_KeyDown);
            // 
            // tbNadimak
            // 
            this.tbNadimak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNadimak.Location = new System.Drawing.Point(303, 57);
            this.tbNadimak.Multiline = true;
            this.tbNadimak.Name = "tbNadimak";
            this.tbNadimak.Size = new System.Drawing.Size(271, 38);
            this.tbNadimak.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(170, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(88, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Korisničko ime";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.tbLoz);
            this.Controls.Add(this.tbNadimak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(684, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.TextBox tbLoz;
        private System.Windows.Forms.TextBox tbNadimak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
