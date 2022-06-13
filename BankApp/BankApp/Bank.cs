using BankApp.BankApp.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.BankApp.Exceptions;

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

        // Transfer between accounts using account IDs. 
        public void TransferFundsBetweenAccounts(string tranferFromAccountID, string transferToAccountID, double amt)
        {
            try
            {
                Account TFAccount = FindAccountByID(tranferFromAccountID);

                try
                {
                    Account TTAccount = FindAccountByID(transferToAccountID);
                    try
                    {
                        TFAccount.TransferOut(amt);
                        TTAccount.TransferIn(amt);
                    } 
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                catch (AccountNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
            } 
            catch (AccountNotFoundException e) {
                Console.WriteLine(e.Message);
            }
        }

        public void PrintAllAccountInfo()
        {
            Console.WriteLine("\nPrinting Account Information\n____________________________________________________");
            foreach(Account account in AccountList)
            {
                Console.WriteLine("Account Balance: " + account.GetBalance());
            }
        }

        public Account FindAccountByID(string id)
        {
            foreach(Account account in AccountList)
            {
                // If there is an account, return that account object.
                if(id.Equals(account.GetId()))
                {
                    return account;
                }
            }
            // Put an exception here. Account not found exception = done.
            throw new AccountNotFoundException();
        }
    }
}
