using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class rezNep
    {
        private int autoID;
        public int AutoID
        {
            get { return autoID; }
            set { autoID = value; }
        }
        private int korisnikID;

        public int KorisnikID
        {
            get { return korisnikID; }
            set { korisnikID = value; }
        }
        private DateTime datum;

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        
    }
}
       
