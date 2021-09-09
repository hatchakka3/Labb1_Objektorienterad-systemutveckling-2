using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class Medlem 
    {
        public string mNummer { get; private set; }
        public string namn { get; private set; }
        public string telNummer { get; private set; }
        public string email { get; private set; }

        public Medlem(string mnummer, string Namn, string Telnummer, string Email)
        {
            mNummer = mnummer;
            namn = Namn;
            telNummer = Telnummer;
            email = Email;
        }

        public override string ToString()
        {
            return namn;
        }
    }
}
