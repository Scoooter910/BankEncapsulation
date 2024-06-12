namespace BankEncapsulation
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            account1.Deposit(5000);
            account1.GetBalance();
            account1.Withdraw(2000);
            account1.GetBalance();
            Console.WriteLine("Welcome, Please enter an option:");
            Console.Write("Deposit");
            Console.WriteLine();
            Console.Write("Withdraw");
            Console.WriteLine();
            Console.Write("Get Balance");
            Console.WriteLine();

            string answer = Console.ReadLine();
            if (answer == "Deposit")

            {
                Console.WriteLine("How much would you like to deposit?");
                double depositAmount = double.Parse(Console.ReadLine());
                account1.Deposit(depositAmount);
            }
            else if (answer == "Withdraw")
            {
                Console.WriteLine("How much would you like to withdraw?");
                double withdrawAmount = double.Parse(Console.ReadLine());
                account1.Withdraw(withdrawAmount);

            }
            else if (answer == "Get Balance")
            {

                Console.WriteLine("Balance");
                var amount = account1.GetBalance();
                Console.WriteLine($"Your balance is:{amount}");
            }
        }
    }
}
