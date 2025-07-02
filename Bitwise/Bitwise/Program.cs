namespace Bitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int andResult = num1 & num2;
            int orResult = num1 | num2;
            int xorResult = num1 ^ num2;
            int notResult = ~num1;
            int leftShiftResult = num1 << 2;
            int rightShiftResult = num1 >> 2;

            Console.WriteLine($"Bitwise AND({num1} & {num2}) =" +
                $"{andResult}");
            Console.WriteLine($"Bitwise OR({num1} | {num2}) =" +
                $"{orResult}");
            Console.WriteLine($"Bitwise XOR({num1} ^ {num2}) =" +
                $"{xorResult}");
            Console.WriteLine($"Bitwise not(~{num1}) =" +
                $"{notResult}");
            Console.WriteLine($"Left Shift({num1} << 2) =" +
                $"{leftShiftResult}");
            Console.WriteLine($"Right Shift( {num1} >> 2) =" +
                $"{rightShiftResult}");
            Console.ReadKey();
        }
    }
}
