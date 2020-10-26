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
        private static string REGEX_PATTERN_FOR_EMAIL = "^[a-z]{3,}[.-+]?[0-9]*[@]{1}[a-zA-Z0-9]*[.]{1}com[.]?[a-z]{2,}$"; /// ^[a-z]{3,}[.][a-z]*[@][a-z]{2,}[.][a-z]{2,}[.][a-z]*$
        private static string REGEX_PATTERN_FOR_MOBILE_NUMBER = "^[1-9]{2}[ ][1-9][0-9]{9}";
        private static string REGEX_PATTERN_FOR_PASSWORD= "^(?=.*[!@#$%^&*]){1}(?=.*\\d)(?=.*[A-Z]).{8,}$";

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
                nlog.LogInfo("First name matches the required  criteria");
            }
            else
            {
                Console.WriteLine(firstName + " is invalid");
                nlog.LogDebug("Debug UnSuccessfull : ValidateFirstName()");
                nlog.LogInfo("First name does not matches the required  criteria");
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
                nlog.LogDebug("Debug Successfull : ValidateLastName()");
                nlog.LogInfo("Last name matches the required  criteria");
            }
            else
            {
                Console.WriteLine(lastName + " is invalid");
                nlog.LogDebug("Debug UnSuccessfull : ValidateLastName()");
                nlog.LogInfo("Last name does not matches the required  criteria");
            }
        }

        /// <summary>
        /// Validates the email address.
        /// </summary>
        /// <param name="email">The email.</param>
        public void ValidateEmailAddress(string email)
        {
            if (Regex.IsMatch(email, REGEX_PATTERN_FOR_EMAIL))
            {
                Console.WriteLine(email + " is valid ");
                nlog.LogDebug("Debug Successfull : ValidateEmail method");
                nlog.LogInfo("Email matches the required  criteria");
            }
            else
            {
                Console.WriteLine(email + " is invalid");
                nlog.LogDebug("Debug UnSuccessfull : ValidateEmail()");
                nlog.LogInfo("Email does not matches the required  criteria");
            }
        }

        /// <summary>
        /// Validates the mobile number.
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        public void ValidateMobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber,REGEX_PATTERN_FOR_MOBILE_NUMBER))
            {
                Console.WriteLine(mobileNumber + " is valid");
                nlog.LogDebug("Debug Successfull : Validatemobilenumber");
                nlog.LogInfo("Mobile number matches the required  criteria");
            }
            else
            {
                Console.WriteLine(mobileNumber + " is invalid");
                nlog.LogDebug("Debug UnSuccessfull : Validatemobilenumber()");
                nlog.LogInfo("Mobile number does not matches the required  criteria");
            }
        }

        /// <summary>
        /// Validates the password to check for minimum 8 characters and atleast one upper case character and atleast one number
        /// </summary>
        /// <param name="password">The password.</param>
        public void ValidatePassword(string password)
        {
            if (Regex.IsMatch(password,REGEX_PATTERN_FOR_PASSWORD))
            {
                Console.WriteLine(password + " is valid");
                nlog.LogDebug("Debug Successfull : ValidatePasswordRule1()");
                nlog.LogInfo("Password matches the required  criteria");
            }
            else
            {
                Console.WriteLine(password + " is invalid");
                nlog.LogDebug("Debug UnSuccessfull : ValidatePasswordRule1()");
                nlog.LogInfo("Password does not matches the required  criteria");
            }
        }
    }
}
