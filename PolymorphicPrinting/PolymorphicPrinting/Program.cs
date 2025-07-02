namespace PolymorphicPrinting
{
    internal class Program
    {
        static void print(int n)
        {
            Console.WriteLine("Integer value is: " + n);
        }
        static void print(float n)
        {
            Console.WriteLine("Floating point value: " + n);
        }
        static void print(string n)
        {
            Console.WriteLine("String value is " + n);
        }

        public static void Main(string[] args)
        {
            print(10);
            print(10.9891F);
            print("Hello");
            Console.ReadKey();
        }
    }
}
