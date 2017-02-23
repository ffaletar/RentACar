using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BL.EventArguments
{
    public class DodajAutomobilEventArgs : EventArgs
    {
        public int automobilID;
    }
    public delegate void DodajAutomobilEventHandler(
               Object sender,
               DodajAutomobilEventArgs e
           );
}
