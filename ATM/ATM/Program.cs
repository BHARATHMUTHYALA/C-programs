namespace ATM
{
    class ATM
    {
        public static int pin = 4040;
        public static int balance = 10000;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM!!!!");
            bool isAuthenticated = AuthenticateUser();
            if (isAuthenticated)
            {
                ShowMenu();
            }
            else
            {
                Console.WriteLine("Invalid PIN, please try again");
            }
            Console.ReadKey();
        }
        private static bool AuthenticateUser()
        {
            Console.WriteLine("Enter the PIN");
            int enteredPIN;
            bool isValidPIN = int.TryParse(Console.ReadLine(), out enteredPIN);
            if (isValidPIN && enteredPIN == pin)
            {
                return true;
            }
            return false;
        }

        public static void ShowMenu()
        {
            bool ContinueRunning = true;

            while (ContinueRunning)
            {
                Console.WriteLine("\n1. Check Bank Balance");
                Console.WriteLine("\n2.Withdraw Money");
                Console.WriteLine("\n3.Deposit Money");
                Console.WriteLine("\n4.Change your PIN");
                Console.WriteLine("\n5.Exit");
                Console.WriteLine("Enter your choice");

                int choice;
                bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

                if (!isValidChoice || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Etnter a number within the given choice range");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        WithdrawMoney();
                        break;
                    case 3:
                        DepositMoney();
                        break;
                    case 4:
                        ChangePIN();
                        break;
                    case 5:
                        ContinueRunning = false;
                        Console.WriteLine("Thank you for using this ATM");
                        break;
                }
            }
        }
        public static void CheckBalance()
        {
            Console.WriteLine($"The current balance in your account is {balance}");
        }
        public static void WithdrawMoney()
        {
            Console.WriteLine("Enter the amont to withdraw: ");
            int amount;
            bool isValidAmount = int.TryParse(Console.ReadLine(),out amount);
            if(!isValidAmount || amount<0 || amount % 100 != 0)
            {
                Console.WriteLine("Please enter amount that is greater than 0 " +
                    "make sure that the amount is in the multiples of 100");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance, Cannot make withdrawal");
                return;

            }
            balance-=amount;
            Console.WriteLine("Please collect the cash: "+ amount);
            Console.WriteLine("The current balance is: "+ balance);
        }
        public static void DepositMoney()
        {
            Console.WriteLine("Enter the amount to deposit");
            int amount;
            bool isValidAmount = int.TryParse(Console.ReadLine(), out amount);
            if(!isValidAmount || amount<=0)
            {
                Console.WriteLine("Please enter an amount that is greater than 0");
                return;
            }
            balance += amount;
            Console.WriteLine("The current balance is now: "+balance);
        }
        private static void ChangePIN()
        {
            Console.WriteLine("Enter the Current PIN");
            int CurrentPIN;
            bool isValidPIN = int.TryParse(Console.ReadLine(),out CurrentPIN);
            if (CurrentPIN != pin)
            {
                Console.WriteLine("Imcorrect PIN");
                return ;
            }
            Console.WriteLine("Enter the correct PIN");
            int newPIN;
            bool isValidNewPin = int.TryParse(Console.ReadLine(), out newPIN);
            if(newPIN<1000 || newPIN > 9999)
            {
                Console.WriteLine("Please choose a 4 digit number ");
                return;
            }
            pin = newPIN;
            Console.WriteLine("PIN is updated successfully");
        }

    }
}