using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Models;
using Live_Performance.Views;
using Oracle.DataAccess.Client;

namespace Live_Performance.Repositories
{
    class AccountRepo
    {
        public static void UpdateData()
        {
            Data.Accounts = new List<Account>();
            Data.CurrentAccount = new Account(Data.CurrentAccount.GebruikerID);

            try
            {
                string sql = "SELECT gebruikerID, Naam, Email, AccountType FROM ACCOUNT";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                Data.Accounts.Add(
                                    new Account(
                                        r["gebruikerID"].ToInt(),
                                        r["Naam"].ToString(),
                                        r["Email"].ToString(),
                                        r["AccountType"].ToString()));
                            }
                        }
                    }
                }
            }
            catch (OracleException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }
        }

        public static int ValidateCredentials(string username, string password)
        {
            try
            {
                string sql = "SELECT * FROM ACCOUNT WHERE GEBRUIKERSNAAM = :gebruikersnaam AND WACHTWOORD = :wachtwoord";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("gebruikersnaam", username));
                        cmd.Parameters.Add(new OracleParameter("wachtwoord", password));

                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                return r["gebruikerID"].ToInt();
                            }
                        }
                    }
                }
            }
            catch (OracleException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }
            
            return 0;
        }

        public static Account GetAccount(int id)
        {
            try
            {
                string sql = "SELECT gebruikerID, Naam, Email, AccountType FROM ACCOUNT WHERE gebruikerID = :gebruikerid";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("gebruikerid", id));

                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                return new Account(
                                    r["gebruikerID"].ToInt(),
                                    r["Naam"].ToString(),
                                    r["Email"].ToString(),
                                    r["AccountType"].ToString());
                            }
                        }
                    }
                }
            }
            catch (OracleException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }

            return new Account(0);
        }

        public static void RegisterUser(Account toRegister)
        {

            try
            {
                string sql = "INSERT";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                Data.Accounts.Add(
                                    new Account(
                                        r["gebruikerID"].ToInt(),
                                        r["Naam"].ToString(),
                                        r["Email"].ToString(),
                                        r["AccountType"].ToString()));
                            }
                        }
                    }
                }
            }
            catch (OracleException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }
        }
    }
}
