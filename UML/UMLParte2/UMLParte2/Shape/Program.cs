using System;
namespace Shape;

class Program
{
    static void Main(string[] args)
    {
        IShape shape1 = new Rectangle(5, 10);
        Console.WriteLine("Rectangle Area: " + shape1.GetArea());

        IShape shape2 = new Circle(7);
        Console.WriteLine("Circle Area: " + shape2.GetArea());
    }
}