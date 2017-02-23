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
    public partial class Racun : UserControl
    {
        public int idRezervacije;
        public Racun()
        {
            InitializeComponent();
        }
        public void DohvatiIDRezervacije(int id)
        {
            idRezervacije = id;
        }
        public void PopuniRacun()
        {
            richTextBox1.Clear();
            richTextBox1.Text += "RentACar d.o.o." + "\nZagrebačka ulica" + "\n10000 Zagreb" + "\nOIB: 1234567891011" + "\n____________________________________________" + "\nOpis                      Količina    Iznos (dan)   Ukupno" + "\n-------------------------------------------------------------\n";


            Rezervacija rez = new Rezervacija();
            DataTable dtRezervacije = rez.PopuniRezervaciju(idRezervacije);

            DateTime datumRez = dtRezervacije.Rows[0].Field<DateTime>(1);
            DateTime pocetakPos = dtRezervacije.Rows[0].Field<DateTime>(2);
            DateTime krajPos = dtRezervacije.Rows[0].Field<DateTime>(3);
            DateTime danasnjiDatum = DateTime.Now;

            int razlika = krajPos.DayOfYear - pocetakPos.DayOfYear + 1;

            Automobil auto = new Automobil();
            int idAutomobila = dtRezervacije.Rows[0].Field<int>(4);
            DataTable dtAutomobilFull = auto.DohvatiAutomobilFull(idAutomobila);


            int ukupno = dtAutomobilFull.Rows[0].Field<int>(4) * razlika;
            Korisnik korisnik = new Korisnik();
            int idKorisnika = dtRezervacije.Rows[0].Field<int>(5);
            DataTable dtKorisnikFull = korisnik.DohvatiKorisnikFull(idKorisnika);

            richTextBox1.Text +=  dtAutomobilFull.Rows[0].Field<string>(5).ToString() + " " + dtAutomobilFull.Rows[0].Field<string>(6).ToString() + " " + dtAutomobilFull.Rows[0].Field<string>(7).ToString();
            richTextBox1.Text += "              " + razlika + "        " + dtAutomobilFull.Rows[0].Field<int>(4).ToString()  + " kn"+ "       " + ukupno + " kn";
            richTextBox1.Text += "\n\n____________________________________________";
            richTextBox1.Text += "\n\nUkupno za platiti:" + "                                       " + ukupno + " kn";
            richTextBox1.Text += "\n\n\nPDV   =   25,00 % od   " + ukupno + " kn   =   "+ (0.25 * ukupno) +" kn";

            richTextBox1.Text += "\n\n\n" + danasnjiDatum.ToString();

            richTextBox1.Text += "\n\n-------------------------------------------------";
            richTextBox1.Text += "\nHvala Vam na povjerenju";

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();

        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle rect1 = new Rectangle(150, 150, 450, 580);

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;


            e.Graphics.DrawString(richTextBox1.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Blue, rect1, stringFormat);
            e.Graphics.DrawRectangle(Pens.Black, rect1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
            pd.Print();    
        }
    }

}
