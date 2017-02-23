using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BL.EventArguments
{
    public class MojeRezervacijeEventArgs : EventArgs
    {
        public int korisnikID;        
    }
    public delegate void MojeRezervacijeEventHandler(
               Object sender,
               MojeRezervacijeEventArgs e
           );
}
