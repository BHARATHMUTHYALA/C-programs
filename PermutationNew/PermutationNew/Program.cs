namespace PermutationNew
{
    internal class Program
    {
       
        class HelloWorld
        {
        public static int factorial(int x)
        {
            int p = 1;
            if (x == 0) return 1;
            for (int i = 1; i <= x; i++)
            {
                p *= i;
            }
            return p;
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n) / factorial(n - r));
                Console.ReadKey();
        }

       }    


    }
}
