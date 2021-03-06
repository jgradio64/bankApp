using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.BankApp.Owners;

namespace BankApp.BankApp.Accounts
{
    public class CheckingsAccount : Account
    {
        private AccountOwner Owner;
        public CheckingsAccount(AccountOwner accountOwner, string id, double initialDeposit) : base(initialDeposit, id)
        {
            Owner = accountOwner;
        }

        public AccountOwner GetAccountOwner()
        {
            return Owner;
        }
    }
}
