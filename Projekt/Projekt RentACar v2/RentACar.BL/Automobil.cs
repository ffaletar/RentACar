using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RentACar.DAL;
using System.Data;
using RentACar.BL;

namespace WindowsFormsApplication4
{
    public class Automobil
    {
        int automobilID, modelTipID, snaga, cijena;
        string opis;

        public Automobil()
        {

        }      

        public Automobil(int automobilID, int modelTipID, int snaga, string opis, int cijena)
        {
            this.automobilID = automobilID;
            this.modelTipID = modelTipID;
            this.snaga = snaga;
            this.opis = opis;
            this.cijena = cijena;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiAutomobilPremaID iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataRow DohvatiAutomobilPremaID(int id)
        {
            AutomobilDAL autoDAL = new AutomobilDAL();
            DataRow rowAutoDAL = autoDAL.DohvatiAutomobilPremaID(id);
            
            return rowAutoDAL;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiAutomobilPremaMarki iz DAL sloja
        /// </summary>
        /// <param name="marka"></param>
        /// <returns></returns>
        public DataTable DohvatiAutomobilPremaMarki(string marka)
        {
            AutomobilDAL autoDAL = new AutomobilDAL();
            DataTable rowAutoDAL = autoDAL.DohvatiAutomobilPremaMarki(marka);

            return rowAutoDAL;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode UpisiNoviAutomobil iz DAL sloja
        /// </summary>
        /// <param name="modelTipID"></param>
        /// <param name="snaga"></param>
        /// <param name="opis"></param>
        /// <param name="cijena"></param>
        public void UpisiNoviAutomobil(int modelTipID, int snaga, string opis, int cijena)
        {
            AutomobilDAL automobiliDal = new AutomobilDAL();
            automobiliDal.UpisiNoviAutomobil(modelTipID,  snaga, opis, cijena);
        }
       /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode UrediAutomobil iz DAL sloja
       /// </summary>
        public void urediAutomobil()
        {
            AutomobilDAL automobiliDal = new AutomobilDAL();
            automobiliDal.UrediAutomobil(this.automobilID, this.modelTipID,  this.snaga, this.opis, this.cijena);
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiAutomobile iz DAL sloja
        /// </summary>
        /// <returns></returns>
        public DataTable DohvatiAutomobile()
        {
            AutomobilDAL automobilDAL = new AutomobilDAL();
            DataTable dt = automobilDAL.DohvatiAutomobile();

            return dt;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiAutomobilIzID iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataRow DohvatiAutomobilaIzID(int id)
        {
            AutomobilDAL autoDAL = new AutomobilDAL();
            DataRow dr = autoDAL.DohvatiAutomobilIzID(id);
            return dr;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiMarke iz DAL sloja
        /// </summary>
        /// <returns></returns>
        public List<string> DohvatiMarke()
        {
            AutomobilDAL automobilDAL = new AutomobilDAL();
            List<string> listaMarki = automobilDAL.DohvatiMarke();

            listaMarki.Insert(0, ""); //stavi na prvo mjesto liste prazan string

            return listaMarki;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode ObrisiAutomobil iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        public void ObrisiAutomobil(int id)
        {
            AutomobilDAL autoDAL = new AutomobilDAL();
            autoDAL.ObrisiAutomobil(id);
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiMarkuModelTip iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataRow DohvatiMarkuModelTip(int id)
        {
            AutomobilDAL autoDAL = new AutomobilDAL();
            
            DataRow rowMarkaModelTip = autoDAL.DohvatiMarkuModelTip(id);

            return rowMarkaModelTip;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiDatume iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable DohvatiDatume(int id)
        {
            AutomobilDAL autoDAL = new AutomobilDAL();
            DataTable dtDatumi = autoDAL.DohvatiDatume(id);

            return dtDatumi;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiAutomobilFull iz DAL sloja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable DohvatiAutomobilFull(int id)
        {
            AutomobilDAL autoDAL = new AutomobilDAL();
            DataTable dtAutomobilFull = autoDAL.DohvatiAutomobilFull(id);

            return dtAutomobilFull;
        }
        AutomobilDAL autoDAL = new AutomobilDAL();
        MarkaAutomobila markaDAL = new MarkaAutomobila();
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiMarkeFull iz DAL sloja
        /// </summary>
        /// <returns></returns>
        public List<MarkaAutomobilaBL> DohvatiMarkeFull()
        {
            List<MarkaAutomobilaBL> returnme = new List<MarkaAutomobilaBL>();
            foreach (var item in autoDAL.DohvatiMarkeFull())
            {
                returnme.Add(new MarkaAutomobilaBL() { MarkaID = item.MarkaID, Naziv = item.Naziv });
            }
            MarkaAutomobilaBL markaPrazna = new MarkaAutomobilaBL();
            returnme.Insert(0, markaPrazna);
            return returnme;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiModelFull iz DAL sloja
        /// </summary>
        /// <param name="idMarke"></param>
        /// <returns></returns>
        public List<ModelAutomobilaBL> DohvatiModelFull(int idMarke)
        {
            List<ModelAutomobilaBL> returnme = new List<ModelAutomobilaBL>();
            foreach (var item in autoDAL.DohvatiModelFull(idMarke))
            {
                returnme.Add(new ModelAutomobilaBL() { ModelID = item.ModelID, Naziv = item.Naziv });
            }
            ModelAutomobilaBL modelPrazan = new ModelAutomobilaBL();
            returnme.Insert(0, modelPrazan);
            return returnme;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiTip iz DAL sloja
        /// </summary>
        /// <param name="idModela"></param>
        /// <returns></returns>
        public List<TipAutomobilaBL> DohvatiTip(int idModela)
        {
            List<TipAutomobilaBL> returnme = new List<TipAutomobilaBL>();
            foreach (var item in autoDAL.DohvatiTip(idModela))
            {
                returnme.Add(new TipAutomobilaBL() { Tip = item.Tip, TipID = item.TipID });
            }
            TipAutomobilaBL tipPrazan = new TipAutomobilaBL();
            returnme.Insert(0, tipPrazan);

            return returnme;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiModelTipID iz DAL sloja
        /// </summary>
        /// <param name="model"></param>
        /// <param name="tip"></param>
        /// <returns></returns>
        public int DohvatiModelTipID(int model, int tip)
        {
            AutomobilDAL autoDAL = new AutomobilDAL();
            int modelTipID = autoDAL.DohvatiModelTipID(model, tip);

            return modelTipID;
        }
        /// <summary>
        /// Metoda koja traži dohvaćanje podataka od metode DohvatiPogonMotor iz DAL sloja
        /// </summary>
        /// <param name="modelTipID"></param>
        /// <returns></returns>
        public DataTable DohvatiPogonMotor(int modelTipID)
        {
            AutomobilDAL autoDAL = new AutomobilDAL();
            DataTable dtModelTip = autoDAL.DohvatiPogonMotor(modelTipID);

            return dtModelTip;




        }
    }
}
