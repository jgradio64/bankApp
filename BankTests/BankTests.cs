using BankApp;
using BankApp.BankApp.Accounts;
using BankApp.BankApp.Owners;
using BankApp.BankApp;
using BankApp.BankApp.Exceptions;


namespace BankTests
{
    [TestClass]
    public class UnitTest1
    {
        // Creating an account
        [TestMethod]
        public void BankShouldHaveNoAccounts()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            List<Account> actual = NewBank.GetAccountList();
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void InitialDepositShouldWork()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            IndividualOwner NewOwner = new IndividualOwner("1", "Itch", "Skill", "iskill0@irs.gov", "718-632-9460", "1 Fairview Trail", "Brooklyn", "New York", "11225");
            IndividualInvevtmentAccount NewAccount = new IndividualInvevtmentAccount(NewOwner, "1", 400);
            NewBank.AddAccount(NewAccount);
            Double accountBalance = NewBank.FindAccountByID("1").GetBalance();
            Assert.AreEqual(400, accountBalance);

        }

        // Additional Deposit into an existing account.
        [TestMethod]
        public void AdditionalDepositShouldWork()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            IndividualOwner NewOwner = new IndividualOwner("1", "Itch", "Skill", "iskill0@irs.gov", "718-632-9460", "1 Fairview Trail", "Brooklyn", "New York", "11225");
            IndividualInvevtmentAccount NewAccount = new IndividualInvevtmentAccount(NewOwner, "1", 400);
            NewBank.AddAccount(NewAccount);
            NewBank.FindAccountByID("1").Deposit(500);
            Double accountBalance = NewBank.FindAccountByID("1").GetBalance();
            Assert.AreEqual(900, accountBalance);
        }

        [TestMethod]
        public void WithdrawShouldWork()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            IndividualOwner NewOwner = new IndividualOwner("1", "Itch", "Skill", "iskill0@irs.gov", "718-632-9460", "1 Fairview Trail", "Brooklyn", "New York", "11225");
            IndividualInvevtmentAccount NewAccount = new IndividualInvevtmentAccount(NewOwner, "1", 400);
            NewBank.AddAccount(NewAccount);
            NewBank.FindAccountByID("1").Withdraw(200);
            Double accountBalance = NewBank.FindAccountByID("1").GetBalance();
            Assert.AreEqual(200, accountBalance);
        }

        [TestMethod]
        public void WithdrawShouldWorkCoprorate()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            CorporateOwner NewOwner = new CorporateOwner("1", "I Skill Up Academy", "iskill0@irs.gov", "718-632-9460", "1 Fairview Trail", "Brooklyn", "New York", "11225");
            CorporateInvestmentAccount NewAccount = new CorporateInvestmentAccount(NewOwner, "1", 4000);
            NewBank.AddAccount(NewAccount);
            NewBank.FindAccountByID("1").Withdraw(2000);
            Double accountBalance = NewBank.FindAccountByID("1").GetBalance();
            Assert.AreEqual(2000, accountBalance);
        }

        [TestMethod]
        [ExpectedException(typeof(OverLimitException))]
        public void WithdrawShouldFail()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            IndividualOwner NewOwner = new IndividualOwner("1", "Itch", "Skill", "iskill0@irs.gov", "718-632-9460", "1 Fairview Trail", "Brooklyn", "New York", "11225");
            IndividualInvevtmentAccount NewAccount = new IndividualInvevtmentAccount(NewOwner, "1", 800);
            NewBank.AddAccount(NewAccount);
            NewBank.FindAccountByID("1").Withdraw(600);
        }

        [TestMethod]
        public void TransferShouldFailDueToLackOfFunds()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            IndividualOwner IOwner1 = new IndividualOwner("1", "Itch", "Skill", "iskill0@irs.gov", "718-632-9460", "1 Fairview Trail", "Brooklyn", "New York", "11225");
            IndividualOwner IOwner2 = new IndividualOwner("2", "Sigvard", "Doxey", "sdoxey1@unicef.org", "315-152-3050", "284 Redwing Circle", "Syracuse", "New York", "13205");
            IndividualInvevtmentAccount InvAccount1 = new IndividualInvevtmentAccount(IOwner1, "1", 400);
            IndividualInvevtmentAccount InvAccount2 = new IndividualInvevtmentAccount(IOwner2, "2", 0);
            NewBank.AddAccount(InvAccount2);
            NewBank.AddAccount(InvAccount1);
            NewBank.TransferFundsBetweenAccounts("1", "2", 500);

            Double accountBalance = NewBank.FindAccountByID("2").GetBalance();
            Console.WriteLine(accountBalance);
            Assert.AreEqual(0, accountBalance);
        }

        [TestMethod]
        public void TransferFundsShouldWork()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            IndividualOwner IOwner1 = new IndividualOwner("1", "Itch", "Skill", "iskill0@irs.gov", "718-632-9460", "1 Fairview Trail", "Brooklyn", "New York", "11225");
            IndividualOwner IOwner2 = new IndividualOwner("2", "Sigvard", "Doxey", "sdoxey1@unicef.org", "315-152-3050", "284 Redwing Circle", "Syracuse", "New York", "13205");
            IndividualInvevtmentAccount InvAccount1 = new IndividualInvevtmentAccount(IOwner1, "1", 600);
            IndividualInvevtmentAccount InvAccount2 = new IndividualInvevtmentAccount(IOwner2, "2", 0);
            NewBank.AddAccount(InvAccount2);
            NewBank.AddAccount(InvAccount1);
            NewBank.TransferFundsBetweenAccounts("1", "2", 500);

            Double accountBalance = NewBank.FindAccountByID("2").GetBalance();
            Console.WriteLine(accountBalance);
            Assert.AreEqual(500, accountBalance);
        }


    }
}