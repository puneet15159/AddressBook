using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            Person person = new Person("puneet", "M", "delhi", "delhi", "delhi", "110090", "123123123");

            IDictionary<string, Person> addressBook = new Dictionary<string, Person>();

            addToAddressBook(person, addressBook);

            string name = "puneet";
            string newCity = "goa";
            string newZip = "110007";

            editAddressBook(name,newCity,newZip,addressBook);



        }

        private static void editAddressBook(string name, string newCity, string newZip, IDictionary<string, Person> addressBook)
        {
            Person person = new Person();
            person = addressBook[name];
            person.SetCity(newCity);
            person.SetZip(newZip);
            addressBook.Remove(name);
            addressBook.Add(name, person);

        }

        private static void addToAddressBook(Person person, IDictionary<string, Person> addressBook)
        {
            addressBook.Add(person.GetFirstName(), person);
        }


    }
}
