using System.Globalization;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Mustang", 2022, "Green");
            Car car2 = new Car("Chevy", "Corvette", 2020, "Yellow");
            car1.Drive();
            car2.Drive();
            Console.ReadKey();
        }
    }
    class Car
    {
        string make;
        string model;
        int year;
        string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;

        }
        public void Drive()
        {
            Console.WriteLine("You are driving the "+make+ " " +model);
        }

    }
}