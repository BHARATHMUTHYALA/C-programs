namespace MultiIheritanceBanking
{
    class Account
    {
        public int accountnumber;
        public string accountholdername;
        public double balance;

        public Account(int accountnumber, string accountholdername, double balance)
        {
            this.accountnumber = accountnumber;
            this.accountholdername = accountholdername;
            this.balance = balance;
        }

        public void deposit(double amt)
        {
            this.balance += amt;
            Console.WriteLine($"Amount deposited : {amt}\n Current balance:{this.balance}");
        }
        public void withdraw(double amt)
        {
            if (this.balance >= amt)
            {
                this.balance -= amt;
                Console.WriteLine($"The amount withdrawn is{amt} and the current balance is {this.balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void display()
        {
            Console.WriteLine($"Account Number: {this.accountnumber}, Holder:{this.accountholdername}, Balance:{this.balance}");

        }
    }
    interface Interest
    {
        void calculateinterest();
    }
    class SavingsAccount : Account, Interest
    {
        double interestrate;
        public SavingsAccount(int accountnumber, string accountholdername, double balance, double interestrate) : base(accountnumber, accountholdername, balance)
        {
            this.interestrate = interestrate;
        }
        public void calculateinterest()
        {
            Console.WriteLine("Interest: " + balance * (this.interestrate / 100));
        }
    }

    class Hello
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount(1001, "Rama Krishna", 5000.0, 5.0);
            sa.deposit(1000.0);
            sa.display();
            sa.calculateinterest();
            sa.display();
            Console.ReadLine();
        }
    }

}
