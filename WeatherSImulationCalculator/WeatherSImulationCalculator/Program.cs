namespace WeatherSImulationCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate");
            int days = int.Parse(Console.ReadLine());
            int[] temperature = new int[days];
            string[] conditions = { "Cloudy", "Snowy", "Rainy", "Sunny" };
            string[] weatherConditions = new string[days];

            Random random = new Random();
            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            temperature.Min();

            double averageTemp = CalculateAverage([30, 20]);
            Console.WriteLine($"The average temperature is {CalculateAverage(temperature)}");
            Console.WriteLine($"The max temp is {temperature.Max()}");
            Console.WriteLine($"The min temp is {temperature.Min()}");

            Console.WriteLine($"The min temp is {MinTemperature(temperature)}");

            Console.ReadLine();

        }


        static int CalculateAverage(int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }
            double average = sum / temperature.Length;

            return (int)average;
        }



        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostcommmon = conditions[0];
            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions[i].Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        if (conditions[j] == conditions[i])
                        {
                            tempCount++;
                        }
                    }
                    if (tempCount > count)
                    {
                        count = tempCount;
                        mostcommmon = conditions[i];
                    }

                }
            }

            return mostcommmon;
        }
            static int MinTemperature(int[] temperature)
            {
                int min = temperature[0];

                for (int i = 0; i < temperature.Length; i++)
                {
                    if (temperature[i] < min)
                    {
                        min = temperature[i];
                    }
                }
                return min;
            }
        
    }
}
