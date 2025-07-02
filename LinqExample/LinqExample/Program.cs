namespace LinqExample
{
    internal class Program
    {
       
public class HelloWorld
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 4, 5, 6, 7, 78, 9, 90 };
            var evennumbers = from n in numbers where n % 2 == 0 select n;

            foreach (var number in evennumbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
}
