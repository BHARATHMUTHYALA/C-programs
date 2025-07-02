namespace MULTIDIMENSIONAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] parkingLot = { {"Mustang", "F-150","Explorer"},
                                      {"Cheverlotte","Camaro","Silverado" },
                                      {"Corrola" , "Camry", "Rav4"}};
            parkingLot[0, 0] = "Ferrari";
            parkingLot[2, 0] = "Mini Cooper";
            //foreach (String car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}

            for(int i=0; i < parkingLot.GetLength(0); i++)
            {
                for(int j=0; j < parkingLot.GetLength(0); j++)
                {
                    Console.WriteLine(parkingLot[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
