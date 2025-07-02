namespace AlphaOrder2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            char[] sorted = s.Replace(" ", "").ToCharArray();
            Array.Sort(sorted);

            string result = "";
            int index = 0;

            foreach (char ch in s)
            {
                if (ch == ' ')
                {
                    result += " ";
                }
                else
                {
                    result += sorted[index++];
                }
            }
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
