namespace Ayoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("mytext.txt", "Hello nigga");
            Console.WriteLine("File Created With content");
            Console.ReadKey();
        }
    }
}
