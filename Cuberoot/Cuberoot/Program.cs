namespace Cuberoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            double cuberoot = Convert.ToInt32(Math.Pow(n, 1.0 / 3));
            Console.WriteLine(cuberoot);
            Console.ReadKey();
        }
    }
}
