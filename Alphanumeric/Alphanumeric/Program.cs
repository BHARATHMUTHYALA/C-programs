using System.Text.RegularExpressions;
namespace Alphanumeric
{
    internal class Program
    {



class Porgram
    {
        static void Main(string[] args)
        {
            string input = "Hello123World";
            string pattern = @"\d";

            bool containsDigit = Regex.IsMatch(input, pattern);

            if (containsDigit)
            {
                Console.WriteLine("The given expression is alphanumeric");
            }
            else
            {
                Console.WriteLine("The Expression is purely non alphanumeric");
            }
                Console.ReadKey();
        }
    }
}
}
