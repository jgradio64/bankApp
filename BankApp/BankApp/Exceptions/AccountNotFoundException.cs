using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Exceptions
{
    internal class AccountNotFoundException : Exception
    {
        public override string Message
        {
            get { return "There was no account found with that matching ID"; }
        }
    }
}
