using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class AutiPrikaz
    {

        private string marka, model, tip;
        private int cijena;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        public int Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }
    }
}
