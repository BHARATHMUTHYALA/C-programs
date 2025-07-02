namespace OOPShapes
{
    public abstract class Shape
    {
        public abstract void DisplayArea();
    }
    class Rectangle : Shape
    {
        public double l;
        public double b;
        public Rectangle(double l, double b)
        {
            this.l = l;
            this.b = b;
        }
        public override void DisplayArea()
        {
            Console.WriteLine("The area of the rectangle is " + (l * b));
        }
    }
    class Square : Shape
    {
        public double a;
        public Square(double a)
        {
            this.a = a;
        }
        public override void DisplayArea()
        {
            Console.WriteLine("The area of the square is " + (a * a));
        }
    }
    class Circle : Shape
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void DisplayArea()
        {
            Console.WriteLine("The area of the circle is " + Math.PI * radius * radius);
        }
    }
    class Triangle : Shape
    {
        public double b;
        public double h;
        public Triangle(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public override void DisplayArea()
        {
            Console.WriteLine("The area of the triangle is " + (0.5 * b * h));
        }
    }
    class Hello
    {
        public static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(4, 5);
            Square sq = new Square(4);
            Circle circle = new Circle(7);
            Triangle t = new Triangle(2, 4);

            rec.DisplayArea();
            sq.DisplayArea();
            circle.DisplayArea();
            t.DisplayArea();
            Console.ReadKey();
        }
    }
}
