using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    class Automobil
    {
        int automobilID, markaID, modelID, tipID, snaga, cijena;
        string pogon, motor, opis;

        DB baza = new DB();

        public Automobil(int automobilID, int markaID, int modelID, int tipID, string pogon, string motor, int snaga, string opis, int cijena)
        {
            this.automobilID = automobilID;
            this.markaID = markaID;
            this.modelID = modelID;
            this.tipID = tipID;
            this.pogon = pogon;
            this.motor = motor;
            this.snaga = snaga;
            this.opis = opis;
            this.cijena = cijena;
        }
        public void upisiNoviAutomobil()
        {
            baza.openDB();

            string upisi = "INSERT into [dbo].[Automobil](automobilID, markaID, modelID, tipID, pogon, motor, snaga, opis, cijena) VALUES(@automobilID, @markaID, @modelID, @tipID, @pogon, @motor, @snaga, @opis, @cijena)"; //insert
            SqlCommand upisiAutomobil = new SqlCommand(upisi, baza.conn);
            upisiAutomobil.Parameters.AddWithValue("@automobilID", automobilID);
            upisiAutomobil.Parameters.AddWithValue("@markaID", markaID);
            upisiAutomobil.Parameters.AddWithValue("@modelID", modelID);
            upisiAutomobil.Parameters.AddWithValue("@tipID", tipID);
            upisiAutomobil.Parameters.AddWithValue("@pogon", pogon);
            upisiAutomobil.Parameters.AddWithValue("@motor", motor);
            upisiAutomobil.Parameters.AddWithValue("@snaga", snaga);
            upisiAutomobil.Parameters.AddWithValue("@opis", opis);
            upisiAutomobil.Parameters.AddWithValue("@cijena", cijena);
            upisiAutomobil.ExecuteNonQuery();

            baza.closeDB();
        }
        public void urediAutomobil()
        {
            baza.openDB();

            string uredi = "UPDATE [dbo].[Automobil] SET [dbo].[Automobil].markaID = @markaID, [dbo].[Automobil].modelID = @modelID, [dbo].[Automobil].tipID = @tipID, [dbo].[Automobil].pogon = @pogon, [dbo].[Automobil].motor = @motor, [dbo].[Automobil].snaga = @snaga, [dbo].[Automobil].opis = @opis, [dbo].[Automobil].cijena = @cijena WHERE [dbo].[Automobil].automobilID = @autoID";
            SqlCommand urediAutomobil = new SqlCommand(uredi, baza.conn);
            urediAutomobil.Parameters.AddWithValue("@autoID", automobilID);
            urediAutomobil.Parameters.AddWithValue("@markaID", markaID);
            urediAutomobil.Parameters.AddWithValue("@modelID", modelID);
            urediAutomobil.Parameters.AddWithValue("@tipID", tipID);
            urediAutomobil.Parameters.AddWithValue("@pogon", pogon);
            urediAutomobil.Parameters.AddWithValue("@motor", motor);
            urediAutomobil.Parameters.AddWithValue("@snaga", snaga);
            urediAutomobil.Parameters.AddWithValue("@opis", opis);
            urediAutomobil.Parameters.AddWithValue("@cijena", cijena);
            urediAutomobil.ExecuteNonQuery();

            baza.closeDB();
        }

    }
}
