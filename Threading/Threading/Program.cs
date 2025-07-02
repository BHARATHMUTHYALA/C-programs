namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread(() => Countdown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));
            thread1.Start();
            thread2.Start();

            Console.WriteLine("Main Thread is complete");

            Console.ReadKey();
        }
        static void Countdown(String name)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Timer #1: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete");


        }
        static void CountUp(String name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Timer #2: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete");

        }
    }
}
