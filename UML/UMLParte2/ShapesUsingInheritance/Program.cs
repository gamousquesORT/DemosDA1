namespace ShapeUsingInheritance;

class Program
{
    static void Main(string[] args)
    {
        Rectangle shape1 = new Rectangle(5, 10);
        Console.WriteLine("Rectangle Area: " + shape1.GetArea());

        Circle shape2 = new Circle(7);
        Console.WriteLine("Circle Area: " + shape2.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape1);
        shapes.Add(shape2);
        
        // listar el area de cada shape usando polimorfismo
        Console.WriteLine("\n-- Ver como se listan las figuras usando polimorfismo --\n");
        ListShapeData(shapes);
        
        // Como agregar un Toy a la lista de shapes???
        Console.WriteLine("\n cómo agregamos un Toy???");
        
    }
    
    public static void ListShapeData(List<Shape> shapes)
    {
        foreach (var s in shapes)
        {
            Console.WriteLine("Area: {0}\n", s.GetArea());
        }
    }
}