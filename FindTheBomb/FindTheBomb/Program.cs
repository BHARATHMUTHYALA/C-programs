
namespace FindTheBomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bomb("There is a bomb"));
            Console.WriteLine(Bomb("Hey did you think there is a bomb?: "));
            Console.WriteLine(Bomb("This goes Boom"));
            Console.ReadKey();

        }
        public static string Bomb(String txt)
        {
            string lowerCaseText = txt.ToLower();

            if (lowerCaseText.Contains("bomb"))
            {
                return "DUCK";
            }
            else
            {
                return "THERE IS NO BOMB RELAX";
            }
        }
    }
}
