namespace ValidHexCode
{
    internal class Program
    {
         static bool IsValidHexCode(string hexCode)
        {
            if(string.IsNullOrEmpty(hexCode)|| hexCode[0] != '#')
            {
                return false;

            }
            if (hexCode.Length != 7)
            {
                return false;
            }
            for(int i = 1; i < hexCode.Length; i++)
            {
                char c = hexCode[i];
                if(!((c>='0' && c<='9')||(c>='A'&& c<='F')||(c>='a' && c <= 'f')))
                {
                    return false;
                }
               
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidHexCode("#CD5C5C")); // true
            Console.WriteLine(IsValidHexCode("#EAECEE")); // true
            Console.WriteLine(IsValidHexCode("#eaecee")); // true
            Console.WriteLine(IsValidHexCode("#CD5C58C")); // false - Length exceeds 6
            Console.WriteLine(IsValidHexCode("#CD5C5Z")); // false - Not all alphabetic characters in A-F
            Console.WriteLine(IsValidHexCode("#CD5C&C")); // false - Contains unacceptable character
            Console.WriteLine(IsValidHexCode("CD5C5C"));
            Console.ReadKey();
        }
    }
}
