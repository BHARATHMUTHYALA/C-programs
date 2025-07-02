namespace DateTimeCalc
{
    internal class Program
    {
      
     class HelloWorld
    {
        public static void Main()
        {
            DateTime d1 = DateTime.Parse("20/02/2024");
            DateTime d2 = DateTime.Parse("20/04/2025");
            TimeSpan d3 = d2 - d1;
            int y = d3.Days / 365;
            int m = (d3.Days % 365) / 30;
            int d = (d3.Days % 365) % 30;
            Console.WriteLine($"{y} years {m} months {d} days");
                Console.ReadKey();
        }
    }

}
}
