using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Exceptions
{
    public class NegativeBalanceException : Exception
    {
        public override string Message
        {
            get { return "The action cannot be completed as an account cannot have a negative balance."; }
        }
    }
}
