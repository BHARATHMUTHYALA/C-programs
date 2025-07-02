namespace Cube_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number:");
            string input = Console.ReadLine();

            if(double.TryParse(input,out double number))
            {
                double cubeRoot = CalculateCubeRoot(number);
                Console.WriteLine($"Cube root of number is {cubeRoot}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Input: Please enter a valid number");
                Console.ReadKey();
            }

        }

        static double CalculateCubeRoot(double number){
            return Math.Pow(number, 1.0 / 3.0);
        }
    }
}
