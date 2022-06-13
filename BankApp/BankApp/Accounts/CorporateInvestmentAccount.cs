using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.BankApp.Owners;

namespace BankApp.BankApp.Accounts
{
    public class CorporateInvestmentAccount : Account
    {
        private CorporateOwner Owner;
        // No limit on withdraws, corporate owner
        public CorporateInvestmentAccount(CorporateOwner accountOwner, string id, double initDeposit) : base(initDeposit, id) {
            Owner = accountOwner;
        }
        public AccountOwner GetAccountOwner()
        {
            return Owner;
        }

    }
}
