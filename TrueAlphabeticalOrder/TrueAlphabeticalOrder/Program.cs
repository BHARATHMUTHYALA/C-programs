
namespace TrueAlphabeticalOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TrueAlphabet("hello world"));
            Console.WriteLine(TrueAlphabet("iare is awesome"));
            Console.WriteLine(TrueAlphabet("have a nice day"));
            Console.ReadKey();
        }
        public static string TrueAlphabet(string input)
        {
            var sortedChars = new string(input.Replace(" ", "").OrderBy(c => c).ToArray());

            var result = "";
            var index = 0;

            foreach (var word in input.Split(' ')) {
                if (result.Length > 0)
                {
                    result += " ";
                }
                result += sortedChars.Substring(index, word.Length);
                index += word.Length;

            }
            return result;
        }
    }
}