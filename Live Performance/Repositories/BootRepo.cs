using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Models;
using Live_Performance.Models.Boot;
using Live_Performance.Views;
using Oracle.DataAccess.Client;

namespace Live_Performance.Repositories
{
    public class BootRepo
    {
        /// <summary>
        /// Update alle relevante data rondom Boten
        /// </summary>
        public static void UpdateData()
        {
            Data.MotorBoten = new List<MotorBoot>();
            Data.SpierKrachtBoten = new List<SpierKrachtBoot>();

            try
            {
                string sql = "SELECT * FROM BOOT B, SOORT S WHERE B.SOORTID = S.SOORTID";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                if (r["ISMOTORBOOT"].ToString() == "1")
                                {
                                    Data.MotorBoten.Add(
                                        new MotorBoot(
                                            r["NAAM"].ToString(),
                                            r["SOORTBESCHRIJVING"].ToString(),
                                            r["TYPE"].ToString(),
                                            r["TANKINHOUD"].ToInt()));
                                }
                                else
                                {
                                    Data.SpierKrachtBoten.Add(
                                        new SpierKrachtBoot(
                                            r["NAAM"].ToString(),
                                            r["SOORTBESCHRIJVING"].ToString(),
                                            r["TYPE"].ToString()));
                                }
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

        public static List<IBoot> GetAvailableBoten(DateTime datum1, DateTime datum2)
        {
            List<MotorBoot> tempMotorBooten = new List<MotorBoot>();
            List<SpierKrachtBoot> tempSpierKrachtBooten = new List<SpierKrachtBoot>();

            try
            {
                string sql = "SELECT * FROM BOOT B, SOORT S WHERE B.SOORTID = S.SOORTID AND B.NAAM NOT IN " +
                             "( SELECT B.NAAM FROM BOOT B, SOORT S, CONTRACTBOOT CB, HUURCONTRACT H " +
                             "WHERE B.SOORTID = S.SOORTID AND B.NAAM = CB.BOOTNAAM " +
                             "AND H.HUURCONTRACTID = CB.HUURCONTRACTID AND " +
                             "(TO_DATE(:datum, 'DD-MM-YYYY HH24:MI') BETWEEN H.BEGINDATUM AND H.EINDDATUM OR " +
                             "TO_DATE(:datum2, 'DD-MM-YYYY HH24:MI') BETWEEN H.BEGINDATUM AND H.EINDDATUM))";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("datum", datum1.ToString("dd-MM-yyyy HH:mm")));
                        cmd.Parameters.Add(new OracleParameter("datum", datum2.ToString("dd-MM-yyyy HH:mm")));
                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                if (r["ISMOTORBOOT"].ToString() == "1")
                                {
                                    tempMotorBooten.Add(
                                        new MotorBoot(
                                            r["NAAM"].ToString(),
                                            r["SOORTBESCHRIJVING"].ToString(),
                                            r["TYPE"].ToString(),
                                            r["TANKINHOUD"].ToInt()));
                                }
                                else
                                {
                                    tempSpierKrachtBooten.Add(
                                        new SpierKrachtBoot(
                                            r["NAAM"].ToString(),
                                            r["SOORTBESCHRIJVING"].ToString(),
                                            r["TYPE"].ToString()));
                                }
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

            List<IBoot> returnlist = new List<IBoot>();
            returnlist.AddRange(tempMotorBooten);
            returnlist.AddRange(tempSpierKrachtBooten);
            return returnlist;
        }

        public static List<IBoot> GetRelaventBoten(int huurContractID)
        {
            List<MotorBoot> tempMotorBooten = new List<MotorBoot>();
            List<SpierKrachtBoot> tempSpierKrachtBooten = new List<SpierKrachtBoot>();

            try
            {
                string sql = "SELECT * FROM BOOT B, SOORT S, CONTRACTBOOT CB " +
                             "WHERE B.SOORTID = S.SOORTID AND B.NAAM = CB.BOOTNAAM AND " +
                             "CB.HUURCONTRACTID = :huurcontractid";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("huurcontractid", huurContractID));
                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                if (r["ISMOTORBOOT"].ToString() == "1")
                                {
                                    tempMotorBooten.Add(
                                        new MotorBoot(
                                            r["NAAM"].ToString(),
                                            r["SOORTBESCHRIJVING"].ToString(),
                                            r["TYPE"].ToString(),
                                            r["TANKINHOUD"].ToInt()));
                                }
                                else
                                {
                                    tempSpierKrachtBooten.Add(
                                        new SpierKrachtBoot(
                                            r["NAAM"].ToString(),
                                            r["SOORTBESCHRIJVING"].ToString(),
                                            r["TYPE"].ToString()));
                                }
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

            List<IBoot> returnlist = new List<IBoot>();
            returnlist.AddRange(tempMotorBooten);
            returnlist.AddRange(tempSpierKrachtBooten);
            return returnlist;
        }
    }
}
