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
    public class BijkomendeArtRepo
    {
        /// <summary>
        /// Update alle relevante data rondom Bijkomen Artikelen
        /// </summary>
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
                ExceptionForm frm = new ExceptionForm(e);
                frm.Show();
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
                ExceptionForm frm = new ExceptionForm(e);
                frm.Show();
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
                ExceptionForm frm = new ExceptionForm(e);
                frm.Show();
            }
            return false;
        }

        public static List<ExtraArtikel> GetRelevantArtik(int id)
        {
            List<ExtraArtikel> returnList = new List<ExtraArtikel>();
            try
            {
                string sql = "SELECT * FROM EXTRAARTIK EX, CONTRACTARTIKEL CA WHERE EX.ARTIKELID = CA.ARTIKELID AND CA.HUURCONTRACTID = :huurcontractID";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("huurcontractID", id));
                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                returnList.Add(new ExtraArtikel()
                                {
                                    ArtikelID = r["artikelID"].ToInt(),
                                    Beschrijving = r["beschrijving"].ToString(),
                                    Count = r["Aantal"].ToInt()
                                });
                            }
                        }
                    }
                }
            }
            catch (OracleException e)
            {
                ExceptionForm frm = new ExceptionForm(e);
                frm.Show();
            }

            return returnList;
        }
    }
}
