
namespace AbstractProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            car.go();
            bicycle.go();
            boat.go();

            Console.WriteLine(car.wheels);
            Console.WriteLine(bicycle.wheels);
            Console.WriteLine(boat.wheels);
            Console.ReadLine();
        }
    }

    class Vehicle
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("The vehicle is currently moving");
        }
    }
    class Car: Vehicle
    {
        public int wheels = 4;
        public void go()
        {
            Console.WriteLine("The car is moving");
        }
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        public void go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        public void go()
        {
            Console.WriteLine("The boat is sailing");
        }
    }
}
