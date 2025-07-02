namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 0;
        public void Go()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle{
        public int wheels = 2;
        }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
