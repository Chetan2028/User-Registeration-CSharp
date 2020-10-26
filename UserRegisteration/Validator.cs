using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegisteration
{
    class Validator
    {
        /// Create an instance of Nlog Class
        Nlog nlog = new Nlog();

        private static string REGEX_PATTERN_FOR_FIRST_NAME = "^[A-Z][a-zA-Z]{2,}$";
        private static string REGEX_PATTERN_FOR_LAST_NAME = "^[A-Z][a-zA-Z]{2,}$";

        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public void ValidateFirstName(string firstName)
        {
            bool result = Regex.IsMatch(firstName, REGEX_PATTERN_FOR_FIRST_NAME);
            if (result)
            {
                Console.WriteLine(firstName + " is valid");
                nlog.LogDebug("Debug Successfull : ValidateFirstName()");
                nlog.LogInfo("First name macthes the required  criteria");
            }
            else
            {
                Console.WriteLine(firstName + " is invalid");
                nlog.LogDebug("Debug UnSuccessfull : ValidateFirstName()");
                nlog.LogInfo("First name does not macthes the required  criteria");
            }
        }

        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, REGEX_PATTERN_FOR_LAST_NAME))
            {
                Console.WriteLine(lastName + " is valid");
                nlog.LogDebug("Debug Successfull : ValidateLastName method");
                nlog.LogInfo("Last name matches the required  criteria");
            }
            else
            {
                Console.WriteLine(lastName + " is invalid");
                nlog.LogDebug("Debug UnSuccessfull : ValidateLastName()");
                nlog.LogInfo("Last name does not macthes the required  criteria");
            }
        }
    }
}
