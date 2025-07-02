namespace Tpose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = [1, 2, 3, 4, 5];
            double[] doublearray = [1.1, 2.2, 3.3, 4.4, 5.5];
            String[] stringarray = ["1","2","3","4","5"];

            displayElements(intarray);
            displayElements(doublearray);
            displayElements(stringarray);

            Console.ReadKey();
        }

        public static void displayElements<Things>(Things[] array)
        {
            foreach (Things item in array)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
        }
    }
}
