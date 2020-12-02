using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    class ContactModel
    {
        /// Variables.
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string phoneNumber;
        private string email;
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        /// <exception cref="System.ArgumentNullException">FirstName - Value for first name cannot be null or empty</exception>
        public string FirstName
        {
            get 
            {
                return this.firstName;
            }
            set
            {
                if (this.firstName == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(FirstName),"Value for first name cannot be null or empty");
                }
            }
        }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        /// <exception cref="System.ArgumentNullException">LastName - Value for last name cannot be null or empty</exception>
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (this.lastName == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(LastName), "Value for last name cannot be null or empty");
                }
            }
        }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Address - Value for Address cannot be null or empty</exception>
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (this.address == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(Address), "Value for Address cannot be null or empty");
                }
            }
        }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        /// <exception cref="System.ArgumentNullException">City - Value for City cannot be null or empty</exception>
        public string City 
        {
            get
            {
                return this.city;
            }
            set
            {
                if (this.city == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(City), "Value for City cannot be null or empty");
                }
            }
        }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        /// <exception cref="System.ArgumentNullException">state - Value for state cannot be null or empty</exception>
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (this.state == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(state), "Value for state cannot be null or empty");
                }
            }
        }
        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        /// <exception cref="System.ArgumentNullException">ZipCode - Value for zipcode cannot be null or empty</exception>
        public string ZipCode 
        {
            get
            {
                return this.zipCode;
            }
            set
            {
                if (this.zipCode == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(ZipCode), "Value for zipcode cannot be null or empty");
                }
            }
        }
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        /// <exception cref="System.ArgumentNullException">PhoneNumber - Value for Phone no cannot be null or empty</exception>
        public string PhoneNumber 
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (this.phoneNumber == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(PhoneNumber), "Value for Phone no cannot be null or empty");
                }
            }
        }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Email - Email cannot be null or empty</exception>
        public string Email 
        {
            get
            {
                return this.email;
            }
            set
            {
                if (this.email == value)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(Email), "Email cannot be null or empty");
                }
            }
        }
    }
}
