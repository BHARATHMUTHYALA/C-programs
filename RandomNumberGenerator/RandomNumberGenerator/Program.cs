namespace RandomNumberGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Enter the number of random numbers to generate: ");
            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine("Invalid input, Enter a valid positive number");
                return;
            }
            Console.WriteLine("Enter the minimum value of the range: ");
            if (!int.TryParse(Console.ReadLine(), out int minvalue))
            {
                Console.WriteLine("Invalid input,enter a valid number");
                return;
            }
            Console.WriteLine("Enter the maximum value of the range");

            if (!int.TryParse(Console.ReadLine(), out int maxvalue)|| maxvalue<=minvalue)
            {
                Console.WriteLine("Maximum Value must be greater than minimum value");
                return;
            }

            Console.WriteLine($"Generated {count} number of unique numbers between {minvalue} and {maxvalue}");

            int randcount = 1;
            while (randcount <= count)
            {
                int randomnumber = random.Next(minvalue, maxvalue+1);
                Console.WriteLine(randomnumber+ " ");
                randcount++;
            }
            Console.ReadKey();

        }
    }
}
