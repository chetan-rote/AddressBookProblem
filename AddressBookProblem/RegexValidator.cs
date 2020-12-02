using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBookProblem
{
    public class RegexValidator
    {
        public const string FIRST_NAME = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string LAST_NAME = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string ADDRESS = "^[a-zA-Z0-9_ ]*$";
        public const string ZIPCODE = "^[0-9]{6}$";
        public const string CITY = "^[A-Z]{1}[A-Za-z]{3,}$";
        public const string STATE = "^[a-zA-Z0-9_ ]*$";
        public const string PHONE_NUMBER = "^[7-9][0-9]{9}$";
        public const string EMAIL = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9]" +
                                    @"(?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";

        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="firstname">The firstname.</param>
        /// <exception cref="AddressBookProblem.AddressBookCustomException">Invalid First name</exception>
        public void ValidateFirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, FIRST_NAME))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_FIRST_NAME, "Invalid First name");
            }
        }
        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <exception cref="AddressBookProblem.AddressBookCustomException">Invalid Last name</exception>
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, LAST_NAME))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_LAST_NAME, "Invalid Last name");
            }
        }
        /// <summary>
        /// Validates the address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <exception cref="AddressBookProblem.AddressBookCustomException">Invalid address</exception>
        public void ValidateAddress(string address)
        {
            if (Regex.IsMatch(address, ADDRESS))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_ADDRESS, "Invalid address");
            }
        }
        /// <summary>
        /// Validates the zip code.
        /// </summary>
        /// <param name="zipCode">The zip code.</param>
        /// <exception cref="AddressBookProblem.AddressBookCustomException">Invalid Zipcode</exception>
        public void ValidateZipCode(string zipCode)
        {
            if (Regex.IsMatch(zipCode, ZIPCODE))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_ZIPCODE, "Invalid Zipcode");
            }
        }
        /// <summary>
        /// Validates the city.
        /// </summary>
        /// <param name="city">The city.</param>
        /// <exception cref="AddressBookProblem.AddressBookCustomException">Invalid City</exception>
        public void ValidateCity(string city)
        {
            if (Regex.IsMatch(city, CITY))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_CITY, "Invalid City");
            }
        }

        public void ValidateState(string state)
        {
            if (Regex.IsMatch(state, STATE))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_STATE, "Invalid State");
            }
        }
        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="phoneNo">The phone no.</param>
        /// <exception cref="AddressBookProblem.AddressBookCustomException">Invalid Phone no</exception>
        public void ValidatePhoneNumber(string phoneNo)
        {
            if (Regex.IsMatch(phoneNo, PHONE_NUMBER))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_PHONENUMBER, "Invalid Phone no");
            }
        }
        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <exception cref="AddressBookProblem.AddressBookCustomException">Invalid Email address</exception>
        public void ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_EMAIL, "Invalid Email address");
            }
        }
    }
}
