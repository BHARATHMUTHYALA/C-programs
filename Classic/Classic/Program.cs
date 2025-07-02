namespace Classic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messages.Hello();
            Messages.Bye();
            Console.ReadKey();
        }
    }

    static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello!, welcome to the program");
        }
        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }
        public static void Bye()
        {
            Console.WriteLine("Thank you Bye");
        }
    }
}
