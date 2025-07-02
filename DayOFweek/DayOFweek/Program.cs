namespace DayOFweek
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("01/01/2025");
            DateTime d2 = DateTime.Parse("1/01/2026");
            DayOfWeek d3 = DayOfWeek.Friday;
            int c = 0;
            for (DateTime i = d1; i <= d2; i.AddDays(1))
            {
                if (i.DayOfWeek == d3)
                {
                    c++;
                }
            }
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}

