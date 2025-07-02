namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Pin = 4040;
            int balance = 10000;

            while (true)
            {
                Console.WriteLine("Enter the pin: ");
                int pin = int.Parse(Console.ReadLine());

                if (pin != Pin)
                {
                    Console.WriteLine("The pin that you entered is wrong");
                    continue;
                }
                Console.WriteLine("1.Check your balance \n2.Withdraw money " +
                    "\n3.Deposit Money\n4.To change the pin\n5.Exit");
                Console.WriteLine("Enter your choice");


                int c = int.Parse(Console.ReadLine());


                if (c == 1)
                {
                    Console.WriteLine("The current balance is" + balance);

                }
                else if (c == 2)
                {
                    Console.WriteLine("Enter the amount that you want to withdraw");
                    int withdraw = int.Parse(Console.ReadLine());
                    if (balance >= withdraw)
                    {
                        balance -= withdraw;
                        Console.WriteLine("Your amount of " + withdraw + " is withdrawn");
                        Console.WriteLine("Your current balance is " + balance);
                    }
                    else
                    {
                        Console.WriteLine("You have insufficients to withdraw money");
                    }
                }
                else if (c == 3)
                {
                    Console.WriteLine("Enter the amount to deposit");
                    int dep = int.Parse(Console.ReadLine());
                    balance += dep;
                    Console.WriteLine("The current balance is now " + balance);

                }
                else if (c == 4)
                {
                    Console.WriteLine("Enter the new pin: ");
                    int newpin = int.Parse(Console.ReadLine());
                    Pin = newpin;
                }
                else
                {
                    Console.WriteLine("Thank you for visiting this bank");
                }
            }
        }
    }
}
