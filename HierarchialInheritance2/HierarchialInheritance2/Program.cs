namespace HierarchialInheritance2
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
            Console.WriteLine($"The amount deposited: {amt}\n Current balance is: {this.balance}");
        }
        public void withdraw(double amt)
        {
            if (this.balance >= amt)
            {
                this.balance -= amt;
                Console.WriteLine($"The total amount that is withdrawn is {amt} \n Current balance is {this.balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public void display()
        {
            Console.WriteLine($"Account Number is {this.accountnumber},Holder is {this.accountholdername}, Balance is {this.balance}");
        }
    }
    class SavingsAccount : Account
    {
        double interestrate;
        public SavingsAccount(int accountnumber, string accountholdername, double balance, double interestrate) :
        base(accountnumber, accountholdername, balance)
        {
            this.interestrate = interestrate;
        }
        public void addinterest()
        {
            balance += balance * (this.interestrate / 100);
        }
    }
    class CheckingsAccount : Account
    {
        double overdraftlimit;
        public CheckingsAccount(int accountnumber, string accountholdername, double balance, double overdraftlimit) :
        base(accountnumber, accountholdername, balance)
        {
            this.overdraftlimit = overdraftlimit;
        }
        public void writecheck(double amt)
        {
            if (balance + overdraftlimit > amt)
            {
                balance -= amt;
            }
            else
            {
                Console.WriteLine("Overdraft Limit exceeded");
            }
        }
    }
    class Hello
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount(1001, "Rama Krishna", 5000.0, 5.0);
            sa.deposit(1000.0);
            sa.display();
            sa.addinterest();
            sa.display();

            CheckingsAccount ca = new CheckingsAccount(2001, "Sita Devi", 3000.0, 1000.0);
            ca.deposit(500.0);
            ca.display();
            ca.writecheck(2000.0);
            ca.display();

            Console.ReadKey();
        }
    }
}
