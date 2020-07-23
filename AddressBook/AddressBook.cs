using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AddressBook
{
    class AddressBook
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            int checkOut = 0;

            IDictionary<string, Person> addressBook = new Dictionary<string, Person>();
            AddressBookUtility addressBookUtility = new AddressBookUtility();
            do
            {
                Console.WriteLine("choice 1: Add Person Details ");
                Console.WriteLine("choice 2: Editing Person Details ");
                Console.WriteLine("choice 3: Delete  Person Details ");
                Console.WriteLine("choice 4: Add Multiple Person");
                Console.WriteLine("choice 5: check for duplicate");
                Console.WriteLine("choice 6: Short Persion By City");
                Console.WriteLine("choice 7: Short Persion By Zip");
                Console.WriteLine("choice 8: View person by city");
                Console.WriteLine("choice 9: view Person by state");
                Console.WriteLine("choice 10: Exit From here");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBook=addressBookUtility.addToAddressBook(addressBook);
                        addressBookUtility.DisplayAddressBook(addressBook);
                        break;
                    case 2:
                        addressBook=addressBookUtility.editAddressBook(addressBook);
                        addressBookUtility.DisplayAddressBook(addressBook);
                        break;
                    case 3:
                        addressBook=addressBookUtility.deleteFromAddressBook(addressBook);
                        addressBookUtility.DisplayAddressBook(addressBook);
                        break;
                    case 4:
                        addressBook=addressBookUtility.AddMultiple(addressBook);
                        addressBookUtility.DisplayAddressBook(addressBook);
                        break;
                    case 5:
                        bool checkDuplicate = addressBookUtility.checkDuplicate(addressBook);
                        Console.WriteLine(checkDuplicate);
                        break;
                    case 6:
                        addressBookUtility.sortByName(addressBook);
                        break;
                    case 7:
                        addressBookUtility.SortByCity(addressBook);
                        break;
                    case 8:
                        addressBookUtility.viewByCity(addressBook);
                        break;
                    case 9:
                        addressBookUtility.searchInCity(addressBook);
                        break;
                    default:
                        checkOut = 1;
                        break;
                }
            } while (checkOut == 0);
            addressBookUtility.DisplayAddressBook(addressBook);
                
        } 
        
    }
}
