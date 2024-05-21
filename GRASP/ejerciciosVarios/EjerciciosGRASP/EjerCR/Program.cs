// See https://aka.ms/new-console-template for more information
namespace EjerCR;

public class Program
{
    public static void Main()
    {
        Order order = new Order();
        order.AddProduct("Laptop", 1500.00);
        order.AddProduct("Smartphone", 800.00);

        foreach (var product in order.Products)
        {
            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
        }
    }
}