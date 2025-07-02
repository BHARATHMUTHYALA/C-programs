namespace AutoImplement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Ford");
            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }
    class Car
    {
        String model;
        public String Model
        {
            get; set;
        }

        public Car(String model)
        {
            this.Model = model;
        }
    }
}