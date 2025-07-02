using System.Globalization;

namespace TheDayRobWasBorn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDayInDutch(2005,12,30));
            Console.WriteLine(WeekDayInDutch(2005, 12, 31)) ;
            Console.ReadKey();
        }


        public static string WeekDayInDutch (int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);

            CultureInfo dutchCulture = new CultureInfo("nl-NL");

            string weekDayInDutch = date.ToString("dddd", dutchCulture);

            return weekDayInDutch;
        }
    }
}
