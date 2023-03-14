using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellager
{
    public class Expedit:Person 
    {
        public int AnställningsID { get; private set; }
        public string Roll { get; set; }
        private string Password;

        public Expedit(int anställningsid, string roll, string password, string fnamn)
        {
            AnställningsID = anställningsid;
            Roll = roll;
            this.Password = password;
            Fnamn = fnamn;
        }
        public bool VerifyPassword(string input)
        {
            return Password == input;
        }

    }
}
