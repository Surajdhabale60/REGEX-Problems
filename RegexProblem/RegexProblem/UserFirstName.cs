using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class UserFirstName
    {
        const string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        const string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        const string emailId = "^[a-zA-Z]+[._-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
        public void ValidateFirstName(string input)
        {
            if (Regex.IsMatch(input,firstName))
                Console.WriteLine("Your First name is  " + input);
            else
                Console.WriteLine("Entered name is in invalid format.");
        }
        public void UserLastName(string input)
        {
            if (Regex.IsMatch(input, lastName))
                Console.WriteLine("Your Last name is  " + input);
            else
                Console.WriteLine("Entered name is in invalid format.");
        }
        public void EmailID(string input)
        {
            if (Regex.IsMatch(input, emailId))
                Console.WriteLine("Entered Email is " + input);
            else
                Console.WriteLine("Entered Email is in Invalid format.");
        }
    }
}
