using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    class Korisnik
    {
        string Ime, Prezime, Email, Korime, Lozinka, Adresa, Telefon;
        DB baza = new DB();

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

        public void upisiNovogKorisnika() {
            baza.openDB();

            List<int> listaB = new List<int>();
            SqlCommand dohvatiSveID = new SqlCommand("SELECT korisnikID from [dbo].[Korisnik]", baza.conn);
            SqlDataReader dohvatiSve = dohvatiSveID.ExecuteReader();
            while (dohvatiSve.Read())
            {
                listaB.Add(dohvatiSve.GetInt32(0));
            }
            dohvatiSve.Close();           

            Form1 forma = new Form1();
            int id = forma.firstAvailable(listaB); //funkcija koja pronalazi prvi u nizu slobodni ID

            
            string naredba = "INSERT into [dbo].[Korisnik] values (@KorisnikID, @Ime, @Prezime, @Korime, @Lozinka, @Email, @Telefon, @Adresa, @TipID)";
            SqlCommand upisiKorisnika = new SqlCommand(naredba, baza.conn); 

            upisiKorisnika.Parameters.AddWithValue("@Ime", Ime);
            upisiKorisnika.Parameters.AddWithValue("@Prezime", Prezime);
            upisiKorisnika.Parameters.AddWithValue("@Email", Email);
            upisiKorisnika.Parameters.AddWithValue("@Korime", Korime);
            upisiKorisnika.Parameters.AddWithValue("@Lozinka", Lozinka);
            upisiKorisnika.Parameters.AddWithValue("@Telefon", Telefon);
            upisiKorisnika.Parameters.AddWithValue("@Adresa", Adresa);
            upisiKorisnika.Parameters.AddWithValue("@KorisnikID", id);
            upisiKorisnika.Parameters.AddWithValue("@TipID", 2);
            upisiKorisnika.ExecuteNonQuery(); 

            baza.closeDB(); 
        }
        
        
    }
}
