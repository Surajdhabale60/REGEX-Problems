namespace RegexProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcone To User Registration Problem Statement");
            UserFirstName name = new UserFirstName();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("Select option you want to enter.");
                Console.WriteLine(" 1.First Name\n 2.Last Name\n 3.Email ID\n 4.Mobile Number\n 5.Password\n 6.Validate Emails\n 7.Using Lambda Validating All");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
               {
                    case 1:
                        Console.WriteLine("Enter your First name");
                        string firstName = Console.ReadLine();
                        // name.ValidateFirstName(firstName);
                        string result = name.ValidateFirstNameUsingLambda(firstName);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        Console.WriteLine("Enter your Last name");
                        string lastName = Console.ReadLine();
                        // name.ValidateLastName(lastName);
                        string resultt = name.ValidateLastNameUsingLambda(lastName);
                        Console.WriteLine(resultt);
                        break;
                    case 3:
                        Console.WriteLine("Enter your Email Id");
                        string email = Console.ReadLine();
                        // name.ValidateEmail(email);
                        string vald = name.ValidateEmailUsingLambda(email);
                        Console.WriteLine(vald);
                        break;
                    case 4:
                        Console.WriteLine("Enter your Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        // name.ValidateMobileNumber(mobileNumber);
                        string mobile = name.ValidateMobileNumberUsingLambda(mobileNumber);
                        Console.WriteLine(mobile);
                        break;
                    case 5:
                        Console.WriteLine("Enter your Password");
                        string password = Console.ReadLine();
                        //name.ValidatePassword(password);
                        string pass = name.ValidatePasswordUsingLambda(password);
                        Console.WriteLine(pass);
                        break;
                    case 6:
                        string filepath = @"C:\Users\suraj\source\repos\217 .Net\REGEX-User-Registration-Problems\RegexProblem\RegexProblem\Email.txt";
                        // name.ReadEmailsData(emailsFilePath);
                        name.ReadEmailsDataUsingLambda(filepath);
                        break;
                    case 7:
                        name.CallingAllEmailUsingLambda("Suraj");
                        Console.WriteLine("Enter Below Data");
                        break;
                }
            }
        }
    }
}