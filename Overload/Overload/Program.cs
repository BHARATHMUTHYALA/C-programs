using System.Globalization;

namespace Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("Dough");
          
            Console.WriteLine("The pizza is created");  Console.ReadKey();
        }
    }

   class Pizza
    {
        String bread;
        String sauce;
        String Cheese;
        String topping;
        String pineapple;
        public Pizza(string bread)
        {
            this.bread = bread;

        }
        public Pizza(string bread,string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(string bread, string sauce, string Cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.Cheese = Cheese;

        }
        public Pizza(string bread, string sauce, string Cheese,string topping, string pineapple)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.Cheese = Cheese;
            this.topping = topping;
            this.pineapple = pineapple;

        }



    }
    }

