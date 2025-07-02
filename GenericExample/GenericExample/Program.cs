namespace GenericExample
{
    internal class Program
    {
        
        public class HelloWorld
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
                Console.ReadKey();
        }
    }
}
}
