using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RentACar.DAL;
using System.Data;

namespace WindowsFormsApplication4
{
    public class Korisnik
    {
        string Ime, Prezime, Email, Korime, Lozinka, Adresa, Telefon;
        DB baza = new DB();

        public Korisnik() 
        { 
        }

        public Korisnik(string Ime, string Prezime, string Email, string Korime, string Lozinka, string Telefon, string Adresa)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Email = Email;
            this.Korime = Korime;
            this.Lozinka = Lozinka;
            this.Telefon = Telefon;
            this.Adresa = Adresa;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode upisiNovogKorisnika iz DAL sloja
        /// </summary>
        public void upisiNovogKorisnika() 
        {
            KorisnikDal korisnikDal = new KorisnikDal();
            korisnikDal.upisiNovogKorisnika(this.Ime, this.Prezime, this.Email, this.Korime, this.Lozinka, this.Telefon, this.Adresa);
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiKorisnika iz DAL sloja
        /// </summary>
        /// <param name="nadimak"></param>
        /// <returns></returns>
        public DataTable DohvatiKorisnika(string nadimak)
        {
            KorisnikDal korisnikDal = new KorisnikDal();
            DataTable dt = korisnikDal.DohvatiKorisnika(nadimak);


            return dt;

        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiEmail iz DAL sloja
        /// </summary>
        /// <returns></returns>
        public List<string> DohvatiEmail()
        {
            KorisnikDal korisnikDal = new KorisnikDal(); // kompozicija
            List<string> listaEmail = korisnikDal.DohvatiEmail();

            return listaEmail;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiKorime iz DAL sloja
        /// </summary>
        /// <returns></returns>
        public List<string> DohvatiKorime()
        {
            KorisnikDal korisnikDal = new KorisnikDal();
            List<string> listaKorime = korisnikDal.DohvatiKorime();

            return listaKorime;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiKorisnike iz DAL sloja
        /// </summary>
        /// <returns></returns>
        public DataTable DohvatiKorisnike()
        {
            KorisnikDal korisnikDal = new KorisnikDal();
            DataTable dtKorisnici = korisnikDal.DohvatiKorisnike();

            return dtKorisnici;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode PopuniKorisnika iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable PopuniKorisnika(int id)
        {
            KorisnikDal korDAL = new KorisnikDal();
            DataTable dtKorisnik = korDAL.PopuniKorisnika(id);

            return dtKorisnik;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiBrojRezervacija iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DohvatiBrojRezervacija(int id)
        {
            KorisnikDal korDAL = new KorisnikDal();
            int broj = korDAL.DohvatiBrojRezervacija(id);

            return broj;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode PostaviKaoAdministratora iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        public void PostaviKaoAdmina(int id)
        {
            KorisnikDal korisnikDal = new KorisnikDal();
            korisnikDal.PostaviKaoAdministratora(id);

        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode ObrisiKorisnika iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        public void ObrisiKorisnika(int id)
        {
            KorisnikDal korisnikDal = new KorisnikDal();
            korisnikDal.ObrisiKorisnika(id);
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiKorImeID iz DAL sloja
        /// </summary>
        /// <returns></returns>
        public DataTable DohvatiKorimeID()
        {
            KorisnikDal korDal = new KorisnikDal();
            DataTable dtKorisnik = korDal.DohvatiKorimeID();

            return dtKorisnik;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiKorisnikFull iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable DohvatiKorisnikFull(int id)
        {
            KorisnikDal korDal = new KorisnikDal();
            DataTable dtKorisnik = korDal.DohvatiKorisnikFull(id);

            return dtKorisnik;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiNadimak iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DohvatiNadimak(int id)
        {
            KorisnikDal korDAL = new KorisnikDal();
            string nad = korDAL.DohvatiNadimak(id);
            return nad;
        }
    }
}
