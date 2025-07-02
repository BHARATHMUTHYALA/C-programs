using System.Reflection.Metadata.Ecma335;

namespace DateValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Date in format of DD/MM/YYYY");
            string input = Console.ReadLine();

            if (IsValidDate(input, out int day, out int month, out int year))
            {
                Console.WriteLine("The date is valid");
            }
            else
            {
                Console.WriteLine("The date is invalid");
            }
            Console.ReadKey();

        }

        public static bool IsValidDate(string date, out int day, out int month, out int year)
        {
            day = 0;
            month = 0;
            year = 0;

            string[] parts = date.Split('/');
            if (parts.Length != 3)
            {
                return false;

            }
            if (!int.TryParse(parts[0], out day) || (!int.TryParse(parts[1], out month)) || (!int.TryParse(parts[2], out year)))
            {
                return false;
            }
            if (year < 1)
            {
                return false;

            }
            if(month<1 || month > 12)
            {
                return false;
            }
            int daysInMonth = GetDaysInMonth(month, year);
            if(day<1 || day > daysInMonth)
            {
                return false;
            }

            return true;
        }


        public static int GetDaysInMonth(int month, int year)
        {
            if (month == 2)
            {
                return IsLeapYear(year) ? 29 : 28;

            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }

            return 31;
        }
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 &&  year%100!=0 ) || (year%400==0);
            
        }

    }
}
