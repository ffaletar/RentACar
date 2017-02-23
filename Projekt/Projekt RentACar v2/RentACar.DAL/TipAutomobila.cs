using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DAL
{
    public class TipAutomobila
    {
        private int tipID;

        public int TipID
        {
            get { return tipID; }
            set { tipID = value;  }
        }

        private string tip;

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }
    }
}
