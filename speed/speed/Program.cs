using System;
namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed of the object in (m/s): ");
            double speed = Convert.ToDouble(Console.ReadLine());
            if (speed <= 0)
            {
                Console.WriteLine("Invalid input enter a positive speed");
                return;
            }
            Console.WriteLine("Enter the time duration");
            double time = Convert.ToDouble(Console.ReadLine());
            if (time <= 0)
            {
                Console.WriteLine("Time cannot be negative or zero to calculate speed, enter positive time.");
                return;
            }
            double distance = speed * time;
            Console.WriteLine("Distance Travelled:" + distance);

            Console.ReadKey();
        }
    }
}