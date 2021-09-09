using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class ExpeditRepository
    {
        private List<Expedit> Expediter;

        public ExpeditRepository()
        {
            LaddaData();
        }
        
        //Metod som verifierar Expeditens anställningsnummer och lösenord och ger sedan acess till systemet
        public Expedit LogIn(string ANummer, string Lösen)
        {
            foreach (Expedit e in Expediter)
            {
                if (e.aNummer == ANummer && e.Lösen == Lösen)
                {
                    return e;
                }
            }
            return null;
        }

        //Metod som laddar in 3 färdiga expediter till systemet
        //Dessa läggs in i en lista
        public void LaddaData()
        {
            Expediter = new List<Expedit>();

            Expedit e1 = new Expedit("Expedit", "s184700", "123", "Aleksander");
            Expediter.Add(e1);

            Expedit e2 = new Expedit("Expedit", "s184597", "456", "Oliver");
            Expediter.Add(e2);

            Expedit e3 = new Expedit("Expedit", "s182843", "789", "Jonas");
            Expediter.Add(e3);
        }
    }
}
