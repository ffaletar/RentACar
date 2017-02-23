using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BL
{
    public class MarkaAutomobilaBL
    {
        private int markaID;

        public int MarkaID
        {
            get { return markaID; }
            set { markaID = value; }
        }

        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
    }
} 
