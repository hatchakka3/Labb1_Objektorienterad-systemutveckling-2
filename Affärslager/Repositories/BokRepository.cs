using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class BokRepository
    {
        private List<Bok> böcker = new List<Bok>();

        public BokRepository()
        {
            LaddaBöcker();
        }
        
        //Metod där vi lägger till färdiga böcker till listan
        public void LaddaBöcker()
        {
            böcker.Add(new Bok("123", "Pasta & tomatsås"));

            böcker.Add(new Bok("456", "Ljuv stämma för dina öron"));

            böcker.Add(new Bok("789", "Låt inte kompletteringar ta kål på dig"));

            böcker.Add(new Bok("100", "Hur man är bättre än alla andra"));

            böcker.Add(new Bok("200", "Jag klagar inte jag skyller ifrån mig"));

        }

        public List<Bok> HämtaBöcker()
        {
            return böcker;
        }
        //Returnerar tillgängliga böcker
        public List<Bok> TillgängligaBöcker()
        {
            return böcker.Where(a => a.tillgänglig == true).ToList();
        }

        //Returnerar bokade böcker
        public List<Bok> BokadeBöcker(string mNummer)
        {
            return böcker.Where(b => b.tillgänglig == false).ToList();
        }
    }
}
