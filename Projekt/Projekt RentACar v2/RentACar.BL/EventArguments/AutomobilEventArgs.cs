using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BL.EventArguments
{
    public class AutomobilEventArgs : EventArgs
    {
        public DateTime pocetakPosudbe, krajPosudbe, datumRezervacije;
        public string marka, model, tip, korisnikIme, korisnikPrezime, korisnikNadimak;
        public int AutomobilId;
    }

    public delegate void AutomobilEventHandler(
           Object sender,
           AutomobilEventArgs e
       );
}
