using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltungs
{
    internal class DB
    {
        private string username = "...";
        private string password = "...";

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
    }
}
