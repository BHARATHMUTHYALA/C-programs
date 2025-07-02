
namespace Factorial
{
    internal class Program
    {
        static int CalculateFactorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        static int CalculateNpr(int n, int r)
        {
            int npr = 0;
            int fact1 = 0;
            int fact2 = 0;

            fact1 = CalculateFactorial(n);
            fact2 = CalculateFactorial(n - r);
            npr = fact1 / fact2;

            return npr;
        }
        static void Main(string[] args)
        {
            int npr = 0;
            int n = 0;
            int r = 0;
            Console.WriteLine("Enter the value of n: ");
            string userinput = Console.ReadLine();
            n = int.Parse(userinput);

            Console.WriteLine("Enter the value of r: ");
            string rinput = Console.ReadLine();
            r = int.Parse(rinput);

            npr = CalculateNpr(n, r);
            Console.WriteLine("The required factorial is: " + npr);
            Console.ReadKey();
        }
    }
}
