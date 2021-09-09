using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class Bokning
    {
        public Medlem Medlem { get; private set; }
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }
        public Expedit Expedit { get; private set; }
        public Bok Bok { get; private set; }
        public string BokningsNummer { get; private set; }
        public bool Färdig { get; set; }

        public Bokning(Medlem medlem, DateTime starttid, DateTime sluttid, Bok bok, string bokningsnummer, Expedit expedit)
        {
            Medlem = medlem;
            StartTid = starttid;
            SlutTid = sluttid;
            Bok = bok;
            BokningsNummer = bokningsnummer;
            Expedit = expedit;
            Färdig = false;
        }

        public override string ToString()
        {
            return BokningsNummer;
        }
    }
}
