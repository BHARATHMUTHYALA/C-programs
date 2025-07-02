namespace AlphaOrder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(TrueAlphabetic("hello world"));
            Console.WriteLine(TrueAlphabetic("iare is awesome"));
            Console.WriteLine(TrueAlphabetic("have a niceday"));
            Console.ReadKey();
        }
        public static string TrueAlphabetic(string input)
        {
            var sortedChars = new string(input.Replace(" ", "").OrderBy(c => c).ToArray());

            var result = "";
            var index = 0;

            foreach (var word in input.Split(" "))
            {
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
