using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    public class MultipleAddressBook
    {
        AddressBookRepo addressBookRepo = new AddressBookRepo();
        public Dictionary<string, AddressBookRepo> addressBooks = new Dictionary<string, AddressBookRepo>();
        Dictionary<string, AddressBookRepo> AddressBookDictionary { get { return addressBooks; } }
        /// <summary>
        /// Adds the new address book.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="contactModels">The contact models.</param>
        public void AddNewAddressBook()
        {
            Console.WriteLine("Enter the address book name: ");
            string addressBookName = Console.ReadLine();
            if (this.addressBooks.ContainsKey(addressBookName))
            {
                Console.WriteLine("Address book already exists");
                addressBookRepo.ContactMenu();
            }
            else
            {
                Console.WriteLine("New Address book created: ");
                addressBooks.Add(addressBookName, addressBookRepo);
            }
        }
        /// <summary>
        /// Displays the address book.
        /// </summary>
        public void DisplayAddressBook()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No address book to display");
            }
            else
            {
                foreach (var book in addressBooks)
                {
                    Console.WriteLine(book.Key);
                }
            }
        }
        /// <summary>
        /// Able user to use the address book.
        /// </summary>
        public void UseAddressBook()
        {
            Console.WriteLine("Enter Address book name: ");
            string addressBookName = Console.ReadLine();
            if (addressBooks.ContainsKey(addressBookName))
            {
                addressBooks[addressBookName].ContactMenu();
            }
            else
            {
                Console.WriteLine("Address book does not exists");
            }
        }
        /// <summary>
        /// Menu for the address book.
        /// </summary>
        public void BookMenu()
        {
            int loop = 1;
            while (loop == 1)
            {
                Console.WriteLine("\nEnter your choice");
                Console.WriteLine("\n1. Add Address Book. \n2. Use Address Book. \n3. Display AddressBooks. \n4. Exit.");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddNewAddressBook();
                        break;
                    case 2:
                        UseAddressBook();
                        break;
                    case 3:
                        DisplayAddressBook();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
