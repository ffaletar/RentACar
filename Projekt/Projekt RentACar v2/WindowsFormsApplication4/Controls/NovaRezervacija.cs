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
    public partial class NovaRezervacija : UserControl
    {
        public event PotvrdaRezervacijeEventHandler PotvrdaRezervacijeClick;
        public event DodajAutomobilEventHandler DodajAutomobilClick;
        public NovaRezervacija()
        {
            InitializeComponent();


            Korisnik korisnik = new Korisnik();
            DataTable dtKorisnik = korisnik.DohvatiKorimeID();
            comboKorisnici.DataSource = dtKorisnik;
            dtKorisnik.Columns[0].ColumnName = "ID";
            dtKorisnik.Columns[1].ColumnName = "Nadimak";

            comboKorisnici.ValueMember = "ID";
            comboKorisnici.DisplayMember = "Nadimak";
        }
        /// <summary>
        /// Metoda za provjeru tipa korisnika
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        public void PopuniUserID(int id, int type)
        {
            labelUserID.Text = id.ToString();
            label1.Text = type.ToString();


            comboKorisnici.SelectedValue = id;
        }
        /// <summary>
        /// Metoda koja popunjava comboBox sa markama
        /// </summary>
        public void PopuniComboMarka()
        {
            Automobil auto = new Automobil();
            List<string> listaMarki = auto.DohvatiMarke();

            comboBox1.DataSource = listaMarki;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "")
            {
                Automobil auto = new Automobil();
                DataTable dt = auto.DohvatiAutomobile();

                dt.Columns[1].ColumnName = "Marka";
                dt.Columns[2].ColumnName = "Model";
                dt.Columns[3].ColumnName = "Tip";

                AutiGrid.DataSource = dt;

                AutiGrid.Columns[0].Visible = false;
                AutiGrid.Columns[4].Visible = false;

                AutiGrid.Columns[1].Width = 170;
                AutiGrid.Columns[2].Width = 170;
                AutiGrid.Columns[3].Width = 170;
            }
            else
            {
                Automobil auto = new Automobil();
                DataTable dt = auto.DohvatiAutomobilPremaMarki(comboBox1.SelectedValue.ToString());



                AutiGrid.DataSource = dt;

                AutiGrid.Columns[0].Visible = false;
               
                AutiGrid.Columns[4].Visible = false;
                AutiGrid.Columns[5].Visible = false;
                AutiGrid.Columns[6].Visible = false;
                AutiGrid.Columns[7].Visible = false;
                AutiGrid.Columns[8].Visible = false;

            }
        }
        public int idRezervacije = -1;

        private void AutiGrid_SelectionChanged(object sender, EventArgs e)
        {
            labelODRez.Text = "";
            labelDORez.Text = "";
            labelCijenaRez.Text = "";

            if (AutiGrid.SelectedRows.Count <1)
            {
                groupBox7.Visible = false;
            }
            else
            {
                groupBox7.Visible = true;
                DataGridViewRow dgvr = AutiGrid.SelectedRows[0];

                int id = Convert.ToInt32(dgvr.Cells[0].Value);

                idRezervacije = id;

                IspuniAutomobilControl(id);
            }
           
        }
        /// <summary>
        ///  Metoda za popunjavanje DataGrida sa podacima odabranog automobila
        /// </summary>
        /// <param name="id"></param>
        public void IspuniAutomobilControl(int id)
        {
            int idAutomobila = id;


            Automobil auto = new Automobil();
            DataRow rowAutoDAL = auto.DohvatiAutomobilPremaID(idAutomobila);

            label98.Text = rowAutoDAL.Field<int>("automobilID").ToString();
            labelMarkaRez.Text = rowAutoDAL.Field<string >("marka");
            labelTipRez.Text = rowAutoDAL.Field<string >("tip");
            labelModelRez.Text = rowAutoDAL.Field<string>("model");

          

            label103.Text = rowAutoDAL.Field<int>("cijena").ToString();



            DateTime pocetakPosudbe;
            DateTime krajPosudbe;

            monthCalendar1.BoldedDates = null;


            foreach (DataRow dr in auto.DohvatiDatume(idAutomobila).Rows)
            {
                pocetakPosudbe = dr.Field<DateTime>(0);
                krajPosudbe = dr.Field<DateTime>(1);

                int pocetak = Convert.ToInt32(pocetakPosudbe.DayOfYear);
                int kraj = Convert.ToInt32(krajPosudbe.DayOfYear);

                List<int> listaDay = new List<int>();

                for (int i = pocetak; i <= kraj; i++)
                {
                    listaDay.Add(i);
                }

                List<DateTime> listaDana = new List<DateTime>();

                foreach (int objekt in listaDay)
                {
                    DateTime datum = new DateTime(pocetakPosudbe.Year, 1, 1).AddDays(objekt - 1);
                    listaDana.Add(datum);
                }

                foreach (var element in listaDana)
                {
                    monthCalendar1.AddBoldedDate(element);
                }
            }

            monthCalendar1.Update();
            monthCalendar1.UpdateBoldedDates();

            labelDatumRez.Text = DateTime.Today.ToShortDateString(); 

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime[] boldaniDatumi = monthCalendar1.BoldedDates;

            int pocetakDatum = monthCalendar1.SelectionStart.DayOfYear;
            int krajDatum = monthCalendar1.SelectionEnd.DayOfYear;

            List<int> selektiraniDatumi = new List<int>();

            for (int i = pocetakDatum; i <= krajDatum; i++)
            {
                selektiraniDatumi.Add(i);
            }

            List<DateTime> listaDana = new List<DateTime>();

            foreach (int objekt in selektiraniDatumi)
            {
                DateTime datum = new DateTime(monthCalendar1.SelectionStart.Year, 1, 1).AddDays(objekt - 1);
                listaDana.Add(datum);
            }
            bool contains = true;
            foreach (DateTime datum in listaDana)
            {
                contains = boldaniDatumi.Contains(datum);
                if (contains == true)
                {
                    break;
                }
            }

            if (pocetakDatum < monthCalendar1.TodayDate.DayOfYear)
            {
                label100.Visible = false;
                label95.Visible = false;
                label96.Visible = false;
                MessageBox.Show("Greška, odabrali ste datum koji je već prošao");
                labelODRez.Text = "";
                labelDORez.Text = "";
                labelCijenaRez.Text = "";

            }
            else if (contains == true)
            {
                label100.Visible = false;
                label95.Visible = false;
                label96.Visible = false;
                MessageBox.Show("Greška, odabrali ste datum kada je ovaj automobil već rezerviran");
                labelODRez.Text = "";
                labelDORez.Text = "";
                labelCijenaRez.Text = "";
            }
            else
            {
                label100.Visible = true;
                label95.Visible = false;
                label96.Visible = false;
                labelODRez.Text = monthCalendar1.SelectionStart.ToShortDateString();
                labelDORez.Text = monthCalendar1.SelectionEnd.ToShortDateString();

                SelectionRange sr = monthCalendar1.SelectionRange;
                int brojDana = sr.End.Subtract(sr.Start).Days + 1;

                labelCijenaRez.Text = Convert.ToString(brojDana * Convert.ToInt32(label103.Text));
            }          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "2")
            {
                comboKorisnici.Visible = false;
            }
            else
            {
                comboKorisnici.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (labelCijenaRez.Text != "" && label98.Text != "")
            {

                Rezervacija rezervacija = new Rezervacija(Convert.ToDateTime(labelDatumRez.Text), Convert.ToDateTime(labelODRez.Text), Convert.ToDateTime(labelDORez.Text), Convert.ToInt32(label98.Text), Convert.ToInt32(comboKorisnici.SelectedValue), 1);
                rezervacija.upisiNovuRezervaciju();



                PotvrdaRezervacijeEventArgs potvrda = new PotvrdaRezervacijeEventArgs();

                potvrda.datumRezervacije = Convert.ToDateTime(labelDatumRez.Text);
                potvrda.korisnikID = Convert.ToInt32(comboKorisnici.SelectedValue);
                potvrda.marka = Convert.ToString(labelMarkaRez.Text);
                potvrda.model = Convert.ToString(labelModelRez.Text);
                potvrda.tip = Convert.ToString(labelTipRez.Text);
                potvrda.pocetakPosudbe = Convert.ToDateTime(labelODRez.Text);
                potvrda.krajPosudbe = Convert.ToDateTime(labelDORez.Text);
                potvrda.cijena = Convert.ToInt32(labelCijenaRez.Text);

                Korisnik kor = new Korisnik();

                potvrda.korisnikNadimak = kor.DohvatiNadimak(Convert.ToInt32(comboKorisnici.SelectedValue));

                Automobil auto = new Automobil();
                

                PotvrdaRezervacijeClick(this, potvrda); 


                groupBox7.Visible = false;

                MessageBox.Show("Uspješno ste rezervirali automobil");

                AutiGrid.ClearSelection();
            }
            else
            {
                MessageBox.Show("Rezervacija nije ispravna, molimo ispravno popunite sva polja");
            }
        }
    }
}
