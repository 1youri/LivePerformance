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
    public class HuurContractRepo
    {
        /// <summary>
        /// Update alle relevante data rondom Huurcontracten
        /// </summary>
        public static void UpdateData()
        {
            Data.HuurContracten = new List<HuurContract>();

            try
            {
                string sql = "SELECT HuurContractID, HUURDER, TO_CHAR(beginDatum,'DD-MM-YYYY HH24:MI') AS BEGINDATUM, TO_CHAR(EindDatum,'DD-MM-YYYY HH24:MI') AS EINDDATUM FROM HUURCONTRACT";
                if (Data.CurrentAccount.AccountType != Account.Type.Administrator) sql += " WHERE HUURDER = :huurderID";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("huurderID", Data.CurrentAccount.GebruikerID));
                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                Data.HuurContracten.Add(
                                    new HuurContract(
                                        r["HUURCONTRACTID"].ToInt(),
                                        Data.Accounts.Find(x => x.GebruikerID == r["Huurder"].ToInt()),
                                        DateTime.ParseExact(r["BeginDatum"].ToString(), "dd-MM-yyyy HH:mm",
                                            CultureInfo.InvariantCulture),
                                        DateTime.ParseExact(r["EindDatum"].ToString(), "dd-MM-yyyy HH:mm",
                                            CultureInfo.InvariantCulture)));
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

        public static HuurContract GetHuurContract(int id)
        {
            HuurContract returnContract = new HuurContract() { HuurContractID = id};
            try
            {
                string sql = "SELECT HuurContractID, HUURDER, TO_CHAR(beginDatum,'DD-MM-YYYY HH24:MI') AS BEGINDATUM, TO_CHAR(EindDatum,'DD-MM-YYYY HH24:MI') AS EINDDATUM FROM HUURCONTRACT WHERE HuurContractID = :contractID";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("contractID", id));
                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                returnContract =
                                    new HuurContract(
                                        r["HUURCONTRACTID"].ToInt(),
                                        Data.Accounts.Find(x => x.GebruikerID == r["Huurder"].ToInt()),
                                        DateTime.ParseExact(r["BeginDatum"].ToString(), "dd-MM-yyyy HH:mm",
                                            CultureInfo.InvariantCulture),
                                        DateTime.ParseExact(r["EindDatum"].ToString(), "dd-MM-yyyy HH:mm",
                                            CultureInfo.InvariantCulture));
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

            return returnContract;
        }

        public static int InsertHuurContract(HuurContract toInsertContract)
        {
            try
            {
                string sql = "INSERT INTO HUURCONTRACT(HUURDER, BEGINDATUM, EINDDATUM) VALUES(:huurder, TO_DATE(:begindatum, 'DD-MM-YYYY HH24:MI'), TO_DATE(:einddatum, 'DD-MM-YYYY HH24:MI'))";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("huurder", toInsertContract.Huurder.GebruikerID));
                        cmd.Parameters.Add(new OracleParameter("begindatum", toInsertContract.BeginDatum.ToString("dd-MM-yyyy HH:mm")));
                        cmd.Parameters.Add(new OracleParameter("einddatum", toInsertContract.EindDatum.ToString("dd-MM-yyyy HH:mm")));
                        cmd.ExecuteNonQuery();
                    }
                }

                sql = "SELECT MAX(HUURCONTRACTID) AS MAX FROM HUURCONTRACT";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        OracleDataReader r= cmd.ExecuteReader();
                        if(r.Read())
                            return r["MAX"].ToInt();
                    }
                }
            }
            catch (OracleException e)
            {
                ExceptionForm frm = new ExceptionForm(e);
                frm.Show();
            }
            return 0;
        }

        public static void InsertHuurContractBoten(string bootnaam, int huurcontractID)
        {
            try
            {
                string sql = "INSERT INTO CONTRACTBOOT(BOOTNAAM, HUURCONTRACTID) VALUES(:bootnaam, :huurcontractID)";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("bootnaam", bootnaam));
                        cmd.Parameters.Add(new OracleParameter("huurcontractID", huurcontractID));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (OracleException e)
            {
                ExceptionForm frm = new ExceptionForm(e);
                frm.Show();
            }
        }

        public static void InsertHuurContractArtikels(int artikelID, int huurcontractID, int aantal)
        {
            try
            {
                string sql = "INSERT INTO CONTRACTARTIKEL(ARTIKELID, HUURCONTRACTID, AANTAL) VALUES(:artikelID, :huurcontractID, :aantal)";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("artikelID", artikelID));
                        cmd.Parameters.Add(new OracleParameter("huurcontractID", huurcontractID));
                        cmd.Parameters.Add(new OracleParameter("aantal", aantal));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (OracleException e)
            {
                if (!Data.ShownError)
                {
                    ExceptionForm frm = new ExceptionForm(e);
                    frm.ShowDialog();
                }
                
            }
        }
    }
}
