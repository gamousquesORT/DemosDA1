namespace ShapeUsingInheritance;

class Program
{
    static void Main(string[] args)
    {
        Shape shape1 = new Rectangle(5, 10);
        Console.WriteLine("Rectangle Area: " + shape1.GetArea());

        Shape shape2 = new Circle(7);
        Console.WriteLine("Circle Area: " + shape2.GetArea());
    }
}