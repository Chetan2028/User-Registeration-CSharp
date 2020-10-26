using System;

namespace UserRegisteration
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Creates a instance of Validator class
            Validator validator = new Validator();

            Console.WriteLine("Enter the first name");
            string firstName = Console.ReadLine();
            validator.ValidateFirstName(firstName);

            Console.WriteLine("Enter the last name");
            string lastName = Console.ReadLine();
            validator.ValidateLastName(lastName);

            Console.WriteLine("Enter the email");
            string email = Console.ReadLine();
            validator.ValidateEmailAddress(email);

            Console.WriteLine("Enter your mobile number");
            string mobileNumber = Console.ReadLine();
            validator.ValidateMobileNumber(mobileNumber);

            Console.WriteLine("Enter your Password");
            string passwordRule1 = Console.ReadLine();
            validator.ValidatePasswordRule1(passwordRule1);
        }
    }
}
