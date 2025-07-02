using System.Text.RegularExpressions;

namespace HEXCODE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^#[0-9A-Fa-f]{6}$";
            string s = "#AC6FFB";
            if (Regex.IsMatch(pattern, s))
            {
                Console.WriteLine("This is a valid hexcode");
            }
            else
            {

                Console.WriteLine("It is not a valid hexcode");
            }
            Console.ReadKey();
        }
       
    }
}
