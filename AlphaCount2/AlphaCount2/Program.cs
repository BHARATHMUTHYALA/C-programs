namespace AlphaOrder2
{
    internal class Program
    {
  
    class HelloWorld
    {
        public static void Main()
        {
            string s = "hello world";
            string a = String.Join("", s.Split());
            char[] b = a.ToCharArray();
            Array.Sort(b);
            foreach (char i in b)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }


}
}
