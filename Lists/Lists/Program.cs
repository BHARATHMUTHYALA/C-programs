namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> food = new List<String>();

            food.Add("Pizza");
            food.Add("Burger");
            food.Add("Fries");
            food.Add("Pasta");
            food.Add("Fries");

            //Console.WriteLine(food[0]);
            //food.Remove(food[0]);
            //food.Insert(0, "Biryani");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("Fries"));
            //Console.WriteLine(food.LastIndexOf("Fries"));
            //Console.WriteLine(food.Contains("Nigga"));
            food.Sort();
            Console.WriteLine();
            food.Reverse();
            //food.Clear();

            foreach(String item in food)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
