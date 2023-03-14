using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Bokning
    {
        public int BokningsID
        {
            get; private set;
        }
        public int BokID
        {
            get; set;
        }
        public Medlem Medlem
        {
            get; private set;
        }
        public Expedit Expedit
        {
            get; private set;
        }
        public DateTime UtlämningsDatum
        {
            get; private set;
        }
        public DateTime ÅterlämningsDatum
        {
            get; private set;
        }
        public bool Uthämtad
        {
            get; internal set;
        }

        public Bokning(int bokid, Medlem medlem, Expedit expedit, DateTime utlämningsdatum, DateTime återlämningsdatum, bool uthämtad)
        {
            BokningsID = maxBookingNumber++;
            BokID = bokid;
            Medlem = medlem;
            Expedit = expedit;
            UtlämningsDatum = utlämningsdatum;
            ÅterlämningsDatum = återlämningsdatum;
            Uthämtad = uthämtad;
        }
        private static int maxBookingNumber = 1;
    }
}
