namespace CubeRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUMBER TO FIND THE CUBE ROOT");
            string input = Console.ReadLine();
            if(double.TryParse(input,out double number))
            {
                double cuberoot = CalculateCubeRoot(number);
                Console.WriteLine("Cube root of the entered number is {cuberooot}");

            }
        }
    }
}
