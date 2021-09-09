using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class Faktura 
    {
        public int FakturaNummer { get; private set; }
        public int Totaldagar { get; private set; }
        public Bokning Bokning { get; private set; }
        public Decimal Pris { get; private set; }

        public Faktura(int fakturaNummer, int totaldagar, Bokning bokning, Decimal pris)
        {
            this.FakturaNummer = fakturaNummer;
            this.Totaldagar = totaldagar;
            this.Bokning = bokning;
            this.Pris = pris;
        }
    }
}
