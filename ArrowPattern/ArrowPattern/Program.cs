namespace ArrowPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            List<string> arrowPattern = Arrow(num);
            Console.WriteLine("[" + string.Join(", ", arrowPattern) + "]");
            Console.ReadKey();
        }
        static List<string> Arrow(int num)
        {
            List<string> pattern = new List<string>();
            for(int i = 1; i <= num; i++)
            {
                pattern.Add(new string('>',i));
            }
            for(int i = num; i >0; i--)
            {
                pattern.Add(new string('>', i));
            }
            return pattern;
            
        }
    }
}
