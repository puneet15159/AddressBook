using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace AddressBook
{
    internal class AddressBookUtility
    {
        internal IDictionary<string, Person> addToAddressBook(IDictionary<string, Person> addressBook)
        {
            Console.WriteLine("Enter the first Name of person:");
            String fName = Console.ReadLine();
            Console.WriteLine("Enter the last Name of person:");
            String lName = Console.ReadLine();
            Console.WriteLine("Enter the address");
            String address = Console.ReadLine();
            Console.WriteLine("Enter the city");
            String city = Console.ReadLine();
            Console.WriteLine("Enter the state");
            String state = Console.ReadLine();
            Console.WriteLine("Enter the zip");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            String phoneNumber = Console.ReadLine();
            Person personNew = new Person(fName, lName, address, city, state, zip, phoneNumber);

            addressBook.Add(personNew.GetFirstName(), personNew);

            return addressBook;
        }

        internal IDictionary<string, Person> editAddressBook(IDictionary<string, Person> addressBook)
        {
            Console.WriteLine("Enter the phone number");
            String phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the first name");
            String fName = Console.ReadLine();

            addressBook[fName].SetPhoneNumber(phoneNumber);

            return addressBook;
            

        }

        internal IDictionary<string, Person> deleteFromAddressBook(IDictionary<string, Person> addressBook)
        {
            Console.WriteLine("Enter the name to be deleted");
            String name = Console.ReadLine();

            addressBook.Remove(name);
            return addressBook;
        }

        internal void DisplayAddressBook(IDictionary<string, Person> addressBook)
        {

            for (int i = 0; i < addressBook.Count; i++)
            {
                   Console.WriteLine("Key: {0}",addressBook.Keys.ElementAt(i));
                   DisplayPerson(addressBook[addressBook.Keys.ElementAt(i)]);
            }
        }

        internal IDictionary<string, Person> AddMultiple(IDictionary<string, Person> addressBook)
        {
            addressBook=addToAddressBook(addressBook);
            addressBook=addToAddressBook(addressBook);
            addressBook=addToAddressBook(addressBook);

            return addressBook;

            
        }

        internal bool checkDuplicate(IDictionary<string, Person> addressBook)
        {
            Console.WriteLine("Enter the name to be checked");
            String name = Console.ReadLine();

            return addressBook.ContainsKey(name);
        }

        internal void sortByName(IDictionary<string, Person> addressBook)
        {
            var list = addressBook.Keys.ToList();

            foreach (var key in list)
            {
                Console.WriteLine(key, addressBook[key]);
            }
        }

        internal void searchInCity(IDictionary<string, Person> addressBook)
        {
            Console.WriteLine("Enter the name");
            String name = Console.ReadLine();
            string city = addressBook[name].GetCity();
            Console.WriteLine(city);
        }

        internal void viewByCity(IDictionary<string, Person> addressBook)
        {
            Console.WriteLine("Enter the city");
            String city = Console.ReadLine();

            for (int i = 0; i < addressBook.Count; i++)
            {
                if (addressBook[addressBook.Keys.ElementAt(i)].GetCity().Equals(city))
                {
                    Console.WriteLine("Key: {0}",
                                                        addressBook.Keys.ElementAt(i));
                    
                    DisplayPerson(addressBook[addressBook.Keys.ElementAt(i)]);
                }

            }
        }

        private void DisplayPerson(Person person)
        {
            Console.WriteLine(person.GetFirstName());
            Console.WriteLine(person.GetLastNamee());
            Console.WriteLine(person.Getaddress());
            Console.WriteLine(person.GetCity());
            Console.WriteLine(person.GetZip());
            Console.WriteLine(person.GetPhoneNumber());
        }

        internal void SortByCity(IDictionary<string, Person> addressBook)
        {
            throw new NotImplementedException();
        }
    }
}