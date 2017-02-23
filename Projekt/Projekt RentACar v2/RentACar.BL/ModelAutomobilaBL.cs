using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BL
{
    public class ModelAutomobilaBL
    {
        private int modelID;

        public int ModelID
        {
            get { return modelID; }
            set { modelID = value; }
        }

        private MarkaAutomobilaBL markaAutomobila;

        public MarkaAutomobilaBL MarkaAutomobila
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
