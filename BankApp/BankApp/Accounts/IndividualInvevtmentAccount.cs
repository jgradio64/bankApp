using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.BankApp.Owners;
using BankApp.BankApp.Exceptions;

namespace BankApp.BankApp.Accounts
{
    public class IndividualInvevtmentAccount : Account
    {
        // Has a limit on how much can be withdrawn at a time. Individual owner.
        private IndividualOwner Owner;

        public IndividualInvevtmentAccount(IndividualOwner owner, string id, double initialDeposit) : base(initialDeposit, id)
        {
            Owner = owner;
        }

        public override void Withdraw(double amount)
        {
            if (amount > 500)
            {
                Exception exception = new OverLimitException();
                throw exception;
            } 
            else if (!NonNegativeBalance(amount))
            {
                Exception exception = new NegativeBalanceException();
                throw exception;
            } else
            {
                Balance -= amount;
            }
        }

        public AccountOwner GetAccountOwner()
        {
            return Owner;
        }
    }
}
