using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affärslager
{
    public class Bibliotek 
    {
        private Kontext Kontext { get; set; }

        public Bibliotek(Kontext kontext)
        {
            Kontext = kontext;
        }

        //Metod som returnerar en bokning
        //Metoden tar in en lista med strängar och en sträng
        //Dessa strängar skickas vidare till repository metoder där värdena matchas mot skapade objekt
        //Efteråt skickas det funna objekten in till BokaBok metoden 
        public Bokning BokaBok(Bok bok, string mnummer, Expedit expedit)
        {
            Medlem medlem = Kontext.MedlemRepository.HämtaMedlemPåMnummer(mnummer);

            Bokning bokning = Kontext.BokningRepository.BokaBok(bok, medlem, expedit);
            return bokning;
        }

        public Expedit LoggaIn(string aNummer, string lösen)
        {
            return Kontext.ExpeditRepository.LogIn(aNummer, lösen);
        }

        //Metoder för att hämta lagrade objekt
        public List<Bok> HämtaTillgängligaBöcker()
        {
            return Kontext.BokRepository.TillgängligaBöcker();
        }

        public List<Bokning> HämtaBokningar(string mnummer)
        {
            return Kontext.BokningRepository.HämtaBokningar(mnummer);
        }

        //Metod som returnerar en faktura
        //Metoden tar in en sträng som skickas vidare in till repository
        //Inuti repositoriet matchas strängen mot ett existerande objekt
        //När objektet är funnet skickas det in i ÅterlämnaBok metoden där en faktura skapas
        public Faktura ÅterlämnaBok(Bokning bokning)
        {
            Faktura faktura = Kontext.FakturaRepository.ÅterlämnaBok(bokning);
            return faktura;
        }

        public List<Faktura> HämtaFakturor()
        {
            return Kontext.FakturaRepository.HämtaFakturor();
        }
    }
}
