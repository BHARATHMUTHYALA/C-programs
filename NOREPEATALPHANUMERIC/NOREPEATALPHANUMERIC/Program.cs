namespace NOREPEATALPHANUMERIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("abcde"));
            Console.WriteLine(DuplicateCount("aabsfafawef"));
            Console.WriteLine(DuplicateCount("Aa"));
            Console.WriteLine(DuplicateCount("I n d i v i s i b i l i t i e s"));
            Console.ReadKey();
        }
        public static int DuplicateCount(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach(char ch in input)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    if (charCount.ContainsKey(ch))
                    {
                        charCount[ch]++;
                    }
                    else
                    {
                        charCount[ch] = 1;
                    }
                }
            }
            int DuplicateCount = 0;
            foreach(int count  in charCount.Values)
            {
                if (count > 1)
                {
                    DuplicateCount++;

                }

            }
            return DuplicateCount;
        }
    }
}
