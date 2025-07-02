namespace AlphaNumericCount2
{
    internal class Program
    {
       
    public class HelloWorld
    {
        public static void Main()
        {
            string s = "aabbcdc";
            string x = "";
            int c = 0;
            foreach (char i in s)
            {
                if (!x.Contains(i))
                {
                    x += i;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine(c);
                Console.ReadKey();
        }
    }

}
}
