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
    public class Rezervacija
    {
        DB baza = new DB();
        int automobilID, korisnikID, statusID;
        DateTime datumRezervacije, pocetakPosudbe, krajPosudbe;
        public Rezervacija()
        {

        }
        public Rezervacija( DateTime datumRezervacije, DateTime pocetakPosudbe, DateTime krajPosudbe, int automobilID, int korisnikID, int statusID)
        {
            this.automobilID = automobilID;
            this.korisnikID = korisnikID;
            this.statusID = statusID;
            this.pocetakPosudbe = pocetakPosudbe;
            this.krajPosudbe = krajPosudbe;
            this.datumRezervacije = datumRezervacije;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode PostaviStatus iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        public void PostaviStatus(int id, int status)
        {
            RezervacijaDAL rezDAL = new RezervacijaDAL();
            rezDAL.PostaviStatus(id, status);
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode upisiNovuRezervaciju iz DAL sloja
        /// </summary>
        public void upisiNovuRezervaciju()
        {
            RezervacijaDAL rezervacijaDal = new RezervacijaDAL();
            rezervacijaDal.upisiNovuRezervaciju(this.datumRezervacije, this.pocetakPosudbe, this.krajPosudbe, this.automobilID, this.korisnikID, this.statusID);
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiMojeRezervacije iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable DohvatiMojeRezervacije(int id)
        {
            RezervacijaDAL rezervacijaDAL = new RezervacijaDAL();

            DataTable dtRezervacije = rezervacijaDAL.DohvatiMojeRezervacije(id);

            return dtRezervacije;            
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DeaktivirajOdabranuRezervaciju iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        public void DeaktivirajOdabranuRezervaciju(int id)
        {
            RezervacijaDAL rezDAL = new RezervacijaDAL();
            rezDAL.DeaktivirajOdabranuRezervaciju(id);
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiPopisRezervacija iz DAL sloja
        /// </summary>
        /// <returns></returns>
        public DataTable DohvatiPopisRezervacija()
        {
            RezervacijaDAL rezDAL = new RezervacijaDAL();
            DataTable dtRezervacije = rezDAL.DohvatiPopisRezervacija();

            return dtRezervacije;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiPopisRezervacijaPremaID iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable DohvatiPopisRezervacijaPremaID(int id)
        {
            RezervacijaDAL rezDAL = new RezervacijaDAL();
            DataTable dtRezervacije = rezDAL.DohvatiPopisRezervacijaPremaID(id);

            return dtRezervacije;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode PopuniRezervaciju iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable PopuniRezervaciju(int id)
        {
            RezervacijaDAL rezDAL = new RezervacijaDAL();
            DataTable dtRez = rezDAL.PopuniRezervaciju(id);

            return dtRez;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode AutoImaRezervacije iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool AutoImaRezervacije(int id)
        {
            RezervacijaDAL rezDAL = new RezervacijaDAL();
            bool imaRezervacije = rezDAL.AutoImaRezervacije(id);

            return imaRezervacije;
        }
    }
}
