namespace BinaryAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first binary number");
            string binarynum1 = Console.ReadLine();

            Console.WriteLine("Enter Second Binary Number");
            string binarynum2 = Console.ReadLine();

            if (!IsBinary(binarynum1) || !IsBinary(binarynum2))
            {
                Console.WriteLine("Error! One or both of the entered values are not binary");
                Console.ReadKey();
                return;
            }
            string result =AddBinary(binarynum1, binarynum2);

            Console.WriteLine("The result of the addition is:", result);
            Console.ReadKey();
            Console.WriteLine(result);
            Console.ReadKey();
            static bool IsBinary(String binary)
            {
                foreach (char c in binary)
                {
                    if (c != '0' && c != '1')
                    {
                        return false;
                    }
                }
                return true;

            }
            static string AddBinary(string a, string b)
            {
                int maxLength = Math.Max(a.Length, b.Length);
                a = a.PadLeft(maxLength, '0');
                b = b.PadLeft(maxLength, '0');
                string result = "";
                int carry = 0;
                for (int i = maxLength - 1; i >= 0; i--)
                {
                    int bitA = a[i] - '0';
                    int bitB = b[i] - '0';

                    int sum = bitA + bitB + carry;

                    result = (sum % 2) + result;
                    carry = (sum / 2);

                }
                if (carry > 0)
                {
                    result = carry + result;
                    
                }
                return result;
            }
            //Console.ReadKey();
        }
    }
}
    