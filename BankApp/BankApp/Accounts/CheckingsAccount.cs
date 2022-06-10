using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Accounts
{
    internal class CheckingsAccount : Account
    {

        public CheckingsAccount( string id, double initialDeposit) : base(initialDeposit, id)
        { 

        }
    }
}
