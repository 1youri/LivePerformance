using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Models;
using Live_Performance.Models.Boot;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace Live_Performance.Repositories
{
    public static class Data
    {
        public static bool ShownError { get; set; }
        public static List<MotorBoot> MotorBoten { get; set; }
        public static List<SpierKrachtBoot> SpierKrachtBoten { get; set; }
        public static List<Account> Accounts { get; set; }
        public static List<HuurContract> HuurContracten { get; set; }
        public static List<ExtraArtikel> ExtraArtikelen { get; set; }
        public static Account CurrentAccount { get; set; }

        /// <summary>
        /// Geeft een OracleConnection, hiermee kan je makkelijk wisselen tussen verbindingen.
        /// </summary>
        /// <returns></returns>
        public static OracleConnection Connection()
        {
            string ConnectionString = "";

            switch ("Local")
            {
            #pragma warning disable 162
                case "Athena":
                    ConnectionString = "Data Source = " +
                "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = " +
                "(PROTOCOL = TCP)(HOST = fhictora01.fhict.local)(PORT = 1521)))" +
                "(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = fhictora)));" +
                "User ID = DBI336231; PASSWORD = LPS26Youri;";
                    break;

                case "Local":
                    ConnectionString = "User Id=LP2;Password=LP2;Data Source=//localhost:1521/xe;Connection Timeout=3;";
                    break;
            #pragma warning restore 162
            }
            OracleConnection conn = new OracleConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// Update alle data in de gehele applicatie, meestal gebruikt bij het opstarten van de applicatie
        ///  </summary>
        public static void UpdateAllData()
        {
            AccountRepo.UpdateData();
            BootRepo.UpdateData();
            BijkomendeArtRepo.UpdateData();
            HuurContractRepo.UpdateData();
        }
    }
}
