namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();
            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

           Console.ReadLine();
        }



        interface IPrey
        {
            void Flee();
        }
        interface IPredator
        {
            void Hunt();
        }
        class Rabbit: IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit is fleeing for it's life");
            }
        }
        class Hawk: IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is hunting it's prey");
            }
        }
        class Fish:IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish is running from the bigger fish");
            }
            public void Hunt()
            {
                Console.WriteLine("The fish is hunting other smaller fishes");
            }
        }
    }
}
    

