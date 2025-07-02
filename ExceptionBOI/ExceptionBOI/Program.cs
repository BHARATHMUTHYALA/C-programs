namespace ExceptionBOI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            double result;

            try
            {
                Console.WriteLine("Enter number 1:");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2:");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;
                Console.WriteLine("The result of the division of both the numbers is  " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Do not divide by zero");

            }
            catch (Exception e)
            {
                Console.WriteLine("The exception is" + e);
            }
            finally
            {
                Console.WriteLine("The process of division is complete");
            }
            Console.ReadKey();
        }
    }
}
