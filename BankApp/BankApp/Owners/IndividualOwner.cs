using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Owners
{
    public class IndividualOwner : AccountOwner
    {
        public IndividualOwner(string id, string firstName, string lastName, string email, string phoneNumber, string address, string city, string state, string postalCode) 
            : base(id, email, phoneNumber, address, city, state, postalCode)
        {
            this.SetName(firstName + " " + lastName);
        }
    }
}
