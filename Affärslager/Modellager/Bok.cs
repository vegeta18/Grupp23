using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Bok
    {
        public int ID
        {
            get; private set;
        }
        public string BokTitel
        {
            get; private set;
        }
        public string Författare
        {
            get; private set;
        }
        public string ISBNNummer
        {
            get; private set;
        }
        public string Information
        {
            get; private set;
        }
        public bool Tillgänglig
        {
            get; internal set;
        }

        public Bok(int id, string boktitel, string författare, string isbnnummer, string information, bool tillgänglig)
        {
            ID = id;
            BokTitel = boktitel;
            Författare = författare;
            ISBNNummer = isbnnummer;
            Information = information;
            Tillgänglig = tillgänglig;
        }
    }
}