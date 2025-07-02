using System.ComponentModel.DataAnnotations;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberofcars);
            Car.StartRace();

            Console.ReadKey();
        }
    }
        class Car
        {
            String model;
            public static int numberofcars;


            public Car(string model)
            {
                this.model = model;
                numberofcars++;
            }
            public static void StartRace()
            {
                Console.WriteLine("Race Started");
            }
        } 

}
