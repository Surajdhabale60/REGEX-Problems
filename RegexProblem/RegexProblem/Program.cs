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
                Console.WriteLine(" 1.First Name\n 2.Last Name");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your First name");
                        string firstName = Console.ReadLine();
                        name.ValidateFirstName(firstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter your Last name");
                        string lastName = Console.ReadLine();
                        name.UserLastName(lastName);
                        break;


                }
            }
        }
    }
}