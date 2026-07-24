using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltungs
{
    internal class DB
    {
        private string username = "bbm3h23ang";
        private string password = "TuUZHe9NXkBE";

        private OracleConnection con;
        private OracleCommand cmd;

        public DB()
        {
            try
            {
                con = new OracleConnection("Data Source=dbserver2.bg.bib.de:1521/ora10.bg.bib.de;User ID=" + username + ";Password=" + password);
                cmd = new OracleCommand();
                cmd.Connection = con;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DataView DatenAnzeigen()
        {
            cmd.Connection.Open();
            cmd.CommandText = "SELECT * FROM ARTIKEL";

            OracleDataReader odr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(odr);

            
            odr.Close();
            cmd.Connection.Close();

            return dt.DefaultView;
        }

        public DataView InsertArtikel(string artikelnummer, string bezeichnung, string kategorie, float bestand, float mindesbestand, string einheit)
        {
            cmd.Connection.Open();
            cmd.CommandText = $"INSERT INTO Artikel(Artikelnummer, Bezeichnung, Kategorie, Bestand, Mindestbestand, Einheit) VALUES ('{artikelnummer}', '{bezeichnung}', '{kategorie}', {bestand}, {mindesbestand}, '{einheit}')";

            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM ARTIKEL";

            OracleDataReader odr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(odr);

            odr.Close();
            cmd.Connection.Close();

            return dt.DefaultView ;
        }
    }
}
