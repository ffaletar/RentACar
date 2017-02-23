using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BL.EventArguments
{
    public class NovaRezervacijaEventArgs : EventArgs
    {        
        public int korisnikID;       
    }
    public delegate void NovaRezervacijaEventHandler(
                   Object sender,
                   NovaRezervacijaEventArgs e
               );
}
