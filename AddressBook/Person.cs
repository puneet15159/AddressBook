using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;

        public Person()
        {
        }

        public Person(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
        }

        public string GetFirstName()
        {
            return firstName;
        }


        public string GetLastNamee()
        {
            return lastName;
        }

        public void SetLastName(string _lastName)
        {
            lastName = _lastName;
        }

        public string Getaddress()
        {
            return address;
        }

        public void Setaddress(string _address)
        {
            address = _address;
        }

        public string GetCity()
        {
            return city;
        }

        public void SetCity(string _city)
        {
            city = _city;
        }

        public string GetState()
        {
            return state;
        }

        public void SetState(string _state)
        {
            state = _state;
        }

        public string GetZip()
        {
            return zip;
        }

        public void SetZip(string _zip)
        {
            zip = _zip;
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void SetPhoneNumber(string _phoneNumber)
        {
            phoneNumber = _phoneNumber;
        }
    }
}
