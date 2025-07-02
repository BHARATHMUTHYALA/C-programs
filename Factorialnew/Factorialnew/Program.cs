namespace Factorialnew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n here: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of r here: ");
            int r= int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n)/factorial(n-r));
            Console.ReadKey();
        }
        public static int factorial(int x)
        {
            int p = 1;
            if (x == 0)
            {
                return 1;
            }
            for(int i = 1; i <= x; i++)
            {
                p *= i;
            }
            return p;
        }
    }
}
