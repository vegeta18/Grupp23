using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Faktura
    {
        public int FakturaNummer { get; private set; }
        public int BokningsID { get; private set; }
        public decimal Summa { get; private set; }
        public DateTime ÅterlämnadDatum { get; private set; }

        public Faktura(int bokningsid, decimal summa, DateTime återlämnaddatum)
        {
            FakturaNummer = maxNummer++;
            BokningsID = bokningsid;
            Summa = summa;
            ÅterlämnadDatum = återlämnaddatum;
        }
        private static int maxNummer = 1;
    }
}
