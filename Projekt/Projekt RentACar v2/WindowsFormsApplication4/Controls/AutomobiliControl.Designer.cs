namespace WindowsFormsApplication4.Controls
{
    partial class AutomobiliControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnObrisiAutomobil = new System.Windows.Forms.Button();
            this.btnUrediAutomobil = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.btnSvi = new System.Windows.Forms.Button();
            this.autiGrid = new System.Windows.Forms.DataGridView();
            this.automobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPregledaj = new System.Windows.Forms.Button();
            this.btnDodajAutomobil = new System.Windows.Forms.Button();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.autiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiAutomobil
            // 
            this.btnObrisiAutomobil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiAutomobil.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F);
            this.btnObrisiAutomobil.Location = new System.Drawing.Point(758, 368);
            this.btnObrisiAutomobil.Name = "btnObrisiAutomobil";
            this.btnObrisiAutomobil.Size = new System.Drawing.Size(181, 78);
            this.btnObrisiAutomobil.TabIndex = 30;
            this.btnObrisiAutomobil.Text = "Obriši";
            this.btnObrisiAutomobil.UseVisualStyleBackColor = true;
            this.btnObrisiAutomobil.Click += new System.EventHandler(this.btnObrisiAutomobil_Click);
            // 
            // btnUrediAutomobil
            // 
            this.btnUrediAutomobil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrediAutomobil.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F);
            this.btnUrediAutomobil.Location = new System.Drawing.Point(758, 452);
            this.btnUrediAutomobil.Name = "btnUrediAutomobil";
            this.btnUrediAutomobil.Size = new System.Drawing.Size(181, 78);
            this.btnUrediAutomobil.TabIndex = 29;
            this.btnUrediAutomobil.Text = "Uredi";
            this.btnUrediAutomobil.UseVisualStyleBackColor = true;
            this.btnUrediAutomobil.Click += new System.EventHandler(this.btnUrediAutomobil_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label45.Location = new System.Drawing.Point(302, 33);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(69, 24);
            this.label45.TabIndex = 26;
            this.label45.Text = "Marke";
            // 
            // btnSvi
            // 
            this.btnSvi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSvi.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSvi.Location = new System.Drawing.Point(75, 60);
            this.btnSvi.Name = "btnSvi";
            this.btnSvi.Size = new System.Drawing.Size(167, 33);
            this.btnSvi.TabIndex = 25;
            this.btnSvi.Text = "Prikaži sve";
            this.btnSvi.UseVisualStyleBackColor = true;
            this.btnSvi.Click += new System.EventHandler(this.btnSvi_Click);
            // 
            // autiGrid
            // 
            this.autiGrid.AllowUserToAddRows = false;
            this.autiGrid.AllowUserToDeleteRows = false;
            this.autiGrid.AllowUserToResizeColumns = false;
            this.autiGrid.AllowUserToResizeRows = false;
            this.autiGrid.AutoGenerateColumns = false;
            this.autiGrid.BackgroundColor = System.Drawing.Color.White;
            this.autiGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autiGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.autiGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.autiGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.autiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autiGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autiGrid.DataSource = this.automobilBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.autiGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.autiGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.autiGrid.EnableHeadersVisualStyles = false;
            this.autiGrid.GridColor = System.Drawing.Color.White;
            this.autiGrid.Location = new System.Drawing.Point(75, 110);
            this.autiGrid.MultiSelect = false;
            this.autiGrid.Name = "autiGrid";
            this.autiGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.autiGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.autiGrid.RowHeadersVisible = false;
            this.autiGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.autiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.autiGrid.ShowCellErrors = false;
            this.autiGrid.ShowCellToolTips = false;
            this.autiGrid.ShowEditingIcon = false;
            this.autiGrid.ShowRowErrors = false;
            this.autiGrid.Size = new System.Drawing.Size(655, 546);
            this.autiGrid.TabIndex = 22;
            // 
            // automobilBindingSource
            // 
            this.automobilBindingSource.DataSource = typeof(WindowsFormsApplication4.Automobil);
            // 
            // btnPregledaj
            // 
            this.btnPregledaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregledaj.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledaj.Location = new System.Drawing.Point(747, 110);
            this.btnPregledaj.Name = "btnPregledaj";
            this.btnPregledaj.Size = new System.Drawing.Size(206, 78);
            this.btnPregledaj.TabIndex = 21;
            this.btnPregledaj.Text = "Pogledaj automobil";
            this.btnPregledaj.UseVisualStyleBackColor = true;
            this.btnPregledaj.Click += new System.EventHandler(this.btnPregledaj_Click);
            // 
            // btnDodajAutomobil
            // 
            this.btnDodajAutomobil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajAutomobil.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F);
            this.btnDodajAutomobil.Location = new System.Drawing.Point(758, 536);
            this.btnDodajAutomobil.Name = "btnDodajAutomobil";
            this.btnDodajAutomobil.Size = new System.Drawing.Size(181, 78);
            this.btnDodajAutomobil.TabIndex = 20;
            this.btnDodajAutomobil.Text = "Dodaj";
            this.btnDodajAutomobil.UseVisualStyleBackColor = true;
            this.btnDodajAutomobil.Click += new System.EventHandler(this.btnDodajAutomobil_Click);
            // 
            // cbMarka
            // 
            this.cbMarka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(258, 60);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(167, 33);
            this.cbMarka.TabIndex = 19;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            // 
            // AutomobiliControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnObrisiAutomobil);
            this.Controls.Add(this.btnUrediAutomobil);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.btnSvi);
            this.Controls.Add(this.autiGrid);
            this.Controls.Add(this.btnPregledaj);
            this.Controls.Add(this.btnDodajAutomobil);
            this.Controls.Add(this.cbMarka);
            this.Name = "AutomobiliControl";
            this.Size = new System.Drawing.Size(988, 717);
            ((System.ComponentModel.ISupportInitialize)(this.autiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiAutomobil;
        private System.Windows.Forms.Button btnUrediAutomobil;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btnSvi;
        private System.Windows.Forms.DataGridView autiGrid;
        private System.Windows.Forms.Button btnPregledaj;
        private System.Windows.Forms.Button btnDodajAutomobil;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.BindingSource automobilBindingSource;
    }
}
