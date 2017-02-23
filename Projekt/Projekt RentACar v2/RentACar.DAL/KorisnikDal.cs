using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication4;

namespace RentACar.DAL
{
    public class KorisnikDal
    {
        DB baza = new DB();

        /// <summary>
        /// Metoda za upisivanje novih korisnika, koristi se u kontroli Registracija
        /// </summary>
        /// <param name="Ime"></param>
        /// <param name="Prezime"></param>
        /// <param name="Email"></param>
        /// <param name="Korime"></param>
        /// <param name="Lozinka"></param>
        /// <param name="Telefon"></param>
        /// <param name="Adresa"></param>
        public void upisiNovogKorisnika(string Ime, string Prezime, string Email, string Korime, string Lozinka, string Telefon, string Adresa)
        {
            baza.openDB();

            List<int> listaB = new List<int>();
            SqlCommand dohvatiSveID = new SqlCommand("SELECT korisnikID from [dbo].[Korisnik]", baza.conn);
            SqlDataReader dohvatiSve = dohvatiSveID.ExecuteReader();
            while (dohvatiSve.Read())
            {
                listaB.Add(dohvatiSve.GetInt32(0));
            }
            dohvatiSve.Close();

            string naredba = "INSERT into [dbo].[Korisnik] values (@Ime, @Prezime, @Korime, @Lozinka, @Email, @Telefon, @Adresa, @TipID)";
            SqlCommand upisiKorisnika = new SqlCommand(naredba, baza.conn);

            upisiKorisnika.Parameters.AddWithValue("@Ime", Ime);
            upisiKorisnika.Parameters.AddWithValue("@Prezime", Prezime);
            upisiKorisnika.Parameters.AddWithValue("@Email", Email);
            upisiKorisnika.Parameters.AddWithValue("@Korime", Korime);
            upisiKorisnika.Parameters.AddWithValue("@Lozinka", Lozinka);
            upisiKorisnika.Parameters.AddWithValue("@Telefon", Telefon);
            upisiKorisnika.Parameters.AddWithValue("@Adresa", Adresa);
            upisiKorisnika.Parameters.AddWithValue("@TipID", 2);
            upisiKorisnika.ExecuteNonQuery();

            baza.closeDB();
        }
        /// <summary>
        /// Dohvaca lozinku, tip i ID korisnika kod prijavljivanja korisnika u sustav,
        /// koristi se u kontroli Login
        /// </summary>
        /// <param name="nadimak"></param>
        /// <returns>vraca podatke u obliku dataTable</returns>

        public DataTable DohvatiKorisnika(string nadimak)
        {
            baza.openDB();

            string dohvatiKorI = "SELECT lozinka, tipID, korisnikID FROM [dbo].[Korisnik] WHERE nadimak = @nadimak";

            SqlDataAdapter daKorisnici = new SqlDataAdapter(dohvatiKorI, baza.conn);
            daKorisnici.SelectCommand.Parameters.AddWithValue("nadimak", nadimak);
            DataSet dsAutomobili = new DataSet();
            daKorisnici.Fill(dsAutomobili, "Automobil_table");

            baza.closeDB();

            return dsAutomobili.Tables["Automobil_table"];
        }

