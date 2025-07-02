namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? intVal1 = null;
            int? intVal2 = 786  ;

            float? floatVal1 = 3.14F;
            float? floatVal2 = null;
            bool? boolval = new bool?();
            Console.WriteLine("Nullable integers : {0}, {1}", intVal1, intVal2);
            Console.WriteLine("Nullable floats: {0}, {1}", floatVal1, floatVal2);
            Console.WriteLine("Nullable boolean: {0}" + boolval);
            Console.ReadKey();
        }
    }
}
