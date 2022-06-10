using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.BankApp.Owners
{
    internal class AccountOwner
    {
        private readonly string _id;

        private string PhoneNumber;
        private string Address;
        private string City;
        private string State;
        private string PostalCode;

        internal AccountOwner(string id, string phoneNumber, string address, string city, string state, string postalCode)
        {
            _id = id;
            PhoneNumber = phoneNumber;
            Address = address;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        public string GetID() { return _id; }
        public string GetPhoneNumber() { return PhoneNumber; }
        public string GetAddress() { return Address; }
        public string GetCity() { return City; }
        public string GetState() { return State; }
        public string GetPostalCode() { return PostalCode; }

        public void SetPhoneNumber(string phoneNumber) { PhoneNumber = phoneNumber; }
        public void SetAddress(string address) { Address = address; }
        public void SetCity(string city) { City = city; }
        public void SetState(string state) { State = state; }
        public void SetPostalCode(string postalCode) { PostalCode = postalCode; }
    }
}
