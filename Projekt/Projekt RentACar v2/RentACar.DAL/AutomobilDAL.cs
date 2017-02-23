using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApplication4;
using System.Data;

namespace RentACar.DAL
{
    public class AutomobilDAL
    {
        int aID, modID, tID, cij, sna;
        string pog, mot, op;
        DB baza = new DB();


        public AutomobilDAL()
        {

        }

        /// <summary>
        /// metoda za upisivanje novih automobila u bazu
        /// </summary>
        /// <param name="markaID"></param>
        /// <param name="modelID"></param>
        /// <param name="tipID"></param>
        /// <param name="snaga"></param>
        /// <param name="opis"></param>
        /// <param name="cijena"></param>
        public void UpisiNoviAutomobil(int modelTipID, int snaga, string opis, int cijena)
        {
            baza.closeDB();
            baza.openDB();

            string upisi = "insert into [dbo].Auto (modelTipID, snaga, opis, cijena) values (@modelTipID, @snaga, @opis, @cijena)"; //insert
            SqlCommand upisiAutomobil = new SqlCommand(upisi, baza.conn);
            upisiAutomobil.Parameters.AddWithValue("@modelTipID", modelTipID);
            upisiAutomobil.Parameters.AddWithValue("@snaga", snaga);
            upisiAutomobil.Parameters.AddWithValue("@opis", opis);
            upisiAutomobil.Parameters.AddWithValue("@cijena", cijena);
            upisiAutomobil.ExecuteNonQuery();

            baza.closeDB();
        }
        /// <summary>
        /// metoda za uređivanje postojećih automobila
        /// </summary>
        /// <param name="automobilID"></param>
        /// <param name="markaID"></param>
        /// <param name="modelID"></param>
        /// <param name="tipID"></param>
        /// <param name="pogon"></param>
        /// <param name="motor"></param>
        /// <param name="snaga"></param>
        /// <param name="opis"></param>
        /// <param name="cijena"></param>
        public void UrediAutomobil(int automobilID, int modelTipID, int snaga, string opis, int cijena)
        {
            baza.closeDB();
            baza.openDB();

            string uredi = "UPDATE [dbo].[Auto] SET [dbo].[Auto].modelTipID = @modelTipID, [dbo].[Auto].snaga = @snaga, [dbo].[Auto].opis = @opis, [dbo].[Auto].cijena = @cijena WHERE [dbo].[Auto].automobilID = @automobilID";
            SqlCommand urediAutomobil = new SqlCommand(uredi, baza.conn);
            urediAutomobil.Parameters.AddWithValue("@automobilID", automobilID);
            urediAutomobil.Parameters.AddWithValue("@modelTipID", modelTipID);
            urediAutomobil.Parameters.AddWithValue("@snaga", snaga);
            urediAutomobil.Parameters.AddWithValue("@opis", opis);
            urediAutomobil.Parameters.AddWithValue("@cijena", cijena);
            urediAutomobil.ExecuteNonQuery();

            baza.closeDB();
        }
        
       
      /// <summary>
      /// Metoda vraća podatke automobila u obliku dataseta prema prosljeđenom ID-u,
      /// koristi se u kontroli PregledajAutomobil
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
        public DataRow DohvatiAutomobilPremaID(int id)

