using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltungs
{
    internal class Lagerbuchung
    {

        private string artikelNummer;
        private DateTime datum;
        private float menge;
        private string typ;

        public Lagerbuchung(string artikelNummer, DateTime datum, float menge, string typ)
        {
            this.artikelNummer = artikelNummer;
            this.datum = datum;
            this.menge = menge; 
            this.typ = typ;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
