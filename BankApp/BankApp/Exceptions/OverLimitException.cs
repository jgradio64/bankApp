using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Exceptions
{
    internal class OverLimitException : Exception
    {
        public override string Message
        {
            get { return "Inidividual investment accounts can only withdraw $500 at a time"; }
        }
    }
}
