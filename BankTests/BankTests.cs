

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

            Double accountBalance = NewBank.FindAccountByID("1").GetBalance();
            Assert.AreEqual(400, accountBalance);

        }

        /*[TestMethod]
        public void TransferShouldFailDueToLackOfFunds()
        {
            Bank NewBank = new Bank("000001", "Some Bank Name");
            IndividualOwner IOwner1 = new IndividualOwner("1", "Itch", "Skill", "iskill0@irs.gov", "718-632-9460", "1 Fairview Trail", "Brooklyn", "New York", "11225");
            IndividualOwner IOwner2 = new IndividualOwner("2", "Sigvard", "Doxey", "sdoxey1@unicef.org", "315-152-3050", "284 Redwing Circle", "Syracuse", "New York", "13205");
            IndividualInvevtmentAccount InvAccount1 = new IndividualInvevtmentAccount(IOwner1, "1", 400);
            IndividualInvevtmentAccount InvAccount2 = new IndividualInvevtmentAccount(IOwner2, "2", 0);
            NewBank.TransferFundsBetweenAccounts("1", "2", 500);

        }*/
    }
}
}