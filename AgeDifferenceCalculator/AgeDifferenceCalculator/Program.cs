namespace AgeDifferenceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first birthdate (DD/MM/YYYY): ");
            string firstDateInput = Console.ReadLine();

            Console.WriteLine("Enter the second birthdate (DD/MM/YYYY): ");
            string secondDateInput = Console.ReadLine();

            if (DateTime.TryParseExact(firstDateInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime firstDate)
                && DateTime.TryParseExact(secondDateInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime secondDate
                               ))
            {
                (int years, int months, int days) = CalculateAgeDifference(firstDate, secondDate);
                Console.WriteLine($"Age difference : {years} years, {months} months, {days} days");
            }
            else {

                Console.WriteLine("Invalid date format");
            }
            Console.ReadKey();
        }
        public static (int, int, int)   CalculateAgeDifference(DateTime date1, DateTime date2)
        {
            if (date1 > date2)
            {
                DateTime temp = date1;
                date1 = date2;
                date2 = temp;
            }

            int years = date2.Year - date1.Year;
            int months = date2.Month - date1.Month;
            int days = date2.Day - date1.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(date1.Year, date1.Month);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }
            return (years, months, days);
        }
    }
}
