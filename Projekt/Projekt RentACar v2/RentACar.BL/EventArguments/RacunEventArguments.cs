using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BL.EventArguments
{
    public class RacunEventArguments
    {
        public int rezervacijaID;       
        
    }
    public delegate void RacunEventHandler(
                   Object sender,
                   RacunEventArguments e
               );
}
