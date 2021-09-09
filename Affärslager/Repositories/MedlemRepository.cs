using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class MedlemRepository
    {
        private List<Medlem> medlemmar;

        public MedlemRepository()
        {
            LaddaMedlemmar();
        }
        
        public void LaddaMedlemmar()
        {
            //Laddar in färdiga medlemmar att registrera på bokningar i listan

            medlemmar = new List<Medlem>();

            medlemmar.Add(new Medlem("1", "Gustav", "07123", "guggmeister@coolkid.se"));

            medlemmar.Add(new Medlem("2", "Phil", "07456", "intesåmycket@komplettering.se"));

            medlemmar.Add(new Medlem("3", "Dakey", "07789", "lovemusic@deeptimes.se"));

            medlemmar.Add(new Medlem("4", "Jaksch", "07390", "trött@livet.se"));

            medlemmar.Add(new Medlem("5", "Jonezz", "0702", "sjuk@snålskjuts.se"));
        }
        //Tar in en sträng som matchas mot ett befintligt mNummer i lista.
        //Hittar den en matchning returnerar den objektet
        public Medlem HämtaMedlemPåMnummer(string mnummer)
        {
            return medlemmar.Where(m => m.mNummer == mnummer).FirstOrDefault();
        }
    }
}
