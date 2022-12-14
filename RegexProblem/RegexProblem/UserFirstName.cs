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
        string[] emailsData;
        const string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        const string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        const string emailId = "^[a-zA-Z]+[._-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
        const string mobNumber = "^91[ ]{1}[5-9]{1}[0-9]{9}$";
        const string password = "^(?=.*[!@#$%_])(?=.*[0-9])(?=.*[A-Z])[A-Za-z0-9!@#_$%]{8,}$";
        const string emailsCheck = "^[a-zA-Z]+[.+_-]{0,1}[a-z0-9]+[@][a-zA-Z0-9]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        //public void ValidateFirstName(string input)
        //{
        //    if (Regex.IsMatch(input, firstName))
        //        Console.WriteLine("Your First name is  " + input);
        //    else
        //        Console.WriteLine("Entered name is in invalid format.");
        //}
        //public void UserLastName(string input)
        //{
        //    if (Regex.IsMatch(input, lastName))
        //        Console.WriteLine("Your Last name is  " + input);
        //    else
        //        Console.WriteLine("Entered name is in invalid format.");
        //}
        //public void EmailID(string input)
        //{
        //    if (Regex.IsMatch(input, emailId))
        //        Console.WriteLine("Entered Email is " + input);
        //    else
        //        Console.WriteLine("Entered Email is in Invalid format.");
        //}
        //public void MobNumber(string input)
        //{
        //    if (Regex.IsMatch(input, mobNumber))
        //        Console.WriteLine("Entered Mobile Number is " + input);
        //    else
        //        Console.WriteLine("Invalid mobile number try again.");
        //}
        //public void Password(string input)
        //{
        //    if (Regex.IsMatch(input, password))
        //        Console.WriteLine("Verify your Password :" + input);
        //    else
        //        Console.WriteLine("Entered password is invalid");
        //}
        //public void ReadEmailsData(string filepath)
        //{
        //    var email = File.ReadAllText(filepath);
        //    emailsData = email.Split(",");
        //    EmailData(emailsData);
        //}
        //public void EmailData(string[] input)
        //{
        //    foreach (var email in input)
        //    {
        //        if (Regex.IsMatch(email, emailsCheck))
        //            Console.WriteLine("{0} as Email Id is valid", email);
        //        else
        //            Console.WriteLine("{0} as Email Id is invalid ", email);
        //    }
        //}
        public string ValidateFirstNameUsingLambda(string input) =>
            Regex.IsMatch(input, firstName) ? "Name is Valid" : "Entered Invalid Name";
        public string ValidateLastNameUsingLambda(string input) =>
            Regex.IsMatch(input, lastName) ? "Name is Valid" : "Entered Invalid Name";
        public string ValidateEmailUsingLambda(string input) =>
           Regex.IsMatch(input, emailId) ? "Email is Valid" : "Entered Invalid Email";
        public string ValidateMobileNumberUsingLambda(string input) =>
          Regex.IsMatch(input, mobNumber) ? "Mobile Number is Valid" : "Entered Invalid Mobile Number";
        public string ValidatePasswordUsingLambda(string input) =>
          Regex.IsMatch(input, password) ? "Password is Valid" : "Entered Invalid Password";
        public void ReadEmailsDataUsingLambda(string filepath)
        {
            var email = File.ReadAllText(filepath);
            emailsData = email.Split(",");
            foreach (var data in emailsData)
            {
                if (CallingAllEmailUsingLambda(data))
                {
                    Console.WriteLine("{0} as Email Id is valid", data);
                }
                else
                {
                    Console.WriteLine("{0} as Email Id is invalid ", data);
                }
            }
        }
        public bool CallingAllEmailUsingLambda(string email) =>Regex.IsMatch(email, emailsCheck) ? true : false;
    }
}
