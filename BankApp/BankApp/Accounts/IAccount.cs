using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Accounts
{
    internal interface IAccount
    {
        void Deposit(double amt);
        void Withdraw(double amt);
        void TransferIn(double amt);
        void TransferOut(double amt);
        double GetBalance();
    }
}
