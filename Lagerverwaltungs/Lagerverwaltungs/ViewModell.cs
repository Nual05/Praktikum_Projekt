using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltungs
{
    internal class ViewModell : BindableBase 
    {
        private Controller controller;

        private DataView table;
        public DataView Table
        {
            get { return table; }
            set { SetProperty(ref table, value); }
        }

        private string artikelNummer;
        private string bezeichnung;
        private string kategorie;
        private string bestand;
        private string mindesBestand;
        private string einheit;

        private string artikelnummervonbuchung;
        private DateTime datum;
        private string menge;
        private string typ;


        // Artikel
        public string ArtikelNummer
        {
            get { return artikelNummer; }
            set { SetProperty(ref artikelNummer, value); }
        }

        public string Bezeichnung
        {
            get { return bezeichnung; }
            set { SetProperty(ref bezeichnung, value); }
        }

        public string Kategorie
        {
            get { return kategorie; }
            set { SetProperty(ref kategorie, value); }
        }

        public string Bestand
        {
            get { return bestand; }
            set { SetProperty(ref bestand, value); }
        }

        public string MindesBestand
        {
            get { return mindesBestand; }
            set { SetProperty(ref mindesBestand, value); }
        }

        public string Einheit
        {
            get { return einheit; }
            set { SetProperty(ref einheit, value); }
        }


        //Buchung
        public string Artikelnummervonbuchung
        {
            get { return artikelnummervonbuchung; }
            set { SetProperty(ref artikelnummervonbuchung, value); }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { SetProperty(ref datum, value); }
        }
        public string Menge
        {
            get { return menge; }
            set { SetProperty(ref menge, value); }
        }

        public string Typ
        {
            get { return typ; }
            set { SetProperty(ref typ, value); }
        }


        public ViewModell() 
        {
            controller = new Controller();
            Table = controller.Anzeigen();
            Datum = DateTime.Now;
        }

        public void NeuerArtikel()
        {
            if(CheckInputArtikel())
            {
                Table = controller.NeuerArtikelErstellen(ArtikelNummer, Bezeichnung, Kategorie, float.Parse(Bestand), float.Parse(MindesBestand), Einheit);
            }
        }

        public bool CheckInputArtikel()
        {
            if (String.IsNullOrEmpty(ArtikelNummer) || String.IsNullOrEmpty(Bezeichnung) || String.IsNullOrEmpty(Kategorie) ||
                String.IsNullOrEmpty(Bestand) || String.IsNullOrEmpty(MindesBestand) || String.IsNullOrEmpty(Einheit)) return false;

            return true;
        }

    }
}
