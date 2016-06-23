using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Models;
using Live_Performance.Repositories;

namespace Live_Performance.Logic
{
    public class Login
    {
        /// <summary>
        /// Controrleerd de gegevens van de gebruiker en logt deze in
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool LoginUser(string username, string password)
        {
            int userID = AccountRepo.ValidateCredentials(username, Encrypt(password));
            if (userID != 0)
            {
                Data.CurrentAccount = new Account(userID);
                Data.UpdateAllData();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Encrypt het gegeven wachtwoord
        /// </summary>
        /// <param name="Password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static string Encrypt(string Password, string salt = "LivePerformance")
        {
            byte[] MessageBytes = Encoding.UTF8.GetBytes(string.Concat(Password, salt));
            SHA512Managed SHhash = new SHA512Managed();
            byte[] HashValue = SHhash.ComputeHash(MessageBytes);
            string strHex = "";
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }


        /// <summary>
        /// Controleerd of de gegeven accountgegevens nog beschikbaar zijn
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static AccountRepo.Check CheckAvailable(string username, string email)
        {
            return AccountRepo.CheckAvailable(username, email);
        }

        /// <summary>
        /// registreerd een gebruiker
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool RegisterUser(string naam, string email, string username, string password)
        {
            return AccountRepo.RegisterUser(naam, email, username, Encrypt(password));
        }
    }
}
