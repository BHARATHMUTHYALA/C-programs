namespace Permutations
{
    internal class Program
    {
        static int CalcualteFactorial(int n)
        {
            int fact = 1;
            for(int i = 2; i <= n; i++)
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
            fact1= CalcualteFactorial(n);
            fact2 = CalcualteFactorial(n-r);
            npr = fact1 / fact2;

            return npr;
        }
        static void Main(string[] args)
        {
            int npr = 0;
            int n = 0;
            int r = 0;

            Console.WriteLine("Enter the value of n:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of r:");
            r = int.Parse(Console.ReadLine());

            npr = CalculateNpr(n, r);
            Console.WriteLine("Npr "+ npr);
            Console.ReadKey();

        }
    }
}
