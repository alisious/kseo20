using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kseo20.Domain
{
    public class Zabezpieczenie
    {
        public Osoba  ZabezpieczanaOsoba { get; private set; }
        public DateTime DataRozpoczecia { get; private set; }
        public string Prowadzacy { get; private set; }
        public string JednostkaProwadzaca { get; private set; }
        public string Cel { get; private set; }

        public Zabezpieczenie(Osoba zabezpieczanaOsoba,DateTime dataRozpoczecia,string prowadzacy,string jednostkaProwadzaca,string cel)
        {
            ZabezpieczanaOsoba = zabezpieczanaOsoba;
            DataRozpoczecia = dataRozpoczecia;
            Prowadzacy = prowadzacy;
            JednostkaProwadzaca = jednostkaProwadzaca;
            Cel = cel;
        }
    }

   
}
