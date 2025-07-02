using System.Globalization;

namespace AWeekLater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekAfter("12/03/2006"));
            Console.WriteLine(WeekAfter("11/12/2993"));
            Console.ReadKey();
        }
        public static string   WeekAfter(string date)
       {
            string format = "dd/MM/yyyy";
            DateTime parsedDate =DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            DateTime weekLater = parsedDate.AddDays(7);
            return weekLater.ToString(format, CultureInfo.InvariantCulture);
        }
    }
}
