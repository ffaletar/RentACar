using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACar.BL;
using RentACar.BL.EventArguments;

namespace WindowsFormsApplication4.Controls
{
    public partial class PopisRezervacija : UserControl
    {
        public event RacunEventHandler RacunClick;

        
        public PopisRezervacija()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda koja popunjava comboBox sa korisnicima
        /// </summary>
        public void PopuniComboKorisnici()
        {
            Korisnik korisnik = new Korisnik();
            DataTable dtKorisnik = korisnik.DohvatiKorimeID();
            dtKorisnik.Columns[0].ColumnName = "id";
            dtKorisnik.Columns[1].ColumnName = "nadimak";

            DataRow row = dtKorisnik.NewRow();
            row[0] = -1;
            row[1] = "";
            dtKorisnik.Rows.InsertAt(row, 0);

            comboBox6.DataSource = dtKorisnik;
            comboBox6.ValueMember = "id";
            comboBox6.DisplayMember = "nadimak";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                Rezervacija rez = new Rezervacija();
                DataTable dtRezervacije = rez.DohvatiPopisRezervacija();


                
                PopisRezervacijaGrid.DataSource = dtRezervacije;
                PopisRezervacijaGrid.Columns[0].Visible = false;

                PopisRezervacijaGrid.Columns[1].Width = 170;
                PopisRezervacijaGrid.Columns[2].Width = 170;
                PopisRezervacijaGrid.Columns[3].Width = 170;
                PopisRezervacijaGrid.Columns[4].Width = 170;
                
                PopisRezervacijaGrid.Sort(PopisRezervacijaGrid.Columns[1], ListSortDirection.Descending);
            }
            else
            {
                Rezervacija rez = new Rezervacija();
                DataTable dtRezervacije = rez.DohvatiPopisRezervacijaPremaID((int)comboBox6.SelectedValue);


                PopisRezervacijaGrid.DataSource = dtRezervacije;
                PopisRezervacijaGrid.Columns[0].Visible = false;

                PopisRezervacijaGrid.Sort(PopisRezervacijaGrid.Columns[1], ListSortDirection.Descending);
            }




            
        }

        private void PopisRezervacijaGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (PopisRezervacijaGrid.SelectedRows.Count > 0)
            {
                groupBox6.Visible = true;


                DataGridViewRow selectedRow1 = PopisRezervacijaGrid.SelectedRows[0];
                int idMojeRezervacije = Convert.ToInt32(selectedRow1.Cells[0].Value);


                Rezervacija rez = new Rezervacija();
                DataTable dtRezervacije = rez.PopuniRezervaciju(idMojeRezervacije);

                DateTime datumRez = dtRezervacije.Rows[0].Field<DateTime>(1);
                DateTime pocetakPos = dtRezervacije.Rows[0].Field<DateTime>(2);
                DateTime krajPos = dtRezervacije.Rows[0].Field<DateTime>(3);

                Automobil auto = new Automobil();
                int idAutomobila = dtRezervacije.Rows[0].Field<int>(4);
                DataTable dtAutomobilFull = auto.DohvatiAutomobilFull(idAutomobila);

                Korisnik korisnik = new Korisnik();
                int idKorisnika = dtRezervacije.Rows[0].Field<int>(5);
                DataTable dtKorisnikFull = korisnik.DohvatiKorisnikFull(idKorisnika);

                label109.Text = datumRez.ToShortDateString();
                label110.Text = pocetakPos.ToShortDateString();
                label111.Text = krajPos.ToShortDateString();
                label108.Text = dtAutomobilFull.Rows[0].Field<string>(5).ToString() + " " + dtAutomobilFull.Rows[0].Field<string>(6).ToString() + " " + dtAutomobilFull.Rows[0].Field<string>(7).ToString();
                label107.Text = dtRezervacije.Rows[0].Field<string>(7);
                if (dtKorisnikFull.Rows[0] != null)
                {
                    label113.Text = dtKorisnikFull.Rows[0].Field<string>(4);
                }
                
                
                
                label116.Text = dtRezervacije.Rows[0].Field<int>(0).ToString();

            }
            else
            {
                groupBox6.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rezervacija rez = new Rezervacija();
            rez.PostaviStatus(Convert.ToInt32(label116.Text), 2);
            label107.Text = "iskoristena";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezervacija rez = new Rezervacija();
            rez.PostaviStatus(Convert.ToInt32(label116.Text), 4);
            label107.Text = "neiskoristena";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rezervacija rez = new Rezervacija();
            rez.PostaviStatus(Convert.ToInt32(label116.Text), 3);
            label107.Text = "neaktivna";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RacunClick(this, new RacunEventArguments() { rezervacijaID = Convert.ToInt32(label116.Text) });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow =  PopisRezervacijaGrid.SelectedRows[0];
            int idMojeRezervacije = Convert.ToInt32(selectedRow.Cells[0].Value);

            Rezervacija rez = new Rezervacija();
            rez.DeaktivirajOdabranuRezervaciju(idMojeRezervacije);



            

            Rezervacija rezervacija = new Rezervacija();
            DataTable dtRezervacije = rezervacija.DohvatiPopisRezervacija();

            
            PopisRezervacijaGrid.DataSource = dtRezervacije;

            

        }

    }
}
