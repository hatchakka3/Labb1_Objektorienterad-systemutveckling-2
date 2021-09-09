using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class BokningRepository
    {
        private List<Bokning> bokningar = new List<Bokning>();

        public BokningRepository()
        {
            bokningar = HämtaBokning();
        }

        public List<Bokning> HämtaBokning()
        {
            return bokningar;
        }

        //Metoden returnerar en bokning
        //Den tar in en lista av böcker och en medlem 
        //Böckerna skickar den in till Bok-klassen där man sätter de till otillgängliga
        public Bokning BokaBok(Bok bok, Medlem medlem, Expedit expedit)
        {
            bok.Låna();
            string bokningsnummer = "123";
            if (bokningar.Count() != 0)
                bokningsnummer = bokningar.Max(r => r.BokningsNummer) + 1;
            Bokning bokning = new Bokning(medlem, DateTime.Now, DateTime.Now.AddMonths(+1), bok, bokningsnummer, expedit);
            bokningar.Add(bokning);

            return bokning;
        }
        

        public List<Bokning> HämtaBokningar (string mnummer)
        {
            return bokningar.Where(b => b.Medlem.mNummer == mnummer && b.Färdig == false).ToList();
        }
    }
}
