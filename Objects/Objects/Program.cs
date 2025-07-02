namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();
            human1.name = "Modda";
            human1.age = 99;

            human2.name = "Ganesh";
            human2.age=(199);
            human1.Eat();
            human2.Eat();
            human2.Sleep();


        }
    }

    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name+" is Eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is Sleeping");
        }
    }
}
