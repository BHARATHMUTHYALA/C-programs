namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? intVal1 = null;
            int? intVal2 = 786;

            float? floatVal1 = 3.14f;
            float? floatVal2 = new float?();

            bool? boolval = new bool?();

            Console.WriteLine("Nullable Integers: {0}, {1} ", intVal1, intVal2);
            Console.WriteLine("Nullable floats: {0}, {1}", floatVal1, floatVal2);
            Console.WriteLine("Nullable Bool Types: {0}", boolval);
            Console.ReadKey();
        }
    }
}
