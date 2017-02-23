using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public class Rezervacija
    {
        DB baza = new DB();
        int automobilID, korisnikID, statusID;
        DateTime datumRezervacije, pocetakPosudbe, krajPosudbe;
        public Rezervacija( DateTime datumRezervacije, DateTime pocetakPosudbe, DateTime krajPosudbe, int automobilID, int korisnikID, int statusID)
        {
            this.automobilID = automobilID;
            this.korisnikID = korisnikID;
            this.statusID = statusID;
            this.pocetakPosudbe = pocetakPosudbe;
            this.krajPosudbe = krajPosudbe;
            this.datumRezervacije = datumRezervacije;
        }

        public void upisiNovuRezervaciju()
        {
            baza.openDB();
            List<int> listaB = new List<int>();
            SqlCommand dohvatiSveID = new SqlCommand("SELECT rezervacijaID from [dbo].[Rezervacija]", baza.conn);
            SqlDataReader dohvatiSve = dohvatiSveID.ExecuteReader();
            while (dohvatiSve.Read())
            {
                listaB.Add(dohvatiSve.GetInt32(0));
            }
            dohvatiSve.Close();

            Form1 forma = new Form1();
            int id = forma.firstAvailable(listaB);

            string naredba = "INSERT into [dbo].[Rezervacija] values (@rezervacijaID, @datumRezervacije, @pocetakPosudbe, @krajPosudbe, @automobilID, @korisnikID, @statusID)";
            SqlCommand upisiKorisnika = new SqlCommand(naredba, baza.conn);

            upisiKorisnika.Parameters.AddWithValue("@rezervacijaID", id);
            upisiKorisnika.Parameters.AddWithValue("@datumRezervacije", datumRezervacije);
            upisiKorisnika.Parameters.AddWithValue("@pocetakPosudbe", pocetakPosudbe);
            upisiKorisnika.Parameters.AddWithValue("@krajPosudbe", krajPosudbe);
            upisiKorisnika.Parameters.AddWithValue("@automobilID", automobilID);
            upisiKorisnika.Parameters.AddWithValue("@korisnikID", korisnikID);
            upisiKorisnika.Parameters.AddWithValue("@statusID", statusID);
            upisiKorisnika.ExecuteNonQuery();

            baza.closeDB(); 
        }
    }
}
