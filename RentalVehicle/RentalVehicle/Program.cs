namespace RentalVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(50.0);
            Console.WriteLine(car.GetDescription());
            Console.WriteLine(car.CalculateRentalCost(5));
            Vehicle motorcycle = new MotorCycle(30.0);
            Console.WriteLine(motorcycle.GetDescription());
            Console.WriteLine(motorcycle.CalculateRentalCost(3));
            Console.ReadKey();
        }
        abstract class Vehicle
        {
            public abstract double CalculateRentalCost(int days);
            public abstract string GetDescription();
        }
        class Car : Vehicle
        {
            public double dailyRate;
            public Car(double dailyRate)
            {
                this.dailyRate = dailyRate;
            }
            public override double CalculateRentalCost(int days)
            {
                return days * this.dailyRate;
            }
            public override string GetDescription()
            {
                return $"Car with a daily rate of {this.dailyRate}";
            }
        }
        class MotorCycle : Vehicle
        {
            public double dailyRate;
            public MotorCycle(double dailyRate)
            {
                this.dailyRate = dailyRate;
            }
            public override double CalculateRentalCost(int days)
            {
                return days * this.dailyRate;
            }
            public override string GetDescription()
            {
                return $"MotorCycle with a daily rate of {this.dailyRate}";

            }
        }
    }
}
