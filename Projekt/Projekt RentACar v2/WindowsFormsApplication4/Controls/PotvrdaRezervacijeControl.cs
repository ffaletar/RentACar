using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WindowsFormsApplication4.Controls
{
    public partial class PotvrdaRezervacijeControl : UserControl
    {
        
        public PotvrdaRezervacijeControl()
        {
            InitializeComponent();
        }
        public void IspuniPotvrdu(DateTime datumRezervacije, DateTime pocetakPosudbe, DateTime krajPosudbe, string korisnikNadimak, string marka, string model, string tip, int cijena)
        {
            richTextBox4.Clear();
            richTextBox4.Text += "POTVRDA REZERVACIJE";
            richTextBox4.Text += "\n_________________________________________";

            richTextBox4.Text += "\n\n\nDatum rezervacije:\n" + datumRezervacije.ToShortDateString();
            richTextBox4.Text += "\n\n\nAutomobil:\n" + marka + "  " + model + "  " + tip;

            richTextBox4.Text += "\n\nKorisnik:\n" + korisnikNadimak;
            richTextBox4.Text += "\n\n\n" + pocetakPosudbe.ToShortDateString() + " - " + krajPosudbe.ToShortDateString();
            richTextBox4.Text += "\n\n\nCijena:\n" + cijena + " kn";

            richTextBox4.SelectAll();
            richTextBox4.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox4.DeselectAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
            pd.Print();            
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle rect1 = new Rectangle(150, 150, 450, 580);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;


            e.Graphics.DrawString(richTextBox4.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Blue, rect1, stringFormat);
            e.Graphics.DrawRectangle(Pens.Black, rect1);

        }

    }
}
