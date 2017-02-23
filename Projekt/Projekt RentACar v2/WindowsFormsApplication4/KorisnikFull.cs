using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class KorisnikFull
    {
        private int korisnikID;

        public int KorisnikID
        {
            get { return korisnikID; }
            set { korisnikID = value; }
        }
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        private string nadimak;

        public string Nadimak
        {
            get { return nadimak; }
            set { nadimak = value; }
        }
        private string lozinka;

        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        private string telefon;

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        private string adresa;

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        private TipKorisnika tipKorisnika;

        public TipKorisnika TipKorisnika
        {
            get { return tipKorisnika; }
            set { tipKorisnika = value; }
        }
        private int brojRezervacija;

        public int BrojRezervacija
        {
            get { return brojRezervacija; }
            set { brojRezervacija = value; }
        }
        
        
    }
}
