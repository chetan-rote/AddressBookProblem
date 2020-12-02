using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    class AddressBookRepo
    {
        List<ContactModel> contacts = new List<ContactModel>();
        RegexValidator regexValidator = new RegexValidator();
        

        /// <summary>
        /// Adds the contact.
        /// </summary>
        public void AddContact()
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            regexValidator.ValidateFirstName(firstName);

            Console.WriteLine("\nEnter Last Name: ");
            string lastName = Console.ReadLine();
            regexValidator.ValidateLastName(lastName);

            Console.WriteLine("\nEnter Address: ");
            string address = Console.ReadLine();
            regexValidator.ValidateAddress(address);

            Console.WriteLine("\nEnter Zipcode: ");
            string zipCode = Console.ReadLine();
            regexValidator.ValidateZipCode(zipCode);

            Console.WriteLine("\nEnter City: ");
            string city = Console.ReadLine();
            regexValidator.ValidateCity(city);

            Console.WriteLine("\nEnter State: ");
            string state = Console.ReadLine();
            regexValidator.ValidateState(state);

            Console.WriteLine("\nEnter Phone number: ");
            string phoneNo = Console.ReadLine();
            regexValidator.ValidatePhoneNumber(phoneNo);

            Console.WriteLine("\nEnter Email: ");
            string email = Console.ReadLine();
            regexValidator.ValidateEmail(email);
            ContactModel contactModel = new ContactModel(firstName, lastName, address, zipCode, city, state, phoneNo, email);
            
            if (CheckDuplicate(firstName, lastName) == false)
            {
                contacts.Add(contactModel);
                Console.WriteLine("Contact added successfully.");
            }
            else
            {
                Console.WriteLine("Contact already Exists") ;
            }
        }

        public bool CheckDuplicate(string firstName, string lastName)
        {            
            foreach (ContactModel contact in contacts.FindAll(name => name.FirstName.Equals(firstName) && name.LastName.Equals(lastName)))
            {
                return true;
            }
            return false;
        }

        public void DisplayContact()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No Contacts to display");
            }
            else
            {
                foreach (var display in contacts)
                {
                    Console.WriteLine(display);
                }
            }
        }
    }
}
