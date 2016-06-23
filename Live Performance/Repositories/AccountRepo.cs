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
    public class AccountRepo
    {
        /// <summary>
        /// Update alle relevante data rondom Accounts
        /// </summary>
        public static void UpdateData()
        {
            Data.Accounts = new List<Account>();
            Data.CurrentAccount = new Account(Data.CurrentAccount.GebruikerID);

            try
            {
                string sql = "SELECT accountID, Naam, Email, AccountType FROM ACCOUNT";
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
                                        r["accountID"].ToInt(),
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
                ExceptionForm frm = new ExceptionForm(e);
                frm.Show();
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
                                return r["ACCOUNTID"].ToInt();
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
            
            return 0;
        }

        public enum Check
        {
            Available,
            UsernameUsed,
            EmailUsed,
            BothUsed
        }
        public static Check CheckAvailable(string username, string email)
        {
            try
            {
                string sql = "SELECT * FROM ACCOUNT WHERE GEBRUIKERSNAAM = :gebruikersnaam OR EMAIL = :email";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        bool usernameused = false;
                        bool emailused = false;

                        cmd.Parameters.Add(new OracleParameter("gebruikersnaam", username));
                        cmd.Parameters.Add(new OracleParameter("email", email));

                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                if (r["gebruikersnaam"].ToString().ToLower() == username.ToLower())
                                    usernameused = true;
                                if (r["email"].ToString().ToLower() == email.ToLower())
                                    emailused = true;
                            }
                            if(usernameused && emailused)
                                return Check.BothUsed;
                            else if(usernameused)
                                return Check.UsernameUsed;
                            else if (emailused)
                                return Check.EmailUsed;
                            
                            if(!usernameused && !emailused)
                                return Check.Available;
                        }
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

        public static Account GetAccount(int id)
        {
            try
            {
                string sql = "SELECT AccountID, Naam, Email, AccountType FROM ACCOUNT WHERE ACCOUNTID = :accountid";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("accountid", id));

                        using (OracleDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                return new Account(
                                    r["accountID"].ToInt(),
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
                ExceptionForm frm = new ExceptionForm(e);
                frm.Show();
            }

            return new Account(0);
        }

        public static bool RegisterUser(string naam, string email, string username, string password)
        {

            try
            {
                string sql = "INSERT INTO ACCOUNT(gebruikersnaam, wachtwoord, naam, email, accounttype) " +
                             "VALUES(:gebruikersnaam, :wachtwoord, :naam, :email, 'GEBRUIKER')";
                using (OracleConnection conn = Data.Connection())
                {
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("gebruikersnaam", username));
                        cmd.Parameters.Add(new OracleParameter("wachtwoord", password));
                        cmd.Parameters.Add(new OracleParameter("naam", naam));
                        cmd.Parameters.Add(new OracleParameter("email", email));
                        cmd.Prepare();
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
    }
}
