using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Owners
{
    internal class CorporateOwner : AccountOwner
    {
        private string BusinessName;
        private string Email;


        internal CorporateOwner(string id, string businessName, string email, string phoneNumber, string address, string city, string state, string postalCode) : base(id, phoneNumber, address, city, state, postalCode)
        {
            BusinessName = businessName;
            Email = email;
        }

        public string GetName() { return BusinessName; }
        public string GetContactEmail() { return Email; }

        public void SetBusinessName(string businessName) { BusinessName = businessName; }
        public void SetEmail(string email) { Email = email; }
    }
}
