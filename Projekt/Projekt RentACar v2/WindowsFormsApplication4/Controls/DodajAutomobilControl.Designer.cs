namespace WindowsFormsApplication4.Controls
{
    partial class DodajAutomobilControl
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
            this.labelPoruka = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelSnaga = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonDodajAutomobil = new System.Windows.Forms.Button();
            this.tbCijena = new System.Windows.Forms.TextBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboTip = new System.Windows.Forms.ComboBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonUredi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPoruka
            // 
            this.labelPoruka.AutoSize = true;
            this.labelPoruka.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoruka.Location = new System.Drawing.Point(486, 636);
            this.labelPoruka.Name = "labelPoruka";
            this.labelPoruka.Size = new System.Drawing.Size(311, 24);
            this.labelPoruka.TabIndex = 39;
            this.labelPoruka.Text = "Novi automobil je dodan u garažu";
            this.labelPoruka.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(805, 226);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 24);
            this.label19.TabIndex = 38;
            this.label19.Text = "kWh";
            // 
            // labelSnaga
            // 
            this.labelSnaga.AutoSize = true;
            this.labelSnaga.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSnaga.Location = new System.Drawing.Point(729, 226);
            this.labelSnaga.Name = "labelSnaga";
            this.labelSnaga.Size = new System.Drawing.Size(20, 24);
            this.labelSnaga.TabIndex = 37;
            this.labelSnaga.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(500, 262);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(389, 45);
            this.trackBar1.TabIndex = 36;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // buttonDodajAutomobil
            // 
            this.buttonDodajAutomobil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajAutomobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajAutomobil.Location = new System.Drawing.Point(500, 469);
            this.buttonDodajAutomobil.Name = "buttonDodajAutomobil";
            this.buttonDodajAutomobil.Size = new System.Drawing.Size(268, 143);
            this.buttonDodajAutomobil.TabIndex = 35;
            this.buttonDodajAutomobil.Text = "Dodaj automobil u garažu";
            this.buttonDodajAutomobil.UseVisualStyleBackColor = true;
            this.buttonDodajAutomobil.Click += new System.EventHandler(this.buttonDodajAutomobil_Click);
            // 
            // tbCijena
            // 
            this.tbCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCijena.Location = new System.Drawing.Point(614, 388);
            this.tbCijena.Name = "tbCijena";
            this.tbCijena.Size = new System.Drawing.Size(135, 35);
            this.tbCijena.TabIndex = 34;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(33, 364);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(298, 125);
            this.rtbOpis.TabIndex = 33;
            this.rtbOpis.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(42, 330);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 34);
            this.label17.TabIndex = 32;
            this.label17.Text = "Opis";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(516, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 34);
            this.label16.TabIndex = 31;
            this.label16.Text = "Cijena";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(585, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 34);
            this.label15.TabIndex = 30;
            this.label15.Text = "Snaga";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(156, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 34);
            this.label14.TabIndex = 27;
            this.label14.Text = "Motor";
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(155, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 34);
            this.label13.TabIndex = 26;
            this.label13.Text = "Pogon";
            this.label13.Visible = false;
            // 
            // comboTip
            // 
            this.comboTip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboTip.FormattingEnabled = true;
            this.comboTip.Location = new System.Drawing.Point(262, 155);
            this.comboTip.Name = "comboTip";
            this.comboTip.Size = new System.Drawing.Size(282, 37);
            this.comboTip.TabIndex = 25;
            this.comboTip.SelectedIndexChanged += new System.EventHandler(this.comboTip_SelectedIndexChanged);
            // 
            // comboModel
            // 
            this.comboModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(262, 112);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(282, 37);
            this.comboModel.TabIndex = 24;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(262, 69);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(282, 37);
            this.comboMarka.TabIndex = 23;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(27, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 31);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tip automobila";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(28, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 31);
            this.label11.TabIndex = 21;
            this.label11.Text = "Model automobila";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(28, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "Marka automobila";
            // 
            // buttonUredi
            // 
            this.buttonUredi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUredi.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F);
            this.buttonUredi.Location = new System.Drawing.Point(500, 469);
            this.buttonUredi.Name = "buttonUredi";
            this.buttonUredi.Size = new System.Drawing.Size(268, 143);
            this.buttonUredi.TabIndex = 40;
            this.buttonUredi.Text = "Uredi automobil";
            this.buttonUredi.UseVisualStyleBackColor = true;
            this.buttonUredi.Visible = false;
            this.buttonUredi.Click += new System.EventHandler(this.buttonUredi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Marka automobila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "Model automobila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 34);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tip automobila";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "-1";
            this.label4.TextChanged += new System.EventHandler(this.label4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(296, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // DodajAutomobilControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonUredi);
            this.Controls.Add(this.labelPoruka);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.labelSnaga);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonDodajAutomobil);
            this.Controls.Add(this.tbCijena);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboTip);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "DodajAutomobilControl";
            this.Size = new System.Drawing.Size(917, 728);
            this.Load += new System.EventHandler(this.DodajAutomobilControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPoruka;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelSnaga;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonDodajAutomobil;
        private System.Windows.Forms.TextBox tbCijena;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboTip;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
