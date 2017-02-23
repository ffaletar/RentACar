using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class operacijeRegistracija
    {
        public string promjeniBojuPolja(int ispravnost)
        {
            string boja;
            if (ispravnost == 2)
            {
                boja = "IndianRed";
                return boja;
            }
            else if (ispravnost == 0)
            {
                boja = "White";
                return boja;
            }
            else
            {
                boja = "DarkSeaGreen";
                return boja;
            }
        }
        public string promjeniBojuTeksta(int ispravnost)
        {
            string bojaTeksta;
            if (ispravnost == 2)
            {
                bojaTeksta = "White";
                return bojaTeksta;
            }
            else if (ispravnost == 0)
            {
                bojaTeksta = "Black";
                return bojaTeksta;
            }
            else
            {
                bojaTeksta = "White";
                return bojaTeksta;
            }
        }
    }
}
