namespace noMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find the square root");

            double sqrinput = Convert.ToDouble(Console.ReadLine());
            double sqrresult =CalculateSquareRoot(sqrinput);

            Console.WriteLine($"Square root of the entered number is {sqrresult}");

            Console.WriteLine("Enter a number to find the absolute value");

            double absinput = Convert.ToDouble(Console.ReadLine());
            double absresult = FindAbsoluteValue(absinput);

            Console.WriteLine($"Absolute value of the entered number is  {absresult}");

            Console.ReadKey();

        }
        static double FindAbsoluteValue(double number)
            {
                if (number < 0)
                {
                    return number * -1;
                }
                return number;
            }

        static double CalculateSquareRoot(double number)
        {
            if (number < 0)
            {
                Console.WriteLine("Cannot calculate Square root for a negative number");
            }
            return Math.Ceiling(Math.Pow(number,1.0/2));

        }
    }
}
