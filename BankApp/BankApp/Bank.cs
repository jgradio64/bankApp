using BankApp.BankApp.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp
{
    public class Bank
    {
        private readonly string _id;
        private string _name;
        private List<Account> AccountList;

        public Bank(string id, string name)
        {
            _id = id;
            _name = name;
            AccountList = new List<Account>();
        }

        public string GetId() { return _id; }
        public string GetName() { return _name; }
        public List<Account> GetAccountList() { return AccountList; }

        public void SetName(string name) { _name = name; }
        public void AddAccount(Account account) { AccountList.Add(account); }

        public void RemoveAccount(Account account) { AccountList.Remove(account); }

        public void PrintAccountInfo()
        {
            Console.WriteLine("\nPrinting Account Information\n_______________________________________________");
            foreach(Account account in AccountList)
            {
                Console.WriteLine("Account Balance: " + account.GetBalance());
            }
        }
    }
}
