using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class RezervacijaFull
    {
        private int rezervacijaID;     
        public int RezervacijaID
        {
            get { return rezervacijaID; }
            set { rezervacijaID = value; }
        }
        private AutomobilFull automobilFull;
        public AutomobilFull AutomobilFull
        {
            get { return automobilFull; }
            set { automobilFull = value; }
        }
        private KorisnikFull korisnikFull;
        public KorisnikFull KorisnikFull
        {
            get { return  korisnikFull; }
            set {  korisnikFull = value; }
        }
        private Status status;
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime datumRezervacije;
        public DateTime DatumRezervacije
        {
            get { return datumRezervacije; }
            set { datumRezervacije = value; }
        }
        private DateTime pocetakPosudbe;
        public DateTime PocetakPosudbe
        {
            get { return pocetakPosudbe; }
            set { pocetakPosudbe = value; }
        }
        private DateTime krajPosudbe;
        public DateTime KrajPosudbe
        {
            get { return krajPosudbe; }
            set { krajPosudbe = value; }
        }     
    }
}
