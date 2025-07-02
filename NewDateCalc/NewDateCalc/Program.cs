using System.Globalization;

namespace NewDateCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.ParseExact("20/3/1221", "d/M/yyyy", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("27/3/1222", "d/M/yyyy", CultureInfo.InvariantCulture);
            TimeSpan d3 = d2 - d1;
            int y = d3.Days / 365;
            int m = (d3.Days % 365) / 30;
            int d = (d3.Days % 365) % 30;
            Console.WriteLine($"{y} years {m} months and {d} days");
            Console.ReadKey();
        }
    }
}
