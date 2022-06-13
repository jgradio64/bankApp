using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Owners
{
    public class CorporateOwner : AccountOwner
    {
        public CorporateOwner(string id, string businessName, string email, string phoneNumber, string address, string city, string state, string postalCode) 
            : base(id, email, phoneNumber, address, city, state, postalCode)
        {
            this.SetName(businessName);
        }
    }
}
