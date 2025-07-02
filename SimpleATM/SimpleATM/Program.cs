namespace SimpleATM
{
    internal class Program
    {
       
    public class Hello
    {
        public static void Main()
        {
            int Pin = 40;
            int balance = 1000;
            while (true)
            {
                Console.Write("Enter the pin: ");
                int pin = int.Parse(Console.ReadLine());
                if (pin != Pin)
                {
                    Console.WriteLine("Incorrect pin");
                    continue;
                }
                Console.WriteLine("1. To check balance\n2. To withdraw money\n3. To deposit money\n4. To change the pin\n5. Exit");
                Console.Write("Enter your choice: ");
                int c = int.Parse(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine("The current balance is " + balance);
                }
                else if (c == 2)
                {
                    Console.Write("Enter the amount to withdraw: ");
                    int wdr = int.Parse(Console.ReadLine());
                    if (balance >= wdr)
                    {
                        balance -= wdr;
                        Console.WriteLine("Please collect the cash: " + wdr);
                        Console.WriteLine("The current balance is now: " + balance);
                    }
                    else
                    {
                        Console.WriteLine("Amount insufficient");
                    }
                }
                else if (c == 3)
                {
                    Console.Write("Enter the amount to deposit: ");
                    int dep = int.Parse(Console.ReadLine());
                    balance += dep;
                    Console.WriteLine("The current balance is now: " + balance);
                }
                else if (c == 4)
                {
                    Console.Write("Enter your new pin: ");
                    int newpin = int.Parse(Console.ReadLine());
                    Pin = newpin;
                }
                else
                {
                    Console.WriteLine("Thank you");
                    break;
                }
            }
            Console.ReadKey();
        }
    }


}
}
