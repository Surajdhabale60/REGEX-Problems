namespace RegexProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcone To User Registration Problem Statement");
            UserFirstName userFirstName = new UserFirstName();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("Select option you want to enter.");
                Console.WriteLine("1.First Name");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your First name");
                        string firstName = Console.ReadLine();
                        userFirstName.ValidateFirstName(firstName);
                        break;
                }
            }
        }
    }
}