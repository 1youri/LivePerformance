using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Repositories;

namespace Live_Performance.Logic
{
    class Login
    {
        public static bool LoginUser(string username, string password)
        {
            int userID = AccountRepo.ValidateCredentials(username, Encrypt(password));
            if (userID != 0)
            {
                
            }

            return false;
        }


        public static string Encrypt(string Password, string salt = "LivePerformance")
        {
            byte[] MessageBytes = Encoding.UTF8.GetBytes(string.Concat(Password, salt));
            SHA512Managed SHhash = new SHA512Managed();
            byte[] HashValue = SHhash.ComputeHash(MessageBytes);
            string strHex = "";
            foreach (byte b in HashValue) { strHex += String.Format("{0:x2}", b); }
            return strHex;
        }
    }
}
