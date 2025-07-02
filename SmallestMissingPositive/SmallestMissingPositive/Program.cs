namespace SmallestMissingPositive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { -2, 6, 4, 5, 7, -1, 1, 3, 6, -2, 9, 10, 2, 2 };
            Console.WriteLine(MinMissPos(arr1));
        }
        public static int MinMissPos(int[] arr)
        {
            Array.Sort(arr);
            int smallestMissingPositive = 1;
            foreach(int num in arr)
            {
                if (num <= 0){
                    continue;
                }
                if(num== smallestMissingPositive)
                {
                    smallestMissingPositive++;
                }
            }
            return smallestMissingPositive;
        }
    }
}
