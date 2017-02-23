using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4.Controls
{
    public partial class KorisniciControl : UserControl
    {
        public KorisniciControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda koja dohvaća ID,ime,prezime i nadimak korisnika i prikazuje u DGV-u
        /// </summary>
        public void PopuniKorisnici()
        {
            Korisnik korisnik = new Korisnik();
            DataTable dtKorisnici = korisnik.DohvatiKorisnike();
            dtKorisnici.Columns[0].ColumnName = "ID korisnika";
            dtKorisnici.Columns[1].ColumnName = "Ime";
            dtKorisnici.Columns[2].ColumnName = "Prezime";
            dtKorisnici.Columns[3].ColumnName = "Nadimak";



            KorisniciGrid.AutoGenerateColumns = true;

            KorisniciGrid.DataSource = dtKorisnici;
            KorisniciGrid.Columns[0].Visible = false;
            KorisniciGrid.Columns[1].Width = 150;
            KorisniciGrid.Columns[2].Width = 150;
            KorisniciGrid.Columns[3].Width = 150;


            KorisniciGrid.Sort(KorisniciGrid.Columns[1], ListSortDirection.Ascending);
        }

        private void KorisniciGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (KorisniciGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow1 = KorisniciGrid.SelectedRows[0];
                int idKorisnika = Convert.ToInt32(selectedRow1.Cells[0].Value);

                Korisnik kor = new Korisnik();
                DataTable dtKorisnici = kor.PopuniKorisnika(idKorisnika);
                int brojRezervacija = kor.DohvatiBrojRezervacija(idKorisnika);

                DataRow dr = dtKorisnici.Rows[0];

                label23.Text = dr.Field<string>(1).ToString();
                label24.Text = dr.Field<string>(2).ToString();
                label25.Text = dr.Field<string>(3).ToString();
                label73.Text = dr.Field<string>(9).ToString(); 
                label67.Text = dr.Field<string>(5).ToString();
                label66.Text = dr.Field<string>(4).ToString();
                label65.Text = dr.Field<string>(6).ToString(); 
                label69.Text = dr.Field<string>(7).ToString();
                label71.Text = dr.Field<int>(8).ToString();
                label27.Text = brojRezervacija.ToString();
            }                 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();
            DataGridViewRow selectedRow1 = KorisniciGrid.SelectedRows[0];
            int idKorisnika = Convert.ToInt32(selectedRow1.Cells[0].Value);
            korisnik.PostaviKaoAdmina(idKorisnika);


            label73.Text = "Administrator";

        }

        private void btnBrisiKorisnika_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow1 = KorisniciGrid.SelectedRows[0];
            int idKorisnika = Convert.ToInt32(selectedRow1.Cells[0].Value);
            Korisnik korisnik = new Korisnik();
            korisnik.ObrisiKorisnika(idKorisnika);


            DataTable dtKorisnici = korisnik.DohvatiKorisnike();

            KorisniciGrid.DataSource = dtKorisnici;
            KorisniciGrid.Columns[0].Visible = false;

            KorisniciGrid.Sort(KorisniciGrid.Columns[1], ListSortDirection.Ascending);
        }

        
    }
}
