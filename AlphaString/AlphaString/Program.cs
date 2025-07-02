namespace AlphaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            string[] words = s.Split();
            string empty = "";
            string total = String.Join(empty, words);
            char[] b = total.ToCharArray();
            Array.Sort(b);
            foreach (char c in b)
            {
                Console.Write(c);
            } 
            Console.ReadKey();
    }
        }
       
}
