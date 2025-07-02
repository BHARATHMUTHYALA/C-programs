using System.Net.Http.Headers;
using System.Reflection;

namespace ObjectasArg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "Red");
            Car car2 = Copy(car1);
            Console.WriteLine(car2.Color + " "+ car2.Model);
            changeColor(car2, "Pink");
            Console.WriteLine(car2.Color+ " "+car2.Model);
            Console.ReadKey();
        }

        public static void changeColor(Car car,String Color)
        {
            car.Color = Color;
        }
        public static Car Copy(Car car)
        {
            return new Car(car.Model, car.Color);
        }
        
    }
    class Car
    {
        public string Model;
        public string Color;

        public Car(string Model, string Color)
        {
            this.Model = Model;
            this.Color = Color;
        }
    }
}
