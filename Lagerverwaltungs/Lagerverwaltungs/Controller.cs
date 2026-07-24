using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltungs
{
    internal class Controller
    {
        private DB db;
        public Controller()
        {
            db = new DB();
        }

        public DataView Anzeigen()
        {
            return db.DatenAnzeigen();
        }

        public DataView NeuerArtikelErstellen(string artikelnummer, string bezeichnung, string kategorie, float bestand, float mindesbestand, string einheit)
        {
            return db.InsertArtikel( artikelnummer,  bezeichnung,  kategorie,  bestand,  mindesbestand,  einheit);
        }

    }
}
