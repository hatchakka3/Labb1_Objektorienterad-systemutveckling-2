using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class Kontext
    {
        public FakturaRepository FakturaRepository { get; set; }

        public BokningRepository BokningRepository { get; set; }

        public ExpeditRepository ExpeditRepository { get; set; }

        public BokRepository BokRepository { get; set; }

        public MedlemRepository MedlemRepository { get; set; }

        public Kontext()
        {
            FakturaRepository = new FakturaRepository();
            BokningRepository = new BokningRepository();
            ExpeditRepository = new ExpeditRepository();
            BokRepository = new BokRepository();
            MedlemRepository = new MedlemRepository();
        }
    }
}
