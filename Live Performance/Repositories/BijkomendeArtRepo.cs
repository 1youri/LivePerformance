using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Models;
using Live_Performance.Views;
using Oracle.DataAccess.Client;

namespace Live_Performance.Repositories
{
    class BijkomendeArtRepo
    {
        public static void UpdateData()
        {
            Data.ExtraArtikelen = new List<ExtraArtikel>();

            try
            {
                string sql = "SELECT * FROM EXTRAARTIK";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("huurderID", Data.CurrentAccount.GebruikerID));
                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                Data.ExtraArtikelen.Add(new ExtraArtikel()
                                {
                                    ArtikelID = r["artikelID"].ToInt(),
                                    Beschrijving = r["beschrijving"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (OracleException e)
            {
                new ExceptionForm(e).Show();
            }
        }

        public static bool InsertArtikel(string beschrijving)
        {

            try
            {
                string sql = "INSERT INTO EXTRAARTIK(beschrijving) VALUES(:beschrijving)";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("beschrijving", beschrijving));
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (OracleException e)
            {
                new ExceptionForm(e).Show();
            }
            return false;
        }

        public static bool UpdateArtikel(int ID, string beschrijving)
        {

            try
            {
                string sql = "UPDATE EXTRAARTIK SET beschrijving = :beschrijving WHERE ARTIKELID = :artikelID";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("beschrijving", beschrijving));
                        cmd.Parameters.Add(new OracleParameter("artikelID", ID));
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (OracleException e)
            {
                new ExceptionForm(e).Show();
            }
            return false;
        }
    }
}
