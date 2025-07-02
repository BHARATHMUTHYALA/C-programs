namespace ConvertToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Honda", "Civic", 2021, "Yellow");
            Console.WriteLine( car.ToString());
            Console.ReadKey();
        }
       
    }
                
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.model = model;
            this.year = year;
            this.make = make;
            this.color = color;

        }
        public override string ToString()
        {
            return "This is a "+make+ " " + model +" car";
        }
    }
}
