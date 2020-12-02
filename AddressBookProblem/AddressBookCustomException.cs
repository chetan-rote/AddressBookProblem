using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
    class AddressBookCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_ADDRESS,
            INVALID_ZIPCODE,
            INVALID_CITY,
            INVALID_STATE,            
            INVALID_PHONENUMBER,
            INVALID_EMAIL,
            INVALID_ADDRESS_BOOK
        }
        public ExceptionType exceptionType;
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookCustomException"/> class.
        /// </summary>
        /// <param name="exceptionType">Type of the exception.</param>
        /// <param name="message">The message.</param>
        public AddressBookCustomException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
