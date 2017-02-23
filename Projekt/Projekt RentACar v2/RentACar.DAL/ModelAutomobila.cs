using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DAL
{
    public class ModelAutomobila
    {
        private int modelID;

        public int ModelID
        {
            get { return modelID; }
            set { modelID = value; }
        }

        private MarkaAutomobila markaAutomobila;

        public MarkaAutomobila MarkaAutomobila
        {
            get { return markaAutomobila; }
            set { markaAutomobila = value; }
        }

        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
    }
}
