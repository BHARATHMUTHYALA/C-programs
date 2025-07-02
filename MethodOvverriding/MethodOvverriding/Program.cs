namespace MethodOvverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.speak();
            cat.speak();

            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void speak()
        {
            Console.WriteLine("The animal goes brrr");
        }

    }
    class Dog: Animal
    {
        public override void speak()
        {
            Console.WriteLine("The dog goes brrr");
        }
    }
    class Cat: Animal
    {
        public override void speak()
        {
            Console.WriteLine("The cat goes meow");
        }
    }
}
