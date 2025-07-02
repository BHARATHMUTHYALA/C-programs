namespace DuplicateCOUNTER2
{
    internal class Program
    {
        public static void Main()
        {
            string s = "aabbcdcdd";
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
            Console.WriteLine("The total number of repeated characters are " + c);

            Console.ReadKey();
        }
    }
}
