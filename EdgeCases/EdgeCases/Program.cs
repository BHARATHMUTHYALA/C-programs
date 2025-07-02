namespace EdgeCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0; 
            double number3 = 0;
            double number4 = 0;

            number1 = Math.Pow(double.PositiveInfinity, 2)+1;
            number2 = Math.Pow(double.NegativeInfinity, 2);
            number3 = Math.Pow(double.MinValue, 0);
            number4 = Math.Pow(double.NaN, 2);

            Console.WriteLine("Number1:{0}",number1);
            Console.WriteLine("Number2:{0}", number2);
            Console.WriteLine("Number3:{0}",number3);
            Console.WriteLine("Number4:{0}", number4);
            Console.ReadKey();
        }
    }
}
