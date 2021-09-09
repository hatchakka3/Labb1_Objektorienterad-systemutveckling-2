using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class Expedit 
    {
        public string Roll
        {
            get; private set;
        }
        public string aNummer
        {
            get; private set;
        }
        public string Lösen
        {
            get; private set;
        }
        public string Namn { get; private set; }

        public Expedit(string roll, string ANummer, string lösen, string namn)
        {
            Roll = roll;
            aNummer = ANummer;
            Lösen = lösen;
            Namn = namn;
        }

        public override string ToString()
        {
            return Namn;
        }

    }
}
