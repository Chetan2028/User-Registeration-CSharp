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

        public void ValidateFirstName(string firstName)
        {
            bool result =  Regex.IsMatch(firstName, REGEX_PATTERN_FOR_FIRST_NAME);
            if (result)
            {
                Console.WriteLine(firstName + " is valid");
                nlog.LogDebug("Debug Successfull : ValidateFirstName()");
                nlog.LogInfo("First name macthes the required  criteria");
            }
            else
            {
                Console.WriteLine(firstName+" is invalid");
                nlog.LogDebug("Debug UnSuccessfull : ValidateFirstName()");
                nlog.LogInfo("First name does not macthes the required  criteria");
            }
        }
    }
}
