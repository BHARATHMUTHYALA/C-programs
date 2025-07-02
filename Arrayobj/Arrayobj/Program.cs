namespace Arrayobj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] garage = {new Car("Mustang"),new Car("Corvette"), new Car("Camaro") };
            foreach (Car car in garage)
            {
                System.Console.WriteLine(car.Model);
            }
            Console.ReadKey();
        }
    }
    class Car
    {
        public String Model;
        public Car(String Model)
        {
            this.Model = Model;
        }
    }

}
