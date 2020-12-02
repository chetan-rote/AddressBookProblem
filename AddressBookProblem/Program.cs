/**********************************************************************************
 *  Purpose: This program allows user to do different operations on address book
 *  user can add, delete and edit the contacts.
 *
 *
 *  @author  Chetan Rote
 *  @version 1.0
 *  @since   01-12-2020
 **********************************************************************************/
using System;

namespace AddressBookProblem
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem.");
            AddressBookRepo repo = new AddressBookRepo();
            repo.AddContact();
            repo.DisplayContact();
        }
    }
}
