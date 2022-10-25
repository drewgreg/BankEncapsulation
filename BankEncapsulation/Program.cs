namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var DepositAmount = double.Parse(Console.ReadLine());

            account.Deposit(DepositAmount);

            Console.WriteLine($"Your balance is now ${account.GetBalance()}");
        }
    }
}
