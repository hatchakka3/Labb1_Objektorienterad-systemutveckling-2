using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class Bok 
    {
        public string ISBN { get; private set; }
        public string Titel { get; private set; }
        public bool tillgänglig { get; private set; }
        public Status Status { get; private set; }
        public Bok(string isbn, string titel)
        {
            this.ISBN = isbn;
            this.Titel = titel;
            this.Status = Status.Tillgänglig;
            this.tillgänglig = true;
        }

        public void Låna()
        {
            Status = Status.Bokad;
            tillgänglig = false;
        }

        public void Återlämna()
        {
            Status = Status.Återlämnad;
            tillgänglig = true;
        }

        public override string ToString()
        {
            return Titel;
        }
    }
}
