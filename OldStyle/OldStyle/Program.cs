namespace OldStyle { 
    internal class Program
    {
static int myResult;

           
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and i'll add 10 to it");
            int num1 = int.Parse(Console.ReadLine());
            myResult = AddTwoValues(num1, 10);
            Console.WriteLine("The result is " + myResult);
            Console.ReadKey();
        }

        static int AddTwoValues(int value1, int value2)
        {
            myResult= value1 + value2;
            return myResult;
        }  

    }
}
