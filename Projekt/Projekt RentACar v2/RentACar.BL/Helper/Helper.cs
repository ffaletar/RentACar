using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar;
using RentACar.DAL;

namespace RentACar.BL.Helper
{
    public class Helper
    {        
        public bool RegistracijaPopunjena(string Ime, string Prezime, string Email, string Korime, string Lozinka, string Telefon, string Adresa)
        {
            bool registracijaPopunjena = false;
            bool emailSlobodan = false;
            bool korimeSlobodan = false;
            KorisnikDal korisnikDal = new KorisnikDal();
            List<string> listaMailova = korisnikDal.DohvatiEmail();
            List<string> listaKorime = korisnikDal.DohvatiKorime();

            foreach (string objekt in listaMailova)
            {
                if (Email == objekt)
                {
                    emailSlobodan = false;
                    break;
                }
                else
                {
                    emailSlobodan = true;
                }
            }
            foreach (string objekt in listaKorime)
            {
                if (Korime == objekt)
                {
                    korimeSlobodan = false;
                    break;
                }
                else
                {
                    korimeSlobodan = true;
                }
            }

            if (Ime != "" && Prezime != "" && Email != "" && Korime != "" && Lozinka != "" && Telefon != "" && Adresa != "" && emailSlobodan == true && korimeSlobodan == true)
            {
                registracijaPopunjena = true;
            }
            return registracijaPopunjena;
        }
        /// <summary>
        /// funkcija koja vraca primljeni string sa velikim pocetnim slovom
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string povecajPrvoSlovo(string input)
        {
            if (input != "")
            {
                return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
            }
            else { return ""; }
        }
    }
}
