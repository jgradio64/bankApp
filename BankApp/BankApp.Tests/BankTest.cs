using System;
using BankApp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankApp.BankApp.Tests
{
    internal class BankTest
    {
        // Creating an account
        [TestMethod]
        public void BankShouldHaveNoAccounts()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            
        }
    }
}
