using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Repositories;

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
        public Account(int gebruikerID, string naam, string email, string accountType)
        {
            GebruikerID = gebruikerID;
            Naam = naam;
            Email = email;

            AccountType = Type.Gebruiker;
            switch (accountType.ToLower())
            {
                case "administrator":
                    AccountType = Type.Administrator;
                    break;
                case "gebruiker":
                    AccountType = Type.Gebruiker;
                    break;
            }
            
        }
        public Account(int gebruikerID)
        {
            GebruikerID = gebruikerID;
            if (gebruikerID != 0)
            {
                Account thisAccount = AccountRepo.GetAccount(gebruikerID);
                Naam = thisAccount.Naam;
                Email = thisAccount.Email;
                AccountType = thisAccount.AccountType;
            }
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
