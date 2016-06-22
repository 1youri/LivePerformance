using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Models
{
    public class Account
    {
        public Account(int gebruikerID, string naam, string email, Type accountType)
        {
            GebruikerID = gebruikerID;
            Naam = naam;
            Email = email;
            AccountType = accountType;
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public enum Type
        {
            Gebruiker,
            Administrator
        }
        public int GebruikerID { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
        public Type AccountType { get; set; }


    }
}
