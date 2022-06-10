using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Accounts
{
    public class Account : IAccount
    {
        private double Balance;
        private readonly string _id;

        public Account(double InitialDeposit, string id)
        {
            Balance = InitialDeposit;
            _id = id;
        }

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
            Balance -= amt;
        }

        public void Withdraw(double amt)
        {
            if (NonNegativeBalance(amt))
            {
                Balance -= amt;
            }
            else
            {
                Exception exception = new NegativeBalanceException();
                Console.WriteLine("Exception: " + exception);
            }

        }

        private bool NonNegativeBalance(double amt)
        {
            if (Balance <= 0 || amt > Balance)
            {
                return false;
            }

            return true;
        }
    }
}
