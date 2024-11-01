namespace NonSOLID_OCP;

public class Program
{
    public static void Main()
    {
        Product foodProduct = new Product("Bread", "Food", 100);
        Product electronicsProduct = new Product("Laptop", "Electronics", 1000);
        
        TaxCalculator tc = new TaxCalculator();
        
        Console.WriteLine($"Tax for {foodProduct.Name}: {tc.CalculateTax(foodProduct)}");
        Console.WriteLine($"Tax for {electronicsProduct.Name}: {tc.CalculateTax(electronicsProduct)}");
    }
}