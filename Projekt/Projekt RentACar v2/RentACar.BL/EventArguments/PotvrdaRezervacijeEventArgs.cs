using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BL.EventArguments
{
    public class PotvrdaRezervacijeEventArgs : EventArgs
    {
        public DateTime datumRezervacije, pocetakPosudbe, krajPosudbe;
        public string marka, model, tip, korisnikNadimak;
        public int korisnikID, cijena;     
    }
    public delegate void PotvrdaRezervacijeEventHandler(
               Object sender,
               PotvrdaRezervacijeEventArgs e
           );
}