        {
            baza.openDB();
            string dohvatiAutomobile = "select [dbo].Auto.automobilID, [dbo].MarkaAutomobila.naziv, [dbo].ModelAutomobila.naziv, [dbo].TipAutomobila.tip, [dbo].Pogon.pogon, [dbo].Motor.motor, [dbo].Auto.snaga, [dbo].Auto.opis, [dbo].Auto.cijena from [dbo].MarkaAutomobila join [dbo].ModelAutomobila on [dbo].MarkaAutomobila.markaID = [dbo].ModelAutomobila.markaID join [dbo].ModelTip on [dbo].ModelTip.modelID = [dbo].ModelAutomobila.modelID join [dbo].Auto on [dbo].Auto.modelTipID = [dbo].ModelTip.modelTipID join [dbo].TipAutomobila on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID join [dbo].Motor on [dbo].Motor.motorID = [dbo].ModelTip.motorID join [dbo].Pogon on [dbo].Pogon.pogonID = [dbo].ModelTip.pogonID where [dbo].ModelAutomobila.modelID = (select [dbo].ModelTip.modelID from [dbo].Auto join [dbo].ModelTip on [dbo].Auto.modelTipID = [dbo].ModelTip.modelTipID where [dbo].Auto.automobilID = @autoID) and [dbo].Auto.automobilID = @autoID";
            List<AutomobilDAL> listaAutoDAL = new List<AutomobilDAL>();

            SqlDataAdapter daAutomobil = new SqlDataAdapter(dohvatiAutomobile, baza.conn);
            daAutomobil.SelectCommand.Parameters.AddWithValue("@autoID", id);
            DataSet dsAutomobil = new DataSet();
            daAutomobil.Fill(dsAutomobil, "Auto_table");
            dsAutomobil.Tables["Auto_table"].Columns[0].ColumnName = "automobilID";
            dsAutomobil.Tables["Auto_table"].Columns[1].ColumnName = "marka";
            dsAutomobil.Tables["Auto_table"].Columns[2].ColumnName = "model";
            dsAutomobil.Tables["Auto_table"].Columns[3].ColumnName = "tip";
            dsAutomobil.Tables["Auto_table"].Columns[4].ColumnName = "pogon";
            dsAutomobil.Tables["Auto_table"].Columns[5].ColumnName = "motor";
            dsAutomobil.Tables["Auto_table"].Columns[6].ColumnName = "snaga";
            dsAutomobil.Tables["Auto_table"].Columns[7].ColumnName = "opis";
            dsAutomobil.Tables["Auto_table"].Columns[8].ColumnName = "cijena";
            baza.closeDB();
            return dsAutomobil.Tables["Auto_table"].Rows[0];
        }
        /// <summary>
        /// Metoda za dohvaćanje automobila prema marki odabranoj u comboBoxu
        /// </summary>
        /// <param name="Marka"></param>
        /// <returns>vraća u obliku DataTable</returns>
        public DataTable DohvatiAutomobilPremaMarki(string Marka)
        {
            baza.closeDB();
            baza.openDB();

            string dohvatiAutomobilPodatke = "select [dbo].Auto.automobilID, [dbo].MarkaAutomobila.naziv, [dbo].ModelAutomobila.naziv, [dbo].TipAutomobila.tip, [dbo].Pogon.pogon, [dbo].Motor.motor, [dbo].Auto.snaga, [dbo].Auto.opis, [dbo].Auto.cijena from [dbo].MarkaAutomobila join [dbo].ModelAutomobila on [dbo].MarkaAutomobila.markaID = [dbo].ModelAutomobila.markaID join [dbo].ModelTip on [dbo].ModelTip.modelID = [dbo].ModelAutomobila.modelID join [dbo].Auto on [dbo].Auto.modelTipID = [dbo].ModelTip.modelTipID join [dbo].TipAutomobila on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID join [dbo].Motor on [dbo].Motor.motorID = [dbo].ModelTip.motorID join [dbo].Pogon on [dbo].Pogon.pogonID = [dbo].ModelTip.pogonID where [dbo].MarkaAutomobila.naziv = @markaNaziv";
            List<AutomobilDAL> listaAutoDAL = new List<AutomobilDAL>();

            SqlDataAdapter daAutomobil = new SqlDataAdapter(dohvatiAutomobilPodatke, baza.conn);
            daAutomobil.SelectCommand.Parameters.AddWithValue("@markaNaziv", Marka);
            DataSet dsAutomobil = new DataSet();
            daAutomobil.Fill(dsAutomobil, "Auto_table");
            dsAutomobil.Tables["Auto_table"].Columns[0].ColumnName = "automobilID";
            dsAutomobil.Tables["Auto_table"].Columns[1].ColumnName = "marka";
            dsAutomobil.Tables["Auto_table"].Columns[2].ColumnName = "model";
            dsAutomobil.Tables["Auto_table"].Columns[3].ColumnName = "tip";
            dsAutomobil.Tables["Auto_table"].Columns[4].ColumnName = "pogon";
            dsAutomobil.Tables["Auto_table"].Columns[5].ColumnName = "motor";
            dsAutomobil.Tables["Auto_table"].Columns[6].ColumnName = "snaga";
            dsAutomobil.Tables["Auto_table"].Columns[7].ColumnName = "opis";
            dsAutomobil.Tables["Auto_table"].Columns[8].ColumnName = "cijena";
            baza.closeDB();
            return dsAutomobil.Tables["Auto_table"];
        }
        /// <summary>
        /// Vraća datatable u kojem su automobili u kontroli Automobili
        /// </summary>
        /// <returns>rezultat u obliku datatable</returns>
        public DataTable DohvatiAutomobile()
        {
            baza.closeDB();
            baza.openDB();

            string dohvatiAutomobile = "select [dbo].Auto.automobilID, [dbo].MarkaAutomobila.naziv, [dbo].ModelAutomobila.naziv, [dbo].TipAutomobila.tip, [dbo].Auto.snaga, [dbo].Auto.opis, [dbo].Auto.cijena from [dbo].MarkaAutomobila join [dbo].ModelAutomobila on [dbo].MarkaAutomobila.markaID = [dbo].ModelAutomobila.markaID join [dbo].ModelTip on [dbo].ModelTip.modelID = [dbo].ModelAutomobila.modelID join [dbo].Auto on [dbo].Auto.modelTipID = [dbo].ModelTip.modelTipID join [dbo].TipAutomobila on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID";
            SqlDataAdapter daAutomobili = new SqlDataAdapter(dohvatiAutomobile, baza.conn);
            DataSet dsAutomobili = new DataSet();
            daAutomobili.Fill(dsAutomobili, "Auti");

            baza.closeDB();

            return dsAutomobili.Tables["Auti"];
        }
        /// <summary>
        /// Metoda za dohvaćanje ID-a, koristi se u kontroli DodajAutomobil, za uređivanje
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataRow DohvatiAutomobilIzID(int id)
        {
            baza.closeDB();
            baza.openDB();

            string dohvatiAutomobile = "select [dbo].Auto.automobilID, [dbo].MarkaAutomobila.markaID, [dbo].ModelAutomobila.modelID, [dbo].TipAutomobila.tipID, [dbo].Pogon.pogon, [dbo].Motor.motor, [dbo].Auto.snaga, [dbo].Auto.opis, [dbo].Auto.cijena from [dbo].MarkaAutomobila join [dbo].ModelAutomobila on [dbo].MarkaAutomobila.markaID = [dbo].ModelAutomobila.markaID join [dbo].ModelTip on [dbo].ModelTip.modelID = [dbo].ModelAutomobila.modelID join [dbo].Auto on [dbo].Auto.modelTipID = [dbo].ModelTip.modelTipID join [dbo].TipAutomobila on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID join [dbo].Pogon on [dbo].Pogon.pogonID = [dbo].ModelTip.pogonID join [dbo].Motor on [dbo].Motor.motorID = [dbo].ModelTip.motorID where [dbo].Auto.automobilID = @autoID";
            SqlDataAdapter daAutomobili = new SqlDataAdapter(dohvatiAutomobile, baza.conn);
            daAutomobili.SelectCommand.Parameters.AddWithValue("@autoID", id);
            DataSet dsAutomobili = new DataSet();
            daAutomobili.Fill(dsAutomobili, "Auti");

            baza.closeDB();

            return dsAutomobili.Tables["Auti"].Rows[0];
        }
        /// <summary>
        /// metoda za dohvacanje marki za comboBox
        /// </summary>
        /// <returns>Vraća listu marki</returns>
        public List<string> DohvatiMarke()
        {
            baza.closeDB();
            List<string> listaMarka = new List<string>();
            baza.openDB();
            SqlCommand dohvatiMarkuAutomobila = new SqlCommand("SELECT naziv from [dbo].[MarkaAutomobila]", baza.conn);
            SqlDataReader reader1 = dohvatiMarkuAutomobila.ExecuteReader();
            while (reader1.Read())
            {
                listaMarka.Add(reader1.GetString(0));
            }
            reader1.Close();

            baza.closeDB();
            return listaMarka;
        }
        /// <summary>
        /// Metoda za dohvaćanje tipova automobila
        /// </summary>
        /// <returns></returns>
        public List<string> DohvatiTipove() 
        {
            baza.closeDB();
            List<string> listaTipova = new List<string>();
            baza.openDB();
            SqlCommand dohvatiTipoveAutomobila = new SqlCommand("SELECT tip from [dbo].[TipAutomobila]", baza.conn);
            SqlDataReader reader1 = dohvatiTipoveAutomobila.ExecuteReader();
            while (reader1.Read())
            {
                listaTipova.Add(reader1.GetString(0));
            }
            reader1.Close();
            baza.closeDB();
            return listaTipova;
        }
        /// <summary>
        /// metoda za brisanje odabranog automobila iz dataGridViewa
        /// </summary>
        /// <param name="id">prima id odabranog automobila(autombila za brisanje)</param>
        public void ObrisiAutomobil(int id)
        {
            baza.closeDB();
            baza.openDB();


            SqlCommand izbrisiOdabraniAutomobil = new SqlCommand("DELETE from [dbo].[Auto] where [dbo].[Auto].automobilID = @id", baza.conn);
            izbrisiOdabraniAutomobil.Parameters.AddWithValue("@id", id);
            izbrisiOdabraniAutomobil.ExecuteNonQuery();


            baza.closeDB();
        }
        /// <summary>
        /// metoda za dohvacanje naziva marke, naziva modela, i naziva tipa prema odabranom automobilID
        /// </summary>
        /// <param name="id">priimljeni automobilID</param>
        /// <returns>vraca podatke u obliku dataRow-a</returns>
        public DataRow DohvatiMarkuModelTip(int id)
        {
            baza.openDB();

            string dohvatiMarkuModelTip = "Select [dbo].MarkaAutomobila.naziv, [dbo].ModelAutomobila.naziv, [dbo].TipAutomobila.tip from [dbo].Automobil join [dbo].MarkaAutomobila on [dbo].Automobil.markaID = [dbo].MarkaAutomobila.markaID join [dbo].ModelAutomobila on [dbo].Automobil.modelID = [dbo].ModelAutomobila.modelID join [dbo].TipAutomobila on [dbo].Automobil.tipID = [dbo].TipAutomobila.tipID WHERE [dbo].Automobil.automobilID = @autoID";

            SqlDataAdapter daDohvatiMarkuModelTip = new SqlDataAdapter(dohvatiMarkuModelTip, baza.conn);
            daDohvatiMarkuModelTip.SelectCommand.Parameters.AddWithValue("@autoID", id);
            DataSet dsDohvatiMarkuModelTip = new DataSet();
            daDohvatiMarkuModelTip.Fill(dsDohvatiMarkuModelTip, "MarkaModelTip_table");

            baza.closeDB();
            return dsDohvatiMarkuModelTip.Tables["MarkaModelTip_table"].Rows[0];
        }
        /// <summary>
        /// metoda za dohvacanje svih rezervacija za odabrani automobil
        /// </summary>
        /// <param name="id"></param>
        /// <returns>vraca podatke u obliku datatable</returns>
        public DataTable DohvatiDatume(int id)
        {
            baza.openDB();

            SqlDataAdapter daDohvatiRezerviraneDatume = new SqlDataAdapter("select [dbo].[Rezervacija].pocetakPosudbe, [dbo].[Rezervacija].krajPosudbe from [dbo].[Rezervacija] where [dbo].Rezervacija.automobilID = @automobilID", baza.conn);
            daDohvatiRezerviraneDatume.SelectCommand.Parameters.AddWithValue("@automobilID", id);
            DataSet dsRezerviraniDatumi = new DataSet();
            daDohvatiRezerviraneDatume.Fill(dsRezerviraniDatumi, "RezerviraniDatumi");

            baza.closeDB();

            return dsRezerviraniDatumi.Tables["RezerviraniDatumi"];
        }
        /// <summary>
        /// dohvaca podatke o automobilu, ukljucujuci markaAutomobila.naziv, modelAutomobila.naziv, tipAutomobila.tip
        /// koristi se u kontroli PopisRezervacije
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable DohvatiAutomobilFull(int id)
        {
            baza.closeDB();
            baza.openDB();


            SqlDataAdapter dohvatiAutomobilPodatke = new SqlDataAdapter("select [dbo].Auto.*, [dbo].MarkaAutomobila.naziv, [dbo].ModelAutomobila.naziv, [dbo].TipAutomobila.tip from [dbo].MarkaAutomobila join [dbo].ModelAutomobila on [dbo].MarkaAutomobila.markaID = [dbo].ModelAutomobila.markaID join [dbo].ModelTip on [dbo].ModelTip.modelID = [dbo].ModelAutomobila.modelID join [dbo].Auto on [dbo].Auto.modelTipID =[dbo].ModelTip.modelTipID join [dbo].TipAutomobila on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID where automobilID = @automobilID", baza.conn);
            dohvatiAutomobilPodatke.SelectCommand.Parameters.AddWithValue("@automobilID", id);
            DataSet dsAutomobilFull = new DataSet();
            dohvatiAutomobilPodatke.Fill(dsAutomobilFull, "AutomobilFull");

            baza.closeDB();
            return dsAutomobilFull.Tables["AutomobilFull"];            
        }
        /// <summary>
        /// dohvaca sve podatke o marki za comboBox
        /// </summary>
        /// <returns>Vraca u obliku datatable</returns>
        public List<MarkaAutomobila> DohvatiMarkeFull()
        {

            baza.closeDB();
            baza.openDB();

            MarkaAutomobila markaAutomobila;
            List<MarkaAutomobila> listaMarki = new List<MarkaAutomobila>();
            SqlCommand dohvatiMarkePotpuno = new SqlCommand("select [dbo].MarkaAutomobila.markaID, [dbo].MarkaAutomobila.naziv from [dbo].MarkaAutomobila", baza.conn);
            SqlDataReader datareader = dohvatiMarkePotpuno.ExecuteReader();
            while (datareader.Read()) 
            {

                markaAutomobila = new MarkaAutomobila();
                markaAutomobila.MarkaID = datareader.GetInt32(0);
                markaAutomobila.Naziv = datareader.GetString(1);
                listaMarki.Add(markaAutomobila);
            }
            datareader.Close();



            baza.closeDB();
            return listaMarki;
        }
        /// <summary>
        /// Metoda koja dohvaća naiv i ID modela automobila prema ID-u marke automobila
        /// </summary>
        /// <param name="idMarke"></param>
        /// <returns></returns>
        public List<ModelAutomobila> DohvatiModelFull(int idMarke)
        {
            baza.closeDB();
            baza.openDB();
            
            List<ModelAutomobila> listaModela = new List<ModelAutomobila>();
            SqlCommand dohvatiModele = new SqlCommand("select [dbo].ModelAutomobila.modelID, [dbo].ModelAutomobila.naziv from [dbo].ModelAutomobila where [dbo].ModelAutomobila.markaID = @markaID", baza.conn);
            dohvatiModele.Parameters.AddWithValue("@markaID", idMarke);
            SqlDataReader dr = dohvatiModele.ExecuteReader();
            while (dr.Read())
            {
                ModelAutomobila modelAutomobila = new ModelAutomobila();
                modelAutomobila.ModelID = dr.GetInt32(0);
                modelAutomobila.Naziv = dr.GetString(1);
                listaModela.Add(modelAutomobila);

            }

            dr.Close();
            

            baza.closeDB();
            return listaModela;
        }
        /// <summary>
        /// Metoda koja dohvaća ID i naziv tipa automobila prema ID-u modela automobila
        /// </summary>
        /// <param name="idModela"></param>
        /// <returns></returns>
        public List<TipAutomobila> DohvatiTip(int idModela)
        {
            baza.closeDB();
            baza.openDB();
            List<TipAutomobila> listaTipova = new List<TipAutomobila>();
            SqlCommand dohvatiTip = new SqlCommand("select [dbo].TipAutomobila.tipID, [dbo].TipAutomobila.tip from [dbo].TipAutomobila join [dbo].ModelTip on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID join [dbo].ModelAutomobila on [dbo].ModelAutomobila.modelID = [dbo].ModelTip.modelID where [dbo].ModelAutomobila.modelID = @modelID", baza.conn);
            dohvatiTip.Parameters.AddWithValue("@modelID", idModela);
            SqlDataReader dr = dohvatiTip.ExecuteReader();
            while (dr.Read())
            {
                TipAutomobila tip = new TipAutomobila();
                tip.Tip = dr.GetString(1);
                tip.TipID = dr.GetInt32(0);
                listaTipova.Add(tip);
            }

            baza.closeDB();
            return listaTipova;

        }
        /// <summary>
        /// Metoda koja dohvaća ModelTipID prema ID-u modela i ID-u tipa
        /// </summary>
        /// <param name="modelID"></param>
        /// <param name="tipID"></param>
        /// <returns></returns>
        public int DohvatiModelTipID(int  modelID, int tipID)
        {
            int modelTipID = 0;
            baza.closeDB();
            baza.openDB();
            SqlCommand dohvatiModelTipID = new SqlCommand("select [dbo].ModelTip.modelTipID from [dbo].ModelTip join [dbo].ModelAutomobila on [dbo].ModelTip.modelID = [dbo].ModelAutomobila.modelID join [dbo].TipAutomobila on [dbo].TipAutomobila.tipID = [dbo].ModelTip.tipID where [dbo].ModelAutomobila.modelID = @modelID and [dbo].TipAutomobila.tipID = @tipID", baza.conn);
            dohvatiModelTipID.Parameters.AddWithValue("@modelID", modelID);
            dohvatiModelTipID.Parameters.AddWithValue("@tipID", tipID);
            SqlDataReader reader = dohvatiModelTipID.ExecuteReader();
            while (reader.Read())
            {
                modelTipID = reader.GetInt32(0);
            }
            reader.Close();

            baza.closeDB();

            return modelTipID;
        }
        /// <summary>
        /// Metoda koja dohvaća Pogon i Motor prema ModelTipID-u
        /// </summary>
        /// <param name="modelTipID"></param>
        /// <returns></returns>
        public DataTable DohvatiPogonMotor(int modelTipID)
        {
            baza.closeDB();
            baza.openDB();
            SqlDataAdapter dohvatiPogonMotor = new SqlDataAdapter("select [dbo].Pogon.pogon, [dbo].Motor.motor from [dbo].Pogon join [dbo].ModelTip on [dbo].Pogon.pogonID = [dbo].ModelTip.pogonID join [dbo].Motor on [dbo].Motor.motorID = [dbo].ModelTip.motorID where [dbo].ModelTip.modelTipID = @modelTipID", baza.conn);
            dohvatiPogonMotor.SelectCommand.Parameters.AddWithValue("@modelTipID", modelTipID);
            DataSet ds = new DataSet();
            dohvatiPogonMotor.Fill(ds, "PogonMotor");
            baza.closeDB();
            return ds.Tables["PogonMotor"];

        }
    }
}
