using System;
using System.Collections.Generic;
using System.Linq;

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

            deleteFromAddressBook(name,addressBook);

            addMultipleAddressBook(addressBook);

            sortByName(addressBook);

            /*sortByCity(addressBook);*/

            string city = "goa";
            viewPersonByCity(city,addressBook);

        }

        private static void viewPersonByCity(string city, IDictionary<string, Person> addressBook)
        {
            for (int i = 0; i < addressBook.Count; i++)
            {
                if (addressBook[addressBook.Keys.ElementAt(i)].GetCity() == city)
                {
                    Console.WriteLine("Key: {0}, Value: {1}",
                                                        addressBook.Keys.ElementAt(i),
                                                        addressBook[addressBook.Keys.ElementAt(i)]);
                }
                
            }
        }

        /*private static void sortByCity(IDictionary<string, Person> addressBook)
        {

        }*/

        private static void sortByName(IDictionary<string, Person> addressBook)
        {
            var list = addressBook.Keys.ToList();
         
            foreach(var key in list)
            {
                Console.WriteLine(key, addressBook[key]);
            }
        }

        private static bool checkDuplicate(string name, IDictionary<string, Person> addressBook)
        {
            return addressBook.ContainsKey(name);
                
        }

        private static void addMultipleAddressBook(IDictionary<string, Person> addressBook)
        {
            Person person1 = new Person("puneet1", "M", "delhi", "delhi", "delhi", "110090", "123123123");
            Person person2 = new Person("puneet2", "M", "delhi", "delhi", "delhi", "110090", "123123123");
            Person person3 = new Person("puneet3", "M", "delhi", "delhi", "delhi", "110090", "12312312");

            addressBook.Add(person1.GetFirstName(), person1);
            addressBook.Add(person2.GetFirstName(), person2);
            addressBook.Add(person3.GetFirstName(), person3);
        }

        private static void deleteFromAddressBook(string name, IDictionary<string, Person> addressBook)
        {
            addressBook.Remove(name);
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
