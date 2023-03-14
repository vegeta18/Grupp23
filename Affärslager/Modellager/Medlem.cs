using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Medlem
    {
        public int MedlemsID { get; private set; }

        public Medlem(int medlemsid, string fnamn, string enamn, string telenr, string email)
        {
            MedlemsID = medlemsid;
            Fnamn = fnamn;
            Enamn = enamn;
            TeleNr = telenr;
            Email = email;
        }
    }
}
