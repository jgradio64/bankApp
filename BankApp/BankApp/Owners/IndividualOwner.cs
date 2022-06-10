using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Owners
{
    internal class IndividualOwner : AccountOwner
    {
        private string FirstName;
        private string LastName;
        private string Email;


        internal IndividualOwner(string id, string firstName, string lastName, string email, string phoneNumber, string address, string city, string state, string postalCode) : base(id, phoneNumber, address, city, state, postalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public string GetEmail() { return Email; }
        public string GetName() { return FirstName + " " + LastName; }

        public void SetFirstName(string firstName) { FirstName = firstName; }
        public void SetLastName(string lastName) { LastName = lastName; }
        public void SetEmail(string email) { Email = email; }

    }
}
