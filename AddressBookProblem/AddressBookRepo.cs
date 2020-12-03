using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    public class AddressBookRepo
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
                Console.WriteLine("Contact already Exists");
            }
        }
        /// <summary>
        /// Checks for the duplicate.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public bool CheckDuplicate(string firstName, string lastName)
        {
            foreach (ContactModel contact in contacts.FindAll(name => name.FirstName.Equals(firstName) && name.LastName.Equals(lastName)))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Displays the contact.
        /// </summary>
        public void DisplayContact()
        {
            // Checks for the count of contacts in List
            if (contacts.Count == 0)
            {
                Console.WriteLine("No Contacts to display");
            }
            else
            {
                // Iterates the List to display contacts.
                foreach (var display in contacts)
                {
                    Console.WriteLine("First Name   : " + display.FirstName);
                    Console.WriteLine("Last Name    : " + display.LastName);
                    Console.WriteLine("Address      : " + display.Address);
                    Console.WriteLine("Zipcode      : " + display.ZipCode);
                    Console.WriteLine("City         : " + display.City);
                    Console.WriteLine("State        : " + display.State);
                    Console.WriteLine("Phone Number : " + display.PhoneNumber);
                    Console.WriteLine("\nEmail        : " + display.Email);
                }
            }
        }
        /// <summary>
        /// Edits the contact.
        /// </summary>
        public void EditContact()
        {            
            Console.WriteLine("Enter the first name of person whose data to be modified: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the email of person whose data to be modified: ");
            string email = Console.ReadLine();
            // Iterates the List with contacts.
            for (int index = 0; index < contacts.Count; index++)
            {
                // Checks with first name and email present in the data.
                if (contacts[index].FirstName.Equals(firstName) && contacts[index].Email.Equals(email))
                {
                    EditContactList(contacts[index]);
                }
                else
                {
                    Console.WriteLine("No such contact present.");
                }
            }
        }
        /// <summary>
        /// Edits the contact list.
        /// </summary>
        /// <param name="contact">The contact.</param>
        public void EditContactList(ContactModel contact)
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            regexValidator.ValidateFirstName(firstName);
            contact.FirstName = firstName;

            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            regexValidator.ValidateLastName(lastName);
            contact.LastName = lastName;

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            regexValidator.ValidateAddress(address);
            contact.Address = address;

            Console.WriteLine("Enter Zipcode: ");
            string zipCode = Console.ReadLine();
            regexValidator.ValidateZipCode(zipCode);
            contact.ZipCode = zipCode;

            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();
            regexValidator.ValidateCity(city);
            contact.City = city;

            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine();
            regexValidator.ValidateState(state);
            contact.State = state;

            Console.WriteLine("Enter Phone Number");
            string phoneNo = Console.ReadLine();
            regexValidator.ValidatePhoneNumber(phoneNo);
            contact.PhoneNumber = phoneNo;

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            regexValidator.ValidateEmail(email);
            contact.Email = email;
        }
        /// <summary>
        /// Deletes the contact.
        /// </summary>
        public void DeleteContact()
        {
            Console.WriteLine("Enter the first name of person whose data to be modified: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the email of person whose data to be modified: ");
            string email = Console.ReadLine();
            // Iterates the List with contacts.
            for (int index = 0; index < contacts.Count; index++)
            {
                // Checks with first name and email present in the data.
                if (contacts[index].FirstName.Equals(firstName) && contacts[index].Email.Equals(email))
                {
                    contacts.RemoveAt(index);
                    Console.WriteLine("Contact Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine("No such contact present.");
                }
            }
        }
        /// <summary>
        /// Addresses the book menu.
        /// </summary>
        public void ContactMenu()
        {
            int loop = 1;
            MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
            while (loop == 1)
            {
                Console.WriteLine("\nEnter Your Choice");
                Console.WriteLine("\n1. Add Contact. \n2. Display \n3. Edit Contact. \n4. Delete Contact. \n5. To addressbook menu." +
                                  " \n6. Exit.");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        DisplayContact();
                        break;
                    case 3:
                        EditContact();
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 5:
                        multipleAddressBook.BookMenu();
                        break;
                    case 6:
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
