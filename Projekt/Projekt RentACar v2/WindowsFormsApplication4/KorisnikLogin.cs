using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class KorisnikLogin
    {
        private int korisnikID;

        public int KorisnikID
        {
            get { return korisnikID; }
            set { korisnikID = value; }
        }
        private string lozinka;

        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }
        private int tipID;

        public int TipID
        {
            get { return tipID; }
            set { tipID = value; }
        }        
    }
}
