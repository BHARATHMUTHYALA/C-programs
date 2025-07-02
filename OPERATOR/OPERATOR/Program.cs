namespace OPERATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature=20;
            String message;

            message = (temperature >= 15) ? "It's warm outside" : "It's cold outside";

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
