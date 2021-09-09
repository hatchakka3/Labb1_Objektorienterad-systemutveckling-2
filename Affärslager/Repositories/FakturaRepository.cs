using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class FakturaRepository
    {
        private List<Faktura> fakturor = new List<Faktura>();
        
        public List<Faktura> HämtaFakturor()
        {
            return fakturor;
        }

        //Metoden returnerar en faktura och ändrar boken till tillgänglig och bokningen till färdig
        public Faktura ÅterlämnaBok(Bokning bokning)
        {
            bokning.Färdig = true;
            bokning.SlutTid = DateTime.Now;
            bokning.Bok.Återlämna();

            int dagar = bokning.SlutTid.Subtract(bokning.StartTid).Days;
            Decimal pris = new Decimal(10.00 * dagar);

            int fakturanummer = 123;
            if (fakturor.Count != 0)
                fakturanummer = fakturor.Max(f => f.FakturaNummer) + 1;
            Faktura faktura = new Faktura(fakturanummer, dagar, bokning, pris);
            fakturor.Add(faktura);

            return faktura;
        }
    }
}
