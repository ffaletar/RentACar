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
    public class RezervacijaDAL
    {
        DB baza = new DB();
        /// <summary>
        /// funkcija za upisivanje nove rezervacije
        /// </summary>
        /// <param name="datumRezervacije"></param>
        /// <param name="pocetakPosudbe"></param>
        /// <param name="krajPosudbe"></param>
        /// <param name="automobilID"></param>
        /// <param name="korisnikID"></param>
        /// <param name="statusID"></param>
        public void upisiNovuRezervaciju(DateTime datumRezervacije, DateTime pocetakPosudbe, DateTime krajPosudbe, int automobilID, int korisnikID, int statusID)
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


            string naredba = "INSERT into [dbo].[Rezervacija] values (@datumRezervacije, @pocetakPosudbe, @krajPosudbe, @automobilID, @korisnikID, @statusID)";
            SqlCommand upisiKorisnika = new SqlCommand(naredba, baza.conn);

            upisiKorisnika.Parameters.AddWithValue("@datumRezervacije", datumRezervacije);
            upisiKorisnika.Parameters.AddWithValue("@pocetakPosudbe", pocetakPosudbe);
            upisiKorisnika.Parameters.AddWithValue("@krajPosudbe", krajPosudbe);
            upisiKorisnika.Parameters.AddWithValue("@automobilID", automobilID);
            upisiKorisnika.Parameters.AddWithValue("@korisnikID", korisnikID);
            upisiKorisnika.Parameters.AddWithValue("@statusID", statusID);
            upisiKorisnika.ExecuteNonQuery();

            baza.closeDB();
        }
        /// <summary>
        /// funkcija koja psotavlja status odabrane rezervacije
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        public void PostaviStatus(int id, int status)
        {
            baza.closeDB();
            baza.openDB();
            SqlCommand postaviStatusIskorištena = new SqlCommand("Update [dbo].Rezervacija set [dbo].Rezervacija.statusID = @status where [dbo].Rezervacija.rezervacijaID = @rezervacijaID", baza.conn);
            postaviStatusIskorištena.Parameters.AddWithValue("@rezervacijaID", id);
            postaviStatusIskorištena.Parameters.AddWithValue("@status", status);
            postaviStatusIskorištena.ExecuteNonQuery();


            baza.closeDB();
        }
        /// <summary>
        /// dohvaca sve moje rezervacije
        /// </summary>
        /// <param name="id"></param>
        /// <returns>u obliku datatable</returns>
        public DataTable DohvatiMojeRezervacije(int id)
        {
            baza.closeDB();
            baza.openDB();

            string dohvatiMojeRezervacije = "select [dbo].Rezervacija.rezervacijaID, [dbo].Rezervacija.datumRezervacije, [dbo].Rezervacija.pocetakPosudbe, [dbo].Rezervacija.krajPosudbe, [dbo].MarkaAutomobila.naziv, [dbo].ModelAutomobila.naziv, [dbo].TipAutomobila.tip, [dbo].Status.naziv from [dbo].MarkaAutomobila join [dbo].ModelAutomobila on [dbo].MarkaAutomobila.markaID = [dbo].ModelAutomobila.markaID join [dbo].ModelTip on [dbo].ModelTip.modelID = [dbo].ModelAutomobila.modelID join [dbo].Auto on [dbo].Auto.modelTipID = [dbo].ModelTip.modelTipID join [dbo].TipAutomobila on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID join [dbo].Rezervacija on [dbo].Rezervacija.automobilID = [dbo].Auto.automobilID join [dbo].Status on [dbo].Rezervacija.statusID = [dbo].Status.statusID  where [dbo].Rezervacija.korisnikID = @korisnikID";
            SqlDataAdapter daMojeRezervacije = new SqlDataAdapter(dohvatiMojeRezervacije, baza.conn);
            daMojeRezervacije.SelectCommand.Parameters.AddWithValue("@korisnikID", id);
            DataSet dsMojeRezervacije = new DataSet();
            daMojeRezervacije.Fill(dsMojeRezervacije, "MojeRezervacije_table");
            dsMojeRezervacije.Tables["MojeRezervacije_table"].Columns[0].ColumnName = "rezervacijaID";
            dsMojeRezervacije.Tables["MojeRezervacije_table"].Columns[1].ColumnName = "datumRezervacije";
            dsMojeRezervacije.Tables["MojeRezervacije_table"].Columns[2].ColumnName = "pocetakPosudbe";
            dsMojeRezervacije.Tables["MojeRezervacije_table"].Columns[3].ColumnName = "krajPosudbe";
            dsMojeRezervacije.Tables["MojeRezervacije_table"].Columns[4].ColumnName = "marka";
            dsMojeRezervacije.Tables["MojeRezervacije_table"].Columns[5].ColumnName = "model";
            dsMojeRezervacije.Tables["MojeRezervacije_table"].Columns[6].ColumnName = "tip";
            dsMojeRezervacije.Tables["MojeRezervacije_table"].Columns[7].ColumnName = "status";

            baza.closeDB();
            return dsMojeRezervacije.Tables["MojeRezervacije_table"];
        }
        /// <summary>
        /// Metoda koja postavlja rezervaciju kao neaktivnu
        /// </summary>
        /// <param name="id"></param>
        public void DeaktivirajOdabranuRezervaciju(int id)
        {
            baza.closeDB();
            baza.openDB();

            string deaktivirajOdabranuRezervaciju = "UPDATE [dbo].Rezervacija SET [dbo].Rezervacija.statusID = 4 WHERE [dbo].Rezervacija.rezervacijaID = @id";
            SqlCommand commUrediRezervaciju = new SqlCommand(deaktivirajOdabranuRezervaciju, baza.conn);
            commUrediRezervaciju.Parameters.AddWithValue("@id", id);
            commUrediRezervaciju.ExecuteNonQuery();

            baza.closeDB();
        }
        /// <summary>
        /// dohvaca cijeli popis rezervacija za kontrolu PopisRezervacija
        /// </summary>
        /// <returns></returns>
        public DataTable DohvatiPopisRezervacija()
        {
            baza.closeDB();
            baza.openDB();

            string dohvatiPopisRezervacija = "select [dbo].Rezervacija.rezervacijaID, [dbo].Rezervacija.datumRezervacije, [dbo].[MarkaAutomobila].naziv, [dbo].ModelAutomobila.naziv, [dbo].TipAutomobila.tip from [dbo].MarkaAutomobila join [dbo].ModelAutomobila on [dbo].MarkaAutomobila.markaID = [dbo].ModelAutomobila.markaID join [dbo].ModelTip on [dbo].ModelTip.modelID = [dbo].ModelAutomobila.modelID join [dbo].Auto on [dbo].Auto.modelTipID = [dbo].ModelTip.modelTipID join [dbo].TipAutomobila on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID join [dbo].Rezervacija on [dbo].Rezervacija.automobilID = [dbo].Auto.automobilID";
            SqlDataAdapter daPopisRezervacija = new SqlDataAdapter(dohvatiPopisRezervacija, baza.conn);
            DataSet dsPopisRezervacija = new DataSet();
            daPopisRezervacija.Fill(dsPopisRezervacija, "PopisRezervacija_table");

            baza.closeDB();

            return dsPopisRezervacija.Tables["PopisRezervacija_table"];            
        }
        /// <summary>
        /// Metoda koja dohvaća popis rezervacija prema ID-u korisnika odabranog u comboBoxu
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable DohvatiPopisRezervacijaPremaID(int id)
        {
            baza.closeDB();
            baza.openDB();

            string dohvatiPopisRezervacija = "select [dbo].Rezervacija.rezervacijaID, [dbo].Rezervacija.datumRezervacije, [dbo].[MarkaAutomobila].naziv, [dbo].ModelAutomobila.naziv, [dbo].TipAutomobila.tip from [dbo].MarkaAutomobila join [dbo].ModelAutomobila on [dbo].MarkaAutomobila.markaID = [dbo].ModelAutomobila.markaID join [dbo].ModelTip on [dbo].ModelTip.modelID = [dbo].ModelAutomobila.modelID join [dbo].Auto on [dbo].Auto.modelTipID = [dbo].ModelTip.modelTipID join [dbo].TipAutomobila on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID join [dbo].Rezervacija on [dbo].Rezervacija.automobilID = [dbo].Auto.automobilID where [dbo].Rezervacija.korisnikID = @korisnikID";
            SqlDataAdapter daPopisRezervacija = new SqlDataAdapter(dohvatiPopisRezervacija, baza.conn);
            daPopisRezervacija.SelectCommand.Parameters.AddWithValue("@korisnikID", id);
            DataSet dsPopisRezervacija = new DataSet();
            daPopisRezervacija.Fill(dsPopisRezervacija, "PopisRezervacija_table");

            baza.closeDB();

            return dsPopisRezervacija.Tables["PopisRezervacija_table"];      
        }
        /// <summary>
        /// Metoda koja dohvaća sve podatke o rezervaciji prema ID-u rezervacije,
        /// koristi se u kontroli PopisRezervacije
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable PopuniRezervaciju(int id)
        {
            baza.closeDB();
            baza.openDB();

            SqlDataAdapter popuniRezervacijaFull = new SqlDataAdapter("Select [dbo].[Rezervacija].*, [dbo].[Status].naziv from [dbo].[Rezervacija] join [dbo].[Status] on [dbo].[Rezervacija].statusID = [dbo].[Status].statusID where [dbo].[Rezervacija].rezervacijaID = @rezervacijaID", baza.conn);
            popuniRezervacijaFull.SelectCommand.Parameters.AddWithValue("@rezervacijaID", id);
            DataSet dsRezervacijaFull = new DataSet();
            popuniRezervacijaFull.Fill(dsRezervacijaFull, "RezervacijaFull");

            return dsRezervacijaFull.Tables["RezervacijaFull"];
        }
        /// <summary>
        /// Metoda koja provjerava ima li auto rezervacije kako bi se auto mogao obrisati
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool AutoImaRezervacije(int id) 
        {
            bool imaRezervacije = true;
            int rezID = -1;
            baza.closeDB();
            baza.openDB();

            SqlCommand provjeriRezervacije = new SqlCommand("select [dbo].Rezervacija.rezervacijaID from [dbo].Rezervacija where [dbo].Rezervacija.automobilID = @autoID", baza.conn);
            provjeriRezervacije.Parameters.AddWithValue("@autoID", id);
            SqlDataReader dr = provjeriRezervacije.ExecuteReader();
            while (dr.Read())
            {
                rezID = dr.GetInt32(0);
            }
            dr.Close();

            if (rezID == -1)
            {
                imaRezervacije = false;
            }
            else
            {
                imaRezervacije = true;  
            }
            return imaRezervacije;
        }
      

    }
}
