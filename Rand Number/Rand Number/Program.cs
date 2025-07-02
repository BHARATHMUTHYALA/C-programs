using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rand_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Enter the number of random numbers to generate: ");
            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine("Wrong input, enter a positive number");
                return;
            }
            Console.WriteLine("Enter the minimum and maximum range");
            if (!int.TryParse(Console.ReadLine(), out int minValue))
            {
                Console.WriteLine("Invalid input: Enter a positive integer");
                return;
            }
            if ((!int.TryParse(Console.ReadLine(), out int maxValue)) || maxValue<=minValue)
            {
                Console.WriteLine("Invalid input: Maximum Value must be greater than Minimum Value");
                return;
            }
            Console.WriteLine($"Generated {count} unique random numbers between {minValue} and {maxValue} :") ;

            int randCount = 1;
            while (randCount <= count)
            {
                int randomNumber = random.Next(minValue, maxValue + 1);
                Console.WriteLine(randomNumber + " ");
                randCount++;
            }
            Console.ReadKey();
        }
    }
}

