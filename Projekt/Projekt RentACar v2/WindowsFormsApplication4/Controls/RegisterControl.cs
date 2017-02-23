using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACar.BL.Helper;
using RentACar.BL;

namespace WindowsFormsApplication4.Controls
{
    public partial class RegisterControl : UserControl
    {
        public event EventHandler KorisnikRegistriran;
        public RegisterControl()
        {
            InitializeComponent();
        }
        Helper helper = new Helper();
        private void buttonRegistracija_Click(object sender, EventArgs e)
        {            
            if (helper.RegistracijaPopunjena(tbIme.Text, tbPrezime.Text, tbEmail.Text, tbKorime.Text, tbLozinka.Text, tbTelefon.Text, tbAdresa.Text) == true && korimeZauzeto == 0 && emailZauzet==0)
            {
                Korisnik korisnik = new Korisnik(tbIme.Text, tbPrezime.Text, tbEmail.Text, tbKorime.Text, tbLozinka.Text, tbTelefon.Text, tbAdresa.Text);
                korisnik.upisiNovogKorisnika();


                ObojiPoljaRegistracije(tbIme, 2);
                ObojiPoljaRegistracije(tbPrezime, 2);
                ObojiPoljaRegistracije(tbEmail, 2);
                ObojiPoljaRegistracije(tbKorime, 2);
                ObojiPoljaRegistracije(tbLozinka, 2);
                ObojiPoljaRegistracije(tbTelefon, 2);
                ObojiPoljaRegistracije(tbAdresa, 2);


                labelEmail.Text = "";
                labelKorIme.Text = "";
                labelLozinka.Text = "";
                tbIme.Clear();
                tbPrezime.Clear();
                tbTelefon.Clear();
                tbLozinka.Clear();
                tbKorime.Clear();
                tbAdresa.Clear();
                tbEmail.Clear();
                MessageBox.Show("Uspješno ste se registrirali!");

                KorisnikRegistriran(this, EventArgs.Empty);
            }
            else { MessageBox.Show("Sva polja moraju biti ispravno popunjena"); }
        }

        private void tbIme_Leave(object sender, EventArgs e)
        {
            if (tbIme.Text != "")
            {
                string ime = helper.povecajPrvoSlovo(tbIme.Text);
                tbIme.Text = ime;
                ObojiPoljaRegistracije(tbIme, 1);
            }
            else
            {
                ObojiPoljaRegistracije(tbIme, 2);
            }
        }

        private void tbPrezime_Leave(object sender, EventArgs e)
        {
            if (tbPrezime.Text != "")
            {
                string prezime = helper.povecajPrvoSlovo(tbPrezime.Text);
                tbPrezime.Text = prezime;
                ObojiPoljaRegistracije(tbPrezime, 1);
            }
            else
            {
                ObojiPoljaRegistracije(tbPrezime, 2);
            }
        }

        private void tbAdresa_Leave(object sender, EventArgs e)
        {
            if (tbAdresa.Text != "")
            {
                ObojiPoljaRegistracije(tbAdresa, 1);
            }
            else
            {
                ObojiPoljaRegistracije(tbAdresa, 2);
            }
        }

        private void tbTelefon_Leave(object sender, EventArgs e)
        {
            if (tbTelefon.Text != "")
            {
                ObojiPoljaRegistracije(tbTelefon, 1);
            }
            else
            {
                ObojiPoljaRegistracije(tbTelefon, 2);
            }
        }
        public int emailZauzet = 0;
        public int korimeZauzeto = 0;
        public bool lozinkaIspravna = false;
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            int tocno = 1;
            string greska = "Ovaj mail je već registriran";
            Korisnik korisnik = new Korisnik();
            List<string> listaEmail = korisnik.DohvatiEmail();
                        

            foreach (var objekt in listaEmail)
            {
                if (objekt == tbEmail.Text)
                {
                    ObojiPoljaRegistracije(tbEmail, 0);
                    labelEmail.Text = greska;
                    tocno = 0;
                    emailZauzet = 1;
                }
            }
            if (tbEmail.Text == "")
            {
                ObojiPoljaRegistracije(tbEmail, 2);
                labelEmail.Text = "";
                tocno = 0;
            }
            if (tocno == 1)
            {
                ObojiPoljaRegistracije(tbEmail, 1);
                labelEmail.Text = "";
                emailZauzet = 0;
            }
        }

        private void tbLozinka_Leave(object sender, EventArgs e)
        {
            string greska = "Lozinka nije ispravno unesena";

            if (tbLozinka.Text.Length == 0)
            {
                ObojiPoljaRegistracije(tbLozinka, 2);
                lozinkaIspravna = false;
                labelLozinka.Text = "";
            }
            else if (tbLozinka.Text.Length > 0 && tbLozinka.Text.Length < 4)
            {
                ObojiPoljaRegistracije(tbLozinka, 0);
                lozinkaIspravna = false;
                labelLozinka.Text = greska;
            }
            else
            {
                ObojiPoljaRegistracije(tbLozinka, 1);
                lozinkaIspravna = true;
                labelLozinka.Text = "";
            }            
        }

        private void tbKorime_TextChanged(object sender, EventArgs e)
        {
            tbKorime.MaxLength = 14;
        }

        private void tbKorime_Leave(object sender, EventArgs e)
        {
            //ovaj dio koda radi provjeru. Provjerava se postoji li upisano korisničko ime već u bazi, ukoliko 
            //postoji zacrveni polje i ispiši grešku, a ukoliko ne postoji nastavi dalje
            int zauzeto = 0;
            int tocno = 1;
            
            Korisnik korisnik = new Korisnik();
            List<string> listaKorIme = korisnik.DohvatiKorime();

            
            foreach (var objekt in listaKorIme)
            {
                if (tbKorime.Text == objekt)
                {
                    zauzeto = 1;
                    korimeZauzeto = 1;
                }
            }
            

            if (tbKorime.Text == "")
            {
                ObojiPoljaRegistracije(tbKorime, 2);
                labelKorIme.Text = "";
                tocno = 0;
            }
            if (zauzeto == 1)
            {
                ObojiPoljaRegistracije(tbKorime, 0);
                labelKorIme.Text = "Ovo korisnicko ime je već zauzeto";
                tocno = 0;
            }
            if (tocno == 1)
            {
                ObojiPoljaRegistracije(tbKorime, 1);
                labelKorIme.Text = "";
                korimeZauzeto = 0;
            }

        }

        private void tbLozinka_TextChanged(object sender, EventArgs e)
        {
            tbLozinka.PasswordChar = '*';
            tbLozinka.MaxLength = 14;
        }
        public void ObojiPoljaRegistracije(TextBox tb, int ispravnost)
        {
            if (ispravnost == 1)
            {
                tb.BackColor = System.Drawing.Color.DarkSeaGreen;
                tb.ForeColor = System.Drawing.Color.White;
            }
            else if (ispravnost == 0)
            {
                tb.BackColor = System.Drawing.Color.IndianRed;
                tb.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                tb.BackColor = System.Drawing.Color.White;
                tb.ForeColor = System.Drawing.Color.Black;
            }

        }
        
    }
}