        /// <summary>
        /// Metoda koja dohvaća e-mail i provjerava je li korisnik već registriran na taj mail,
        /// koristi se u kontroli Register
        /// </summary>
        /// <returns></returns>
        public List<string> DohvatiEmail()
        {
            baza.openDB();

            List<string> listaMailova = new List<string>();

            SqlCommand dohvatiEmail = new SqlCommand("Select mail from [dbo].Korisnik", baza.conn);
            SqlDataReader dohvatiEmailReader = dohvatiEmail.ExecuteReader();
            while (dohvatiEmailReader.Read())
            {
                listaMailova.Add(dohvatiEmailReader.GetString(0));
            }
            dohvatiEmailReader.Close();

            baza.closeDB();

            return listaMailova;
        }
        /// <summary>
        /// Dohvaća korisničko ime i koristi se u kontroli Register
        /// </summary>
        /// <returns></returns>
        public List<string> DohvatiKorime()
        {
            baza.openDB();

            List<string> listaKorime = new List<string>();

            SqlCommand dohvatiKorime = new SqlCommand("Select nadimak from [dbo].Korisnik", baza.conn);
            SqlDataReader dohvatiKorimeReader = dohvatiKorime.ExecuteReader();
            while (dohvatiKorimeReader.Read())
            {
                listaKorime.Add(dohvatiKorimeReader.GetString(0));
            }
            dohvatiKorimeReader.Close();

            baza.closeDB();

            return listaKorime;
        }
        /// <summary>
        /// Dohvaca ID, ime, prezime i nadimak svih korisnika
        /// </summary>
        /// <returns>u obliku data table</returns>
        public DataTable DohvatiKorisnike()
        {
            baza.closeDB();
            baza.openDB();

            string dohvatiKorisnike = "select [dbo].[Korisnik].korisnikID, [dbo].[Korisnik].ime, [dbo].[Korisnik].prezime, [dbo].[Korisnik].nadimak from [dbo].[Korisnik]";
            SqlDataAdapter daKorisnici = new SqlDataAdapter(dohvatiKorisnike, baza.conn);
            DataSet dsKorisnici = new DataSet();
            daKorisnici.Fill(dsKorisnici, "Korisnik_table");
            
            baza.closeDB();

            return dsKorisnici.Tables["Korisnik_table"];

        }
        /// <summary>
        /// Dohvaca podatke o korisniku prema njegovom IDu kako bi se prikazali njegovi podaci
        /// u kontroli Korisnik
        /// </summary>
        /// <param name="idKorisnika"></param>
        /// <returns>vraca u obliku datatable</returns>
        public DataTable PopuniKorisnika(int idKorisnika)
        {
            baza.closeDB();
            baza.openDB();



            SqlDataAdapter popuniKorisnikFull = new SqlDataAdapter("SELECT [dbo].[Korisnik].korisnikID, [dbo].[Korisnik].ime, [dbo].[Korisnik].prezime, [dbo].[Korisnik].nadimak, [dbo].[Korisnik].lozinka, [dbo].[Korisnik].mail, [dbo].[Korisnik].telefon, [dbo].[Korisnik].adresa, [dbo].[TipKorisnika].tipID,[dbo].[TipKorisnika].naziv FROM [dbo].[Korisnik] join [dbo].TipKorisnika on [dbo].Korisnik.tipID = [dbo].TipKorisnika.tipID WHERE [dbo].Korisnik.korisnikID = @korisnikID", baza.conn);
            popuniKorisnikFull.SelectCommand.Parameters.AddWithValue("@korisnikID", idKorisnika);
            DataSet dsKorisnikFull = new DataSet();
            popuniKorisnikFull.Fill(dsKorisnikFull, "KorisnikFull_table");

            baza.closeDB();

            return dsKorisnikFull.Tables["KorisnikFull_table"];
        }
        /// <summary>
        /// Dohvaća broj rezervacija za određenog korisnika
        /// </summary>
        /// <param name="idKorisnika"></param>
        /// <returns>vraca cijeli broj</returns>
        public int DohvatiBrojRezervacija(int idKorisnika)
        {
            baza.closeDB();
            baza.openDB();
            int brojRezervacijaKorisnika = 0;

            SqlCommand brojRezervacija = new SqlCommand("select COUNT(*) from [dbo].Rezervacija where korisnikID = @korisnikID", baza.conn);
            brojRezervacija.Parameters.AddWithValue("@korisnikID", idKorisnika);
            SqlDataReader brojRezervacijaReader = brojRezervacija.ExecuteReader();
            while (brojRezervacijaReader.Read())
            {
                brojRezervacijaKorisnika = brojRezervacijaReader.GetInt32(0);
            }
            brojRezervacijaReader.Close();
            baza.closeDB();

            return brojRezervacijaKorisnika;
        }
        /// <summary>
        /// Funkcija za postavljanje određenog korisnika za administratora
        /// </summary>
        /// <param name="id"></param>
        public void PostaviKaoAdministratora(int id)
        {
            baza.closeDB();
            baza.openDB();

            SqlCommand commPostaviZaAdmina = new SqlCommand("Update [dbo].Korisnik SET [dbo].Korisnik.tipID = 1 where [dbo].Korisnik.korisnikID = @korisnikID", baza.conn);
            commPostaviZaAdmina.Parameters.AddWithValue("@korisnikID", id);
            commPostaviZaAdmina.ExecuteNonQuery();

            baza.closeDB();
        }
        /// <summary>
        /// funkcija za brisanje prema njegovom idu
        /// </summary>
        /// <param name="id"></param>
        public void ObrisiKorisnika(int id)
        {
            baza.closeDB();
            baza.openDB();

            SqlCommand obrisiKorisnika = new SqlCommand("Delete from [dbo].Korisnik where [dbo].Korisnik.korisnikID = @korisnikID", baza.conn);
            obrisiKorisnika.Parameters.AddWithValue("@korisnikID", id);
            obrisiKorisnika.ExecuteNonQuery();

            SqlCommand obrisiNjegoveRezervacije = new SqlCommand("delete from [dbo].Rezervacija where [dbo].Rezervacija.korisnikID = @korisnikID", baza.conn);
            obrisiNjegoveRezervacije.Parameters.AddWithValue("@korisnikID", id);
            obrisiNjegoveRezervacije.ExecuteNonQuery();

            baza.closeDB();
        }
        /// <summary>
        /// Metoda koja dohvaća ID korisnika i nadimak, koristi se u kontrolama PopisRezervacija
        /// i u NovaRezervacija
        /// </summary>
        /// <returns></returns>
        public DataTable DohvatiKorimeID()
        {
            baza.closeDB();
            baza.openDB();

            SqlDataAdapter daDohvatiKorisnika = new SqlDataAdapter("select [dbo].Korisnik.korisnikID, [dbo].Korisnik.nadimak from [dbo].Korisnik", baza.conn);
            DataSet dsKorisnici = new DataSet();
            daDohvatiKorisnika.Fill(dsKorisnici, "Korisnici_table");
            
            baza.closeDB();

            return dsKorisnici.Tables["Korisnici_table"];
        }
        /// <summary>
        /// Funkcija koja vraca sve podatke o odabranom korisniku prema ID-u
        /// prikazuje se u kontroli Korisnici i NovaRezervacija
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable DohvatiKorisnikFull(int id)
        {
            baza.closeDB();
            baza.openDB();

            SqlDataAdapter dohvatiKorisnikPodatkeCommand = new SqlDataAdapter("select [dbo].Korisnik.*, [dbo].TipKorisnika.naziv from [dbo].Korisnik join [dbo].TipKorisnika on [dbo].Korisnik.tipID = [dbo].TipKorisnika.tipID where [dbo].Korisnik.korisnikID = @korisnikID", baza.conn);
            dohvatiKorisnikPodatkeCommand.SelectCommand.Parameters.AddWithValue("@korisnikID", id);
            DataSet dsKorisnikFull = new DataSet();
            dohvatiKorisnikPodatkeCommand.Fill(dsKorisnikFull, "KorisnikFull");

            

            baza.closeDB();

                return dsKorisnikFull.Tables["KorisnikFull"];
        }

        /// <summary>
        /// Metoda koja dohvaća nadimak prema ID-u, koristi se u kontroli NovaRezervacija
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DohvatiNadimak(int id)
        {
            string nadimak = "";
            baza.closeDB();
            baza.openDB();
            SqlCommand dohvatiNadimak = new SqlCommand("select [dbo].Korisnik.nadimak from [dbo].Korisnik where [dbo].Korisnik.korisnikID = @korisnikID", baza.conn);
            dohvatiNadimak.Parameters.AddWithValue("@korisnikID", id);
            SqlDataReader dohvatiNadimakReader = dohvatiNadimak.ExecuteReader();
            while (dohvatiNadimakReader.Read())
            {
                nadimak = dohvatiNadimakReader.GetString(0);
            }
            dohvatiNadimakReader.Close();
            dohvatiNadimak.ExecuteNonQuery();

            return nadimak;
        }
    }
}

