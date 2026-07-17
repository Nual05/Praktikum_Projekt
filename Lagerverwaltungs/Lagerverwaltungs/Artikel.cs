using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltungs
{
    internal class Artikel
    {
        private string artikelNummer;
        private string bezeichnung;
        private string kategorie;
        private float bestand;
        private float mindesBestand;
        private string einheit;

        public Artikel(string artikelNummer, string bezeichnung, string kategorie, float bestand, float mindesBestand, string einheit) 
        {
            this.artikelNummer = artikelNummer;
            this.bezeichnung = bezeichnung; 
            this.kategorie = kategorie;
            this.bestand = bestand;
            this.mindesBestand = mindesBestand;
            this.einheit = einheit; 
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
