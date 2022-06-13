using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.BankApp.Exceptions;

namespace BankApp.BankApp.Accounts
{
    public abstract class Account : IAccount
    {
        internal double Balance;
        private readonly string _id;

        public Account(double InitialDeposit, string id)
        {
            Balance = InitialDeposit;
            _id = id;
        }

        public string GetId() { return _id; }

        public void Deposit(double amt)
        {
            Balance += amt;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void TransferIn(double amt)
        {
            Balance += amt;
        }

        public void TransferOut(double amt)
        {
            if (NonNegativeBalance(amt))
            {
                Balance -= amt;
            }
            else
            {
                Exception exception = new NegativeBalanceException();
                throw exception;
            }
        }

        public virtual void Withdraw(double amt)
        {
            if (NonNegativeBalance(amt))
            {
                Balance -= amt;
            }
            else
            {
                Exception exception = new NegativeBalanceException();
                Console.WriteLine(exception);
            }

        }

        internal bool NonNegativeBalance(double amt)
        {
            if (Balance <= 0 || amt > Balance)
            {
                return false;
            }

            return true;
        }
    }
}
