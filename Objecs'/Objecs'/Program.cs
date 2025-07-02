namespace Objecs_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.name = "Rocky";
            human1.age = 21;
            human1.sleep();
            human1.Eat();
            Console.ReadKey();
        }
    }
    class Human
    {
        public string name;
        public int age;


        public void Eat()
        {
            Console.WriteLine(name +" is Eating");
        }
        public void sleep()
        {
            Console.WriteLine(name + " is Sleeping");
        }
    }
}
